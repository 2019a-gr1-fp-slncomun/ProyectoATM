namespace PrjATM
{
    partial class IngresoAdministradorNuevo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.dgvUsuarioyContrase = new System.Windows.Forms.DataGridView();
			this.btnGuardarAdministrador = new System.Windows.Forms.Button();
			this.btnAgregarCuenta = new System.Windows.Forms.Button();
			this.btnMovimientosClientes = new System.Windows.Forms.Button();
			this.btnSaldoCajero = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvUsuarioyContrase)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvUsuarioyContrase
			// 
			this.dgvUsuarioyContrase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUsuarioyContrase.Location = new System.Drawing.Point(293, 33);
			this.dgvUsuarioyContrase.Margin = new System.Windows.Forms.Padding(4);
			this.dgvUsuarioyContrase.Name = "dgvUsuarioyContrase";
			this.dgvUsuarioyContrase.RowHeadersWidth = 51;
			this.dgvUsuarioyContrase.Size = new System.Drawing.Size(499, 249);
			this.dgvUsuarioyContrase.TabIndex = 0;
			// 
			// btnGuardarAdministrador
			// 
			this.btnGuardarAdministrador.Location = new System.Drawing.Point(13, 33);
			this.btnGuardarAdministrador.Margin = new System.Windows.Forms.Padding(4);
			this.btnGuardarAdministrador.Name = "btnGuardarAdministrador";
			this.btnGuardarAdministrador.Size = new System.Drawing.Size(241, 28);
			this.btnGuardarAdministrador.TabIndex = 1;
			this.btnGuardarAdministrador.Text = "Guardar Nuevo Adminsitrador";
			this.btnGuardarAdministrador.UseVisualStyleBackColor = true;
			this.btnGuardarAdministrador.Click += new System.EventHandler(this.BtnLeerDatos_Click);
			// 
			// btnAgregarCuenta
			// 
			this.btnAgregarCuenta.Location = new System.Drawing.Point(13, 385);
			this.btnAgregarCuenta.Name = "btnAgregarCuenta";
			this.btnAgregarCuenta.Size = new System.Drawing.Size(224, 28);
			this.btnAgregarCuenta.TabIndex = 2;
			this.btnAgregarCuenta.Text = "Agregar Cuenta ";
			this.btnAgregarCuenta.UseVisualStyleBackColor = true;
			this.btnAgregarCuenta.Click += new System.EventHandler(this.BtnAgregarCuenta_Click);
			// 
			// btnMovimientosClientes
			// 
			this.btnMovimientosClientes.Location = new System.Drawing.Point(279, 385);
			this.btnMovimientosClientes.Name = "btnMovimientosClientes";
			this.btnMovimientosClientes.Size = new System.Drawing.Size(209, 28);
			this.btnMovimientosClientes.TabIndex = 3;
			this.btnMovimientosClientes.Text = "Movimientos Clientes";
			this.btnMovimientosClientes.UseVisualStyleBackColor = true;
			// 
			// btnSaldoCajero
			// 
			this.btnSaldoCajero.Location = new System.Drawing.Point(515, 385);
			this.btnSaldoCajero.Name = "btnSaldoCajero";
			this.btnSaldoCajero.Size = new System.Drawing.Size(188, 28);
			this.btnSaldoCajero.TabIndex = 4;
			this.btnSaldoCajero.Text = "Saldo del Cajero";
			this.btnSaldoCajero.UseVisualStyleBackColor = true;
			// 
			// IngresoAdministradorNuevo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1333, 615);
			this.Controls.Add(this.btnSaldoCajero);
			this.Controls.Add(this.btnMovimientosClientes);
			this.Controls.Add(this.btnAgregarCuenta);
			this.Controls.Add(this.btnGuardarAdministrador);
			this.Controls.Add(this.dgvUsuarioyContrase);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "IngresoAdministradorNuevo";
			this.Text = "IngresoAdministradorNuevo";
			this.Load += new System.EventHandler(this.IngresoAdministradorNuevo_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvUsuarioyContrase)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dgvUsuarioyContrase;
        public System.Windows.Forms.Button btnGuardarAdministrador;
		private System.Windows.Forms.Button btnAgregarCuenta;
		private System.Windows.Forms.Button btnMovimientosClientes;
		private System.Windows.Forms.Button btnSaldoCajero;
	}
}