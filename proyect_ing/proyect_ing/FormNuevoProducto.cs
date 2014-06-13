/*
 * Created by SharpDevelop.
 * User: Arturo
 * Date: 23/05/2014
 * Time: 11:06 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace proyect_ing
{
	/// <summary>
	/// Description of FormNuevoProducto.
	/// </summary>
	public partial class FormNuevoProducto : Form
	{
		public admi_produc_from admi;
		private string id;
		
		 public MySqlCommand myCmdQuery;
		public MySqlDataAdapter myDataAdapter;
		public BindingSource myBindingSource;
		public MySqlCommandBuilder myCommandBuilder;
		public DataSet myDataSet;
		public MySqlConnection myConnection;
		public string myStringCon;
		
		public FormNuevoProducto()
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
			this.admi = new admi_produc_from();
			
			this.myCmdQuery= new MySqlCommand();
			this.myDataAdapter=new MySqlDataAdapter();
			this.myBindingSource=new BindingSource();
			this.myCommandBuilder =new MySqlCommandBuilder();
			this.myDataSet=new DataSet();
			this.myStringCon=
				"Server=localhost;" +
				"Database=ecom;" +
				"User ID=root;" +
				"Password=manson666;" +
				"Pooling=false;";
		}
		
		void ButtonGuardarClick(object sender, EventArgs e)
		{
			if(this.textNombre.Text.Trim()!="" && this.textTipo.Text.Trim()!="" && this.textPrecio.Text.Trim()!="" && this.textStock.Text.Trim()!=""){
				Productos producto = new Productos();
				producto.insertarRegistroNuevo(this.textNombre.Text.Trim(), this.textTipo.Text.Trim(), this.textPrecio.Text.Trim(), this.textStock.Text.Trim());
				this.admi.actualizarTabla();
				System.Windows.Forms.DialogResult result = MessageBox.Show(
					"El producto se agregó con exito ¿Desea agregar otro producto?", "Nuevo producto",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question,
					MessageBoxDefaultButton.Button1
				);
				
				if(result != System.Windows.Forms.DialogResult.Yes){
					this.Close();
				}else{
					this.textNombre.Clear();
					this.textPrecio.Clear();
					this.textPrecio.Clear();
					this.textStock.Clear();
				}
			}
	}
		
		void FormNuevoProductoLoad(object sender, EventArgs e)
		{
			
		}
}
}