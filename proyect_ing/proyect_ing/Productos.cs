/*
 * Created by SharpDevelop.
 * User: Arturo
 * Date: 24/05/2014
 * Time: 06:31 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Collections;
using MySql.Data.MySqlClient;


namespace proyect_ing
{
	/// <summary>
	/// Description of Productos.
	/// </summary>
	public class Productos : project_ing.MySQL
	{
		 
            
            public string nombre,tipo,precio_unitario,stock;
		public Productos()
		{
		}
	
		public void mostrarTodos(){
			this.abrirConexion();
            MySqlCommand myCommand = new MySqlCommand(this.querySelect(), 
			                                          myConnection);
            MySqlDataReader myReader = myCommand.ExecuteReader();	
	        while (myReader.Read()){
	            string id = myReader["id"].ToString();
	            string nombre = myReader["nombre"].ToString();
	            string tipo = myReader["tipo"].ToString();
	            string precio_unitario = myReader["precio_unitario"].ToString();
	            string stock = myReader["stock"].ToString();
	            
	       }
			
            myReader.Close();
			myReader = null;
            myCommand.Dispose();
			myCommand = null;
			this.cerrarConexion();
		}
		
		public Hashtable obtenerPorId(string id){
			Hashtable registro = new Hashtable();
			this.abrirConexion();
			
             MySqlCommand mycommand = new MySqlCommand("SELECT * FROM productos WHERE id = '"+id+"'", 
			                                          myConnection);
            MySqlDataReader myReader = mycommand.ExecuteReader();	
            if(myReader.HasRows){
	        	myReader.Read();
	        	registro["id"] = myReader["id"].ToString();
	            registro["nombre"] = myReader["nombre"].ToString();
	            registro["tipo"] = myReader["tipo"].ToString();
	            registro["precio_unitario"] = myReader["precio_unitario"].ToString();
	            registro["stock"] = myReader["stock"].ToString();
	       }
          
            myReader.Close();
			myReader = null;
            mycommand.Dispose();
			mycommand = null;
			this.cerrarConexion();
			return registro;
            
		}
	
	public int ejecutarComando(string sql){
			MySqlCommand myCommand = new MySqlCommand(sql,this.myConnection);
			int afectadas = myCommand.ExecuteNonQuery();
			myCommand.Dispose();
			myCommand = null;
			return afectadas;
		
		
	}
		
		public void editar(string id, string nombre, string tipo, string precio_unitario, string stock){
            	
			    this.abrirConexion();
			     string sql = "UPDATE `productos` SET `id`='" + id + "', `nombre`='" + nombre + "', `tipo`='" + tipo + "',`precio_unitario`='" + precio_unitario + "', `stock`='" + stock + "' WHERE (`id`='" + id + "')";
			    this.ejecutarComando(sql);
			    this.cerrarConexion();
		}
		
		
		
	public void eliminarProducto(string id){
			
			this.abrirConexion();
			string sql = "DELETE FROM `productos` WHERE (`id`='" + id + "')";
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}
		
		public void insertarRegistroNuevo(string nombre, string tipo, string precio_unitario, string stock){
			this.abrirConexion();
			string sql = "INSERT INTO `productos` (`nombre`, `tipo`, `precio_unitario`, `stock`) VALUES ('" + nombre + "', '" + tipo + "', '" + precio_unitario + "', '" + stock + "')";
			this.ejecutarComando(sql);
			this.cerrarConexion();   
		}
		private string querySelect(){
			return "SELECT * " +
	           	"FROM productos";
		}
	
	
	}
}
