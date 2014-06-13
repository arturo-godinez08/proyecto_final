/*
 * Created by SharpDevelop.
 * User: Arturo
 * Date: 17/05/2014
 * Time: 04:13 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace proyect_ing
{
	partial class FormInicio
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.administrarVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.verVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.registrarUnaVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.verProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.administrarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.iToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.administrarProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clasificacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.administrarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.agregarClientesNuevosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.verClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
			this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.archivoToolStripMenuItem,
									this.ventasToolStripMenuItem,
									this.productosToolStripMenuItem,
									this.proveedoresToolStripMenuItem,
									this.marcasToolStripMenuItem,
									this.clientesToolStripMenuItem,
									this.ayudaToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(773, 25);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// archivoToolStripMenuItem
			// 
			this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.cerrarSesionToolStripMenuItem,
									this.salirToolStripMenuItem});
			this.archivoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
			this.archivoToolStripMenuItem.Size = new System.Drawing.Size(66, 21);
			this.archivoToolStripMenuItem.Text = "Archivo";
			// 
			// cerrarSesionToolStripMenuItem
			// 
			this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
			this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.cerrarSesionToolStripMenuItem.Text = "Cerrar sesion";
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.salirToolStripMenuItem.Text = "Salir";
			// 
			// ventasToolStripMenuItem
			// 
			this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.administrarVentaToolStripMenuItem,
									this.verVentaToolStripMenuItem,
									this.registrarUnaVentaToolStripMenuItem});
			this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
			this.ventasToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
			this.ventasToolStripMenuItem.Text = "Ventas";
			// 
			// administrarVentaToolStripMenuItem
			// 
			this.administrarVentaToolStripMenuItem.Name = "administrarVentaToolStripMenuItem";
			this.administrarVentaToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
			this.administrarVentaToolStripMenuItem.Text = "Administrar venta";
			// 
			// verVentaToolStripMenuItem
			// 
			this.verVentaToolStripMenuItem.Name = "verVentaToolStripMenuItem";
			this.verVentaToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
			this.verVentaToolStripMenuItem.Text = "Ver venta";
			// 
			// registrarUnaVentaToolStripMenuItem
			// 
			this.registrarUnaVentaToolStripMenuItem.Name = "registrarUnaVentaToolStripMenuItem";
			this.registrarUnaVentaToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
			this.registrarUnaVentaToolStripMenuItem.Text = "Registrar una venta";
			// 
			// productosToolStripMenuItem
			// 
			this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.verProductosToolStripMenuItem,
									this.administrarProductosToolStripMenuItem,
									this.iToolStripMenuItem});
			this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
			this.productosToolStripMenuItem.Size = new System.Drawing.Size(82, 21);
			this.productosToolStripMenuItem.Text = "Productos";
			// 
			// verProductosToolStripMenuItem
			// 
			this.verProductosToolStripMenuItem.Name = "verProductosToolStripMenuItem";
			this.verProductosToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
			this.verProductosToolStripMenuItem.Text = "Ver Productos";
			this.verProductosToolStripMenuItem.Click += new System.EventHandler(this.VerProductosToolStripMenuItemClick);
			// 
			// administrarProductosToolStripMenuItem
			// 
			this.administrarProductosToolStripMenuItem.Name = "administrarProductosToolStripMenuItem";
			this.administrarProductosToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
			this.administrarProductosToolStripMenuItem.Text = "Administrar Productos";
			this.administrarProductosToolStripMenuItem.Click += new System.EventHandler(this.AdministrarProductosToolStripMenuItemClick);
			// 
			// iToolStripMenuItem
			// 
			this.iToolStripMenuItem.Name = "iToolStripMenuItem";
			this.iToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
			this.iToolStripMenuItem.Text = "ingreso de Productos";
			// 
			// proveedoresToolStripMenuItem
			// 
			this.proveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.administrarProveedoresToolStripMenuItem});
			this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
			this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(96, 21);
			this.proveedoresToolStripMenuItem.Text = "Proveedores";
			// 
			// administrarProveedoresToolStripMenuItem
			// 
			this.administrarProveedoresToolStripMenuItem.Name = "administrarProveedoresToolStripMenuItem";
			this.administrarProveedoresToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
			this.administrarProveedoresToolStripMenuItem.Text = "Administrar Proveedores";
			// 
			// marcasToolStripMenuItem
			// 
			this.marcasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.clasificacionToolStripMenuItem});
			this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
			this.marcasToolStripMenuItem.Size = new System.Drawing.Size(63, 21);
			this.marcasToolStripMenuItem.Text = "Marcas";
			// 
			// clasificacionToolStripMenuItem
			// 
			this.clasificacionToolStripMenuItem.Name = "clasificacionToolStripMenuItem";
			this.clasificacionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.clasificacionToolStripMenuItem.Text = "Clasificacion";
			// 
			// clientesToolStripMenuItem
			// 
			this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.administrarClientesToolStripMenuItem,
									this.agregarClientesNuevosToolStripMenuItem,
									this.verClientesToolStripMenuItem});
			this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
			this.clientesToolStripMenuItem.Size = new System.Drawing.Size(67, 21);
			this.clientesToolStripMenuItem.Text = "Clientes";
			// 
			// administrarClientesToolStripMenuItem
			// 
			this.administrarClientesToolStripMenuItem.Name = "administrarClientesToolStripMenuItem";
			this.administrarClientesToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
			this.administrarClientesToolStripMenuItem.Text = "Administrar clientes";
			// 
			// agregarClientesNuevosToolStripMenuItem
			// 
			this.agregarClientesNuevosToolStripMenuItem.Name = "agregarClientesNuevosToolStripMenuItem";
			this.agregarClientesNuevosToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
			this.agregarClientesNuevosToolStripMenuItem.Text = "Agregar clientes nuevos";
			// 
			// verClientesToolStripMenuItem
			// 
			this.verClientesToolStripMenuItem.Name = "verClientesToolStripMenuItem";
			this.verClientesToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
			this.verClientesToolStripMenuItem.Text = "Ver clientes";
			// 
			// ayudaToolStripMenuItem
			// 
			this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
			this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
			this.ayudaToolStripMenuItem.Text = "Ayuda";
			// 
			// FormInicio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(773, 370);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FormInicio";
			this.Text = "FormInicio";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem verClientesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem agregarClientesNuevosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem administrarClientesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clasificacionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem administrarProveedoresToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem iToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem administrarProductosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem verProductosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem registrarUnaVentaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem verVentaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem administrarVentaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem marcasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
