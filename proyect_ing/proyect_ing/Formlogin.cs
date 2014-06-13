/*
 * Created by SharpDevelop.
 * User: Arturo
 * Date: 17/05/2014
 * Time: 04:01 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyect_ing
{
	/// <summary>
	/// Description of Formlogin.
	/// </summary>
	public partial class Formlogin : Form
	{
		public Formlogin()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void BoxContraseñaTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void LabelContraseñaClick(object sender, EventArgs e)
		{
			
		}
		
		void ButtonAceptar1Click(object sender, EventArgs e)
		{
        
			if(BoxUsuario.Text == "ad" && BoxContraseña.Text == "1234"){
				
				FormInicio a = new FormInicio();
				a.Show(); 
				this.Hide();
			   
				
				
			}
			else
				MessageBox.Show("Error");
		}
	}
}
