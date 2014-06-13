/*
 * Created by SharpDevelop.
 * User: Arturo
 * Date: 23/05/2014
 * Time: 11:06 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace proyect_ing
{
	partial class FormNuevoProducto
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
			this.labelNombre = new System.Windows.Forms.Label();
			this.textNombre = new System.Windows.Forms.TextBox();
			this.labelTipo = new System.Windows.Forms.Label();
			this.textTipo = new System.Windows.Forms.TextBox();
			this.labelprecio = new System.Windows.Forms.Label();
			this.textPrecio = new System.Windows.Forms.TextBox();
			this.labelStock = new System.Windows.Forms.Label();
			this.textStock = new System.Windows.Forms.TextBox();
			this.buttonGuardar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelNombre
			// 
			this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNombre.Location = new System.Drawing.Point(65, 13);
			this.labelNombre.Name = "labelNombre";
			this.labelNombre.Size = new System.Drawing.Size(100, 23);
			this.labelNombre.TabIndex = 0;
			this.labelNombre.Text = "Nombre";
			// 
			// textNombre
			// 
			this.textNombre.Location = new System.Drawing.Point(65, 40);
			this.textNombre.Name = "textNombre";
			this.textNombre.Size = new System.Drawing.Size(137, 20);
			this.textNombre.TabIndex = 1;
			// 
			// labelTipo
			// 
			this.labelTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTipo.Location = new System.Drawing.Point(65, 67);
			this.labelTipo.Name = "labelTipo";
			this.labelTipo.Size = new System.Drawing.Size(100, 23);
			this.labelTipo.TabIndex = 2;
			this.labelTipo.Text = "Tipo";
			// 
			// textTipo
			// 
			this.textTipo.Location = new System.Drawing.Point(65, 93);
			this.textTipo.Name = "textTipo";
			this.textTipo.Size = new System.Drawing.Size(137, 20);
			this.textTipo.TabIndex = 3;
			// 
			// labelprecio
			// 
			this.labelprecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelprecio.Location = new System.Drawing.Point(65, 120);
			this.labelprecio.Name = "labelprecio";
			this.labelprecio.Size = new System.Drawing.Size(100, 23);
			this.labelprecio.TabIndex = 4;
			this.labelprecio.Text = "Precio Unitario";
			// 
			// textPrecio
			// 
			this.textPrecio.Location = new System.Drawing.Point(65, 147);
			this.textPrecio.Name = "textPrecio";
			this.textPrecio.Size = new System.Drawing.Size(137, 20);
			this.textPrecio.TabIndex = 5;
			// 
			// labelStock
			// 
			this.labelStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelStock.Location = new System.Drawing.Point(65, 186);
			this.labelStock.Name = "labelStock";
			this.labelStock.Size = new System.Drawing.Size(100, 23);
			this.labelStock.TabIndex = 6;
			this.labelStock.Text = "Stock";
			// 
			// textStock
			// 
			this.textStock.Location = new System.Drawing.Point(65, 213);
			this.textStock.Name = "textStock";
			this.textStock.Size = new System.Drawing.Size(137, 20);
			this.textStock.TabIndex = 7;
			// 
			// buttonGuardar
			// 
			this.buttonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonGuardar.Location = new System.Drawing.Point(96, 277);
			this.buttonGuardar.Name = "buttonGuardar";
			this.buttonGuardar.Size = new System.Drawing.Size(82, 40);
			this.buttonGuardar.TabIndex = 8;
			this.buttonGuardar.Text = "GUARDAR";
			this.buttonGuardar.UseVisualStyleBackColor = true;
			this.buttonGuardar.Click += new System.EventHandler(this.ButtonGuardarClick);
			// 
			// FormNuevoProducto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(314, 329);
			this.Controls.Add(this.buttonGuardar);
			this.Controls.Add(this.textStock);
			this.Controls.Add(this.labelStock);
			this.Controls.Add(this.textPrecio);
			this.Controls.Add(this.labelprecio);
			this.Controls.Add(this.textTipo);
			this.Controls.Add(this.labelTipo);
			this.Controls.Add(this.textNombre);
			this.Controls.Add(this.labelNombre);
			this.Name = "FormNuevoProducto";
			this.Text = "FormNuevoProducto";
			this.Load += new System.EventHandler(this.FormNuevoProductoLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button buttonGuardar;
		private System.Windows.Forms.TextBox textStock;
		private System.Windows.Forms.Label labelStock;
		private System.Windows.Forms.TextBox textPrecio;
		private System.Windows.Forms.Label labelprecio;
		private System.Windows.Forms.TextBox textTipo;
		private System.Windows.Forms.Label labelTipo;
		private System.Windows.Forms.TextBox textNombre;
		private System.Windows.Forms.Label labelNombre;
	}
}
