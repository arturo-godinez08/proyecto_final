/*
 * Created by SharpDevelop.
 * User: Arturo
 * Date: 20/05/2014
 * Time: 09:45 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using MySql.Data.MySqlClient;

namespace project_ing
{
	public class MySQL
	{
		protected MySqlConnection myConnection;
		public MySQL ()
		{
		}

		public void abrirConexion(){
			string connectionString =
          		"Server=localhost;" +
	          	"Database=ecom;" +
	          	"User ID=root;" +
	          	"Password=manson666;" +
	          	"Pooling=false;";
	       this.myConnection = new MySqlConnection(connectionString);
	       this.myConnection.Open();
		}

		public void cerrarConexion(){
			this.myConnection.Close(); 
			this.myConnection = null;
		}
	}
}