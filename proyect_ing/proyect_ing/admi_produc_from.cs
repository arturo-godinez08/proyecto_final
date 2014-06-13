/*
 * Created by SharpDevelop.
 * User: Arturo
 * Date: 24/05/2014
 * Time: 12:36 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.Common;

namespace proyect_ing
{
	/// <summary>
	/// Description of admi_produc_from.
	/// </summary>
	public partial class admi_produc_from : Form
	{
	    public MySqlCommand myCmdQuery;
		public MySqlDataAdapter myDataAdapter;
		public BindingSource myBindingSource;
		public MySqlCommandBuilder myCommandBuilder;
		public DataSet myDataSet;
		public MySqlConnection myConnection;
		
		public string myStringCon;
		
	//	public MySqlDataReader reader;
	     public Productos prod;
		//private string id;
		public admi_produc_from()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
		
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			this.prod = prod;
			//this.id = id;
			//this.reader = reader;
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
		
		void DataGridViewADM_ProCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
		
		void ButtonAgregarClick(object sender, EventArgs e)
		{
			FormNuevoProducto a = new FormNuevoProducto();
			a.Show();
			//this.Hide();
			//this.Visible = true;
		}
		
		
	
		
		
		void Admi_produc_fromLoad(object sender, EventArgs e)
		{
		/*
           MySqlConnection cn;
            MySqlCommand cmd;
            MySqlDataReader reader;
            this.prod = new Productos();
            //this.myDataSet = new Productos();
        try{
        	cn = new MySqlConnection("server=localhost;database=ecom;userid=root;password=manson666;");
        	
        	cn.Open();
        	
        	cmd = new MySqlCommand("select * from productos",cn);
        	
        	reader=cmd.ExecuteReader();
        	
        	while(reader.Read()){
        		
        		this.dataGridViewADM_Pro.Rows.Add(reader.GetValue(0),reader.GetValue(1),reader.GetValue(2),reader.GetValue(3),reader.GetValue(4));
        		
        	}
        
          			
		}
        catch(Exception ex) {
        	MessageBox.Show("Error");
        	
        	
        }
        */
         
        
         this.prod = new Productos();
         
        
         
        this.myConnection = new MySqlConnection(this.myStringCon);
			try{
				this.myConnection.Open();
			}catch(MySqlException ex){
				MessageBox.Show(ex.Message);
				System.Environment.Exit(1);
			}
			
			this.myCmdQuery.CommandText="SELECT * FROM productos";
			this.myCmdQuery.CommandType=CommandType.Text;
			this.myCmdQuery.Connection=this.myConnection;
			
			this.myDataAdapter.SelectCommand=this.myCmdQuery;
			this.myCommandBuilder.DataAdapter=this.myDataAdapter;

			//Llenar el dataset
			this.myDataAdapter.Fill(this.myDataSet,"productos");
			this.myBindingSource.DataSource=this.myDataSet;
			this.myBindingSource.DataMember="productos";
			this.dataGridViewADM_Pro.DataSource=this.myBindingSource; 
          
		
		}
		
		void ButtonEditarClick(object sender, EventArgs e)
		{
			 
			
			
			if(this.dataGridViewADM_Pro.SelectedRows.Count>0){
				DataGridViewRow row = this.dataGridViewADM_Pro.SelectedRows[0];
				DataGridViewCell cell = row.Cells[0];
				string id = cell.Value.ToString();
				Editar_ProductoForm editar = new Editar_ProductoForm(id);
			    editar.Show();
			    //this.Hide();
			    //this.Visible = true;
			   

			
		}
	}
		public int ejecutarComando(string sql){
			MySqlCommand myCommand = new MySqlCommand(sql,this.myConnection);
			int afectadas = myCommand.ExecuteNonQuery();
			myCommand.Dispose();
			myCommand = null;
			return afectadas;
		}
		
		
 
		public void actualizarTabla(){
			 try{
				
				this.myConnection = new MySqlConnection(this.myStringCon);
			try{
				this.myConnection.Open();
			}catch(MySqlException ex){
				MessageBox.Show(ex.Message);
				System.Environment.Exit(1);
			}
			
			this.myCmdQuery.CommandText="SELECT * FROM productos";
			this.myCmdQuery.CommandType=CommandType.Text;
			this.myCmdQuery.Connection=this.myConnection;
			
			this.myDataAdapter.SelectCommand=this.myCmdQuery;
			this.myCommandBuilder.DataAdapter=this.myDataAdapter;

				this.myDataSet.Clear();
				this.myDataAdapter.Fill(this.myDataSet,"productos");
				this.myBindingSource.DataSource=this.myDataSet;
				this.myBindingSource.DataMember="productos";
				this.dataGridViewADM_Pro.DataSource=this.myBindingSource;
				this.dataGridViewADM_Pro.Update();
				this.dataGridViewADM_Pro.Refresh();
			}catch(MySqlException ex){
				MessageBox.Show(ex.Message);
			}
		
			
		}
		
	
		
		void ButtonEliminarClick(object sender, EventArgs e)
		{
		 {
			if(this.dataGridViewADM_Pro.SelectedRows.Count>0){
				DataGridViewRow row = this.dataGridViewADM_Pro.SelectedRows[0];
				DataGridViewCell cell0 = row.Cells[0];
				DataGridViewCell cell1 = row.Cells[1];
				DataGridViewCell cell2 = row.Cells[2];
				DataGridViewCell cell3 = row.Cells[3];
				DataGridViewCell cell4 = row.Cells[4];
				string id = cell0.Value.ToString();
				string nombre = cell1.Value.ToString();
				string tipo = cell2.Value.ToString();
				string precio_unitario = cell3.Value.ToString();
				string stock = cell4.Value.ToString();
				System.Windows.Forms.DialogResult result = MessageBox.Show(
					"¿Está seguro que desea eliminar al producto con nombre " + nombre + "?", "Confirmar eliminación",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question,
					MessageBoxDefaultButton.Button1
				);
				
				if(result == System.Windows.Forms.DialogResult.Yes){
					this.prod.eliminarProducto(id);
					this.actualizarTabla();
					MessageBox.Show("El producto con el nombre " + nombre + " fue eliminado con exito.");
				}
			}
		}
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
          
			try{
				this.myDataSet.Clear();
				this.myDataAdapter.Fill(this.myDataSet,"productos");
				this.myBindingSource.DataSource=this.myDataSet;
				this.myBindingSource.DataMember="productos";
				this.dataGridViewADM_Pro.DataSource=this.myBindingSource;
				this.dataGridViewADM_Pro.Update();
				this.dataGridViewADM_Pro.Refresh();
			}catch(MySqlException ex){
				MessageBox.Show(ex.Message);
			}
		}
}
}
