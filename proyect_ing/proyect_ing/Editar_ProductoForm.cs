/*
 * Created by SharpDevelop.
 * User: Arturo
 * Date: 27/05/2014
 * Time: 09:56 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace proyect_ing
{
	/// <summary>
	/// Description of Editar_ProductoForm.
	/// </summary>
	public partial class Editar_ProductoForm : Form
		
	{
		public admi_produc_from admi;
		public string id;
		public Productos producto;
		
		public Editar_ProductoForm(string id)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			this.admi = admi;
			this.id = id;
			this.producto = producto;
			this.producto = new Productos();
			this.admi = new admi_produc_from();
		}
		
		void ButtonGuardarEditadoClick(object sender, EventArgs e)
		{
		    
			if(this.textNombreE.Text.Trim()!="" && this.textTipoE.Text.Trim()!="" && this.textPrecioE.Text.Trim()!="" && this.textStockE.Text.Trim()!=""){
				Productos producto = new Productos();
				producto.editar(this.id, this.textNombreE.Text.Trim(), this.textTipoE.Text.Trim(), this.textPrecioE.Text.Trim(), this.textStockE.Text.Trim());
				this.admi.actualizarTabla();
				MessageBox.Show("Se editó con exito");
		     	this.Close();
			}
			
			
		}
		
		
		void Editar_ProductoFormLoad(object sender, EventArgs e)
		{
           System.Collections.Hashtable registro = new System.Collections.Hashtable();
			Productos producto = new Productos();
			registro= producto.obtenerPorId(this.id);
			this.textNombreE.Text =registro["nombre"].ToString();
			this.textTipoE.Text =registro["tipo"].ToString(); 
        	this.textPrecioE.Text =registro["precio_unitario"].ToString();
        	this.textStockE.Text =registro["stock"].ToString();
		}
	}
}
