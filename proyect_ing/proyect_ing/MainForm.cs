/*
 * Created by SharpDevelop.
 * User: Arturo
 * Date: 29/04/2014
 * Time: 08:02 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
namespace proyect_ing
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		/*
		public MySqlCommand myCmdQuery;
		public MySqlDataAdapter myDataAdapter;
		public BindingSource myBindingSource;
		public MySqlCommandBuilder myCommandBuilder;
		public DataSet myDataSet;
		public MySqlConnection myConnection;
		public string myStringCon;
		*/
		private MainForm main;
		private string id;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			/*
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
		*/
		}
		
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		
		void AbrirSesionToolStripMenuItemClick(object sender, EventArgs e)
		{
       Formlogin a = new Formlogin();
				a.Show(); 
				this.Hide();
			   this.Visible = true ;
			   this.Visible = false;
			}
		
		
		
			
	
	}
	
	
}
