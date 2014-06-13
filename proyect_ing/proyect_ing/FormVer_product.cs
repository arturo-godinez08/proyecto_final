/*
 * Created by SharpDevelop.
 * User: Arturo
 * Date: 20/05/2014
 * Time: 09:17 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace proyect_ing
{
	/// <summary>
	/// Description of FormAdm_product.
	/// </summary>
	public partial class FormVer_product : Form
		
	{
		 public MySqlCommand myCmdQuery;
		public MySqlDataAdapter myDataAdapter;
		public BindingSource myBindingSource;
		public MySqlCommandBuilder myCommandBuilder;
		public DataSet myDataSet;
		public MySqlConnection myConnection;
		public string myStringCon;
		public FormVer_product()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
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
		
		void ButtonMostrarClick(object sender, EventArgs e)
		{
        
	     
		} 
	      
		
		void FormVer_productLoad(object sender, EventArgs e){
           /*
          MySqlConnection cn;
            MySqlCommand cmd;
            MySqlDataReader reader;

        try{
        	cn = new MySqlConnection("server=localhost;database=ecom;userid=root;password=manson666;");
        	
        	cn.Open();
        	
        	cmd = new MySqlCommand("select * from productos",cn);
        	
        	reader=cmd.ExecuteReader();
        	
        	while(reader.Read()){
        		
        		this.dataGridView1.Rows.Add(reader.GetValue(0),reader.GetValue(1),reader.GetValue(2),reader.GetValue(3),reader.GetValue(4));
        		
        	}
        
          			
		}
        catch(Exception ex) {
        	MessageBox.Show("Error");
        	
        	
        }			
*/
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
			this.dataGridView1.DataSource=this.myBindingSource; 
			
		}
	
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
			
			
		}
	}
}
