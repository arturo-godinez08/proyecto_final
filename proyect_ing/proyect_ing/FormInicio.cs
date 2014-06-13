/*
 * Created by SharpDevelop.
 * User: Arturo
 * Date: 17/05/2014
 * Time: 04:13 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyect_ing
{
	/// <summary>
	/// Description of FormInicio.
	/// </summary>
	public partial class FormInicio : Form
	{
		public FormInicio()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void AdministrarProductosToolStripMenuItemClick(object sender, EventArgs e)
		{
			admi_produc_from a = new admi_produc_from();
			a.Show();
			this.Hide();
			this.Visible = true ;
		   	
       
		}
		
		void VerProductosToolStripMenuItemClick(object sender, EventArgs e)
		{
				
			    FormVer_product a = new FormVer_product();
				a.Show(); 
				this.Hide();
				this.Visible = true ;
				
		}
	}
}
