/*
 * Created by SharpDevelop.
 * User: Arturo
 * Date: 27/05/2014
 * Time: 09:56 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace proyect_ing
{
	partial class Editar_ProductoForm
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
			this.buttonGuardarEditado = new System.Windows.Forms.Button();
			this.textStockE = new System.Windows.Forms.TextBox();
			this.labelStock = new System.Windows.Forms.Label();
			this.textPrecioE = new System.Windows.Forms.TextBox();
			this.labelprecio = new System.Windows.Forms.Label();
			this.textTipoE = new System.Windows.Forms.TextBox();
			this.labelTipo = new System.Windows.Forms.Label();
			this.textNombreE = new System.Windows.Forms.TextBox();
			this.labelNombre = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonGuardarEditado
			// 
			this.buttonGuardarEditado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonGuardarEditado.Location = new System.Drawing.Point(118, 271);
			this.buttonGuardarEditado.Name = "buttonGuardarEditado";
			this.buttonGuardarEditado.Size = new System.Drawing.Size(82, 40);
			this.buttonGuardarEditado.TabIndex = 17;
			this.buttonGuardarEditado.Text = "GUARDAR";
			this.buttonGuardarEditado.UseVisualStyleBackColor = true;
			this.buttonGuardarEditado.Click += new System.EventHandler(this.ButtonGuardarEditadoClick);
			// 
			// textStockE
			// 
			this.textStockE.Location = new System.Drawing.Point(87, 207);
			this.textStockE.Name = "textStockE";
			this.textStockE.Size = new System.Drawing.Size(137, 20);
			this.textStockE.TabIndex = 16;
			// 
			// labelStock
			// 
			this.labelStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelStock.Location = new System.Drawing.Point(87, 180);
			this.labelStock.Name = "labelStock";
			this.labelStock.Size = new System.Drawing.Size(100, 23);
			this.labelStock.TabIndex = 15;
			this.labelStock.Text = "Stock";
			// 
			// textPrecioE
			// 
			this.textPrecioE.Location = new System.Drawing.Point(87, 141);
			this.textPrecioE.Name = "textPrecioE";
			this.textPrecioE.Size = new System.Drawing.Size(137, 20);
			this.textPrecioE.TabIndex = 14;
			// 
			// labelprecio
			// 
			this.labelprecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelprecio.Location = new System.Drawing.Point(87, 114);
			this.labelprecio.Name = "labelprecio";
			this.labelprecio.Size = new System.Drawing.Size(100, 23);
			this.labelprecio.TabIndex = 13;
			this.labelprecio.Text = "Precio Unitario";
			// 
			// textTipoE
			// 
			this.textTipoE.Location = new System.Drawing.Point(87, 87);
			this.textTipoE.Name = "textTipoE";
			this.textTipoE.Size = new System.Drawing.Size(137, 20);
			this.textTipoE.TabIndex = 12;
			// 
			// labelTipo
			// 
			this.labelTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTipo.Location = new System.Drawing.Point(87, 61);
			this.labelTipo.Name = "labelTipo";
			this.labelTipo.Size = new System.Drawing.Size(100, 23);
			this.labelTipo.TabIndex = 11;
			this.labelTipo.Text = "Tipo";
			// 
			// textNombreE
			// 
			this.textNombreE.Location = new System.Drawing.Point(87, 34);
			this.textNombreE.Name = "textNombreE";
			this.textNombreE.Size = new System.Drawing.Size(137, 20);
			this.textNombreE.TabIndex = 10;
			// 
			// labelNombre
			// 
			this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNombre.Location = new System.Drawing.Point(87, 7);
			this.labelNombre.Name = "labelNombre";
			this.labelNombre.Size = new System.Drawing.Size(100, 23);
			this.labelNombre.TabIndex = 9;
			this.labelNombre.Text = "Nombre";
			// 
			// Editar_ProductoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(310, 318);
			this.Controls.Add(this.buttonGuardarEditado);
			this.Controls.Add(this.textStockE);
			this.Controls.Add(this.labelStock);
			this.Controls.Add(this.textPrecioE);
			this.Controls.Add(this.labelprecio);
			this.Controls.Add(this.textTipoE);
			this.Controls.Add(this.labelTipo);
			this.Controls.Add(this.textNombreE);
			this.Controls.Add(this.labelNombre);
			this.Name = "Editar_ProductoForm";
			this.Text = "Editar_ProductoForm";
			this.Load += new System.EventHandler(this.Editar_ProductoFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label labelNombre;
		private System.Windows.Forms.TextBox textNombreE;
		private System.Windows.Forms.Label labelTipo;
		private System.Windows.Forms.TextBox textTipoE;
		private System.Windows.Forms.Label labelprecio;
		private System.Windows.Forms.TextBox textPrecioE;
		private System.Windows.Forms.Label labelStock;
		private System.Windows.Forms.TextBox textStockE;
		private System.Windows.Forms.Button buttonGuardarEditado;
	}
}
