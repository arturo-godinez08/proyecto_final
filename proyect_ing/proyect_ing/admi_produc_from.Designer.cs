/*
 * Created by SharpDevelop.
 * User: Arturo
 * Date: 24/05/2014
 * Time: 12:36 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace proyect_ing
{
	partial class admi_produc_from
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
			this.buttonEliminar = new System.Windows.Forms.Button();
			this.buttonEditar = new System.Windows.Forms.Button();
			this.buttonAgregar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridViewADM_Pro = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewADM_Pro)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonEliminar
			// 
			this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonEliminar.Location = new System.Drawing.Point(560, 358);
			this.buttonEliminar.Name = "buttonEliminar";
			this.buttonEliminar.Size = new System.Drawing.Size(75, 35);
			this.buttonEliminar.TabIndex = 10;
			this.buttonEliminar.Text = "ELIMINAR";
			this.buttonEliminar.UseVisualStyleBackColor = true;
			this.buttonEliminar.Click += new System.EventHandler(this.ButtonEliminarClick);
			// 
			// buttonEditar
			// 
			this.buttonEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonEditar.Location = new System.Drawing.Point(362, 358);
			this.buttonEditar.Name = "buttonEditar";
			this.buttonEditar.Size = new System.Drawing.Size(75, 35);
			this.buttonEditar.TabIndex = 9;
			this.buttonEditar.Text = "EDITAR";
			this.buttonEditar.UseVisualStyleBackColor = true;
			this.buttonEditar.Click += new System.EventHandler(this.ButtonEditarClick);
			// 
			// buttonAgregar
			// 
			this.buttonAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAgregar.Location = new System.Drawing.Point(153, 358);
			this.buttonAgregar.Name = "buttonAgregar";
			this.buttonAgregar.Size = new System.Drawing.Size(75, 32);
			this.buttonAgregar.TabIndex = 8;
			this.buttonAgregar.Text = "AGREGAR";
			this.buttonAgregar.UseVisualStyleBackColor = true;
			this.buttonAgregar.Click += new System.EventHandler(this.ButtonAgregarClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(250, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(279, 24);
			this.label1.TabIndex = 7;
			this.label1.Text = "ADMINISTRAR PRODUCTOS";
			// 
			// dataGridViewADM_Pro
			// 
			this.dataGridViewADM_Pro.AllowUserToAddRows = false;
			this.dataGridViewADM_Pro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewADM_Pro.Location = new System.Drawing.Point(116, 58);
			this.dataGridViewADM_Pro.MultiSelect = false;
			this.dataGridViewADM_Pro.Name = "dataGridViewADM_Pro";
			this.dataGridViewADM_Pro.ReadOnly = true;
			this.dataGridViewADM_Pro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewADM_Pro.Size = new System.Drawing.Size(544, 273);
			this.dataGridViewADM_Pro.TabIndex = 6;
			this.dataGridViewADM_Pro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewADM_ProCellContentClick);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 97);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 11;
			this.button1.Text = "Actualizar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// admi_produc_from
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(836, 402);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.buttonEliminar);
			this.Controls.Add(this.buttonEditar);
			this.Controls.Add(this.buttonAgregar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridViewADM_Pro);
			this.Name = "admi_produc_from";
			this.Text = "admi_produc_from";
			this.Load += new System.EventHandler(this.Admi_produc_fromLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewADM_Pro)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView dataGridViewADM_Pro;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonAgregar;
		private System.Windows.Forms.Button buttonEditar;
		private System.Windows.Forms.Button buttonEliminar;
	}
}
