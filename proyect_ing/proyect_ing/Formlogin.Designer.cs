/*
 * Created by SharpDevelop.
 * User: Arturo
 * Date: 17/05/2014
 * Time: 04:01 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace proyect_ing
{
	partial class Formlogin
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.labelUsuario = new System.Windows.Forms.Label();
			this.BoxUsuario = new System.Windows.Forms.TextBox();
			this.labelContraseña = new System.Windows.Forms.Label();
			this.BoxContraseña = new System.Windows.Forms.TextBox();
			this.buttonAceptar1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelUsuario
			// 
			this.labelUsuario.Location = new System.Drawing.Point(105, 28);
			this.labelUsuario.Name = "labelUsuario";
			this.labelUsuario.Size = new System.Drawing.Size(100, 23);
			this.labelUsuario.TabIndex = 0;
			this.labelUsuario.Text = "Usuario";
			this.labelUsuario.Click += new System.EventHandler(this.Label1Click);
			// 
			// BoxUsuario
			// 
			this.BoxUsuario.Location = new System.Drawing.Point(105, 68);
			this.BoxUsuario.Name = "BoxUsuario";
			this.BoxUsuario.Size = new System.Drawing.Size(123, 20);
			this.BoxUsuario.TabIndex = 1;
			// 
			// labelContraseña
			// 
			this.labelContraseña.Location = new System.Drawing.Point(105, 107);
			this.labelContraseña.Name = "labelContraseña";
			this.labelContraseña.Size = new System.Drawing.Size(100, 23);
			this.labelContraseña.TabIndex = 2;
			this.labelContraseña.Text = "Contraseña";
			this.labelContraseña.Click += new System.EventHandler(this.LabelContraseñaClick);
			// 
			// BoxContraseña
			// 
			this.BoxContraseña.Location = new System.Drawing.Point(105, 143);
			this.BoxContraseña.Name = "BoxContraseña";
			this.BoxContraseña.PasswordChar = '*';
			this.BoxContraseña.Size = new System.Drawing.Size(123, 20);
			this.BoxContraseña.TabIndex = 3;
			this.BoxContraseña.TextChanged += new System.EventHandler(this.BoxContraseñaTextChanged);
			// 
			// buttonAceptar1
			// 
			this.buttonAceptar1.Location = new System.Drawing.Point(151, 205);
			this.buttonAceptar1.Name = "buttonAceptar1";
			this.buttonAceptar1.Size = new System.Drawing.Size(75, 23);
			this.buttonAceptar1.TabIndex = 4;
			this.buttonAceptar1.Text = "Aceptar";
			this.buttonAceptar1.UseVisualStyleBackColor = true;
			this.buttonAceptar1.Click += new System.EventHandler(this.ButtonAceptar1Click);
			// 
			// Formlogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(395, 252);
			this.Controls.Add(this.buttonAceptar1);
			this.Controls.Add(this.BoxContraseña);
			this.Controls.Add(this.labelContraseña);
			this.Controls.Add(this.BoxUsuario);
			this.Controls.Add(this.labelUsuario);
			this.Name = "Formlogin";
			this.Text = "Formlogin";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button buttonAceptar1;
		private System.Windows.Forms.TextBox BoxContraseña;
		private System.Windows.Forms.Label labelContraseña;
		private System.Windows.Forms.TextBox BoxUsuario;
		private System.Windows.Forms.Label labelUsuario;
	}
}
