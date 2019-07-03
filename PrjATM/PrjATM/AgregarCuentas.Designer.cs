namespace PrjATM
{
	partial class AgregarCuentas
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.txtDocumentoCliente = new System.Windows.Forms.TextBox();
			this.lblNombreCliente = new System.Windows.Forms.Label();
			this.txtNombreCliente = new System.Windows.Forms.TextBox();
			this.lblApellidoCliente = new System.Windows.Forms.Label();
			this.txtApellidoCliente = new System.Windows.Forms.TextBox();
			this.lblNumeroTarjeta = new System.Windows.Forms.Label();
			this.txtNumeroTarjeta = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Denominacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CantidadBilletes = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblNumeroCuenta = new System.Windows.Forms.Label();
			this.txtNumeroCuenta = new System.Windows.Forms.TextBox();
			this.txtPinTarjeta = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.rbtnCuentaAhorros = new System.Windows.Forms.RadioButton();
			this.rbtnCuentaCorriente = new System.Windows.Forms.RadioButton();
			this.lblConfirmePin = new System.Windows.Forms.Label();
			this.txtConfirmaPin = new System.Windows.Forms.TextBox();
			this.btnRegistrarCuenta = new System.Windows.Forms.Button();
			this.btnLimpiarRegistroCuenta = new System.Windows.Forms.Button();
			this.btnRegresarCuenta = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Cédula ",
            "RUC",
            "Pasaporte"});
			this.comboBox1.Location = new System.Drawing.Point(12, 35);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 24);
			this.comboBox1.TabIndex = 0;
			this.comboBox1.Text = "Documento";
			// 
			// txtDocumentoCliente
			// 
			this.txtDocumentoCliente.Location = new System.Drawing.Point(149, 37);
			this.txtDocumentoCliente.Name = "txtDocumentoCliente";
			this.txtDocumentoCliente.Size = new System.Drawing.Size(156, 22);
			this.txtDocumentoCliente.TabIndex = 1;
			this.txtDocumentoCliente.TextChanged += new System.EventHandler(this.TxtDocumentoCliente_TextChanged);
			// 
			// lblNombreCliente
			// 
			this.lblNombreCliente.AutoSize = true;
			this.lblNombreCliente.Location = new System.Drawing.Point(11, 73);
			this.lblNombreCliente.Name = "lblNombreCliente";
			this.lblNombreCliente.Size = new System.Drawing.Size(62, 17);
			this.lblNombreCliente.TabIndex = 2;
			this.lblNombreCliente.Text = "Nombre:";
			// 
			// txtNombreCliente
			// 
			this.txtNombreCliente.Location = new System.Drawing.Point(149, 73);
			this.txtNombreCliente.Name = "txtNombreCliente";
			this.txtNombreCliente.Size = new System.Drawing.Size(156, 22);
			this.txtNombreCliente.TabIndex = 3;
			// 
			// lblApellidoCliente
			// 
			this.lblApellidoCliente.AutoSize = true;
			this.lblApellidoCliente.Location = new System.Drawing.Point(11, 108);
			this.lblApellidoCliente.Name = "lblApellidoCliente";
			this.lblApellidoCliente.Size = new System.Drawing.Size(62, 17);
			this.lblApellidoCliente.TabIndex = 4;
			this.lblApellidoCliente.Text = "Apellido:";
			// 
			// txtApellidoCliente
			// 
			this.txtApellidoCliente.Location = new System.Drawing.Point(149, 108);
			this.txtApellidoCliente.Name = "txtApellidoCliente";
			this.txtApellidoCliente.Size = new System.Drawing.Size(156, 22);
			this.txtApellidoCliente.TabIndex = 5;
			// 
			// lblNumeroTarjeta
			// 
			this.lblNumeroTarjeta.AutoSize = true;
			this.lblNumeroTarjeta.Location = new System.Drawing.Point(9, 156);
			this.lblNumeroTarjeta.Name = "lblNumeroTarjeta";
			this.lblNumeroTarjeta.Size = new System.Drawing.Size(127, 17);
			this.lblNumeroTarjeta.TabIndex = 6;
			this.lblNumeroTarjeta.Text = "Numero de Tarjeta";
			// 
			// txtNumeroTarjeta
			// 
			this.txtNumeroTarjeta.Location = new System.Drawing.Point(149, 151);
			this.txtNumeroTarjeta.Name = "txtNumeroTarjeta";
			this.txtNumeroTarjeta.Size = new System.Drawing.Size(156, 22);
			this.txtNumeroTarjeta.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(371, 37);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 17);
			this.label3.TabIndex = 8;
			this.label3.Text = "Saldo Inicial";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Denominacion,
            this.CantidadBilletes});
			this.dataGridView1.Location = new System.Drawing.Point(460, 35);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(294, 174);
			this.dataGridView1.TabIndex = 9;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
			// 
			// Denominacion
			// 
			this.Denominacion.HeaderText = "Denominacion";
			this.Denominacion.MinimumWidth = 6;
			this.Denominacion.Name = "Denominacion";
			this.Denominacion.ReadOnly = true;
			this.Denominacion.Width = 125;
			// 
			// CantidadBilletes
			// 
			this.CantidadBilletes.HeaderText = "Cantidad Billetes";
			this.CantidadBilletes.MinimumWidth = 6;
			this.CantidadBilletes.Name = "CantidadBilletes";
			this.CantidadBilletes.ReadOnly = true;
			this.CantidadBilletes.Width = 125;
			// 
			// lblNumeroCuenta
			// 
			this.lblNumeroCuenta.AutoSize = true;
			this.lblNumeroCuenta.Location = new System.Drawing.Point(9, 192);
			this.lblNumeroCuenta.Name = "lblNumeroCuenta";
			this.lblNumeroCuenta.Size = new System.Drawing.Size(127, 17);
			this.lblNumeroCuenta.TabIndex = 10;
			this.lblNumeroCuenta.Text = "Numero de Cuenta";
			// 
			// txtNumeroCuenta
			// 
			this.txtNumeroCuenta.Location = new System.Drawing.Point(149, 192);
			this.txtNumeroCuenta.Name = "txtNumeroCuenta";
			this.txtNumeroCuenta.Size = new System.Drawing.Size(156, 22);
			this.txtNumeroCuenta.TabIndex = 11;
			// 
			// txtPinTarjeta
			// 
			this.txtPinTarjeta.Location = new System.Drawing.Point(149, 232);
			this.txtPinTarjeta.Name = "txtPinTarjeta";
			this.txtPinTarjeta.Size = new System.Drawing.Size(156, 22);
			this.txtPinTarjeta.TabIndex = 12;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(9, 237);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(79, 17);
			this.label5.TabIndex = 13;
			this.label5.Text = "PIN Tarjeta";
			// 
			// rbtnCuentaAhorros
			// 
			this.rbtnCuentaAhorros.AutoSize = true;
			this.rbtnCuentaAhorros.Location = new System.Drawing.Point(14, 323);
			this.rbtnCuentaAhorros.Name = "rbtnCuentaAhorros";
			this.rbtnCuentaAhorros.Size = new System.Drawing.Size(128, 21);
			this.rbtnCuentaAhorros.TabIndex = 14;
			this.rbtnCuentaAhorros.TabStop = true;
			this.rbtnCuentaAhorros.Text = "Cuenta Ahorros";
			this.rbtnCuentaAhorros.UseVisualStyleBackColor = true;
			// 
			// rbtnCuentaCorriente
			// 
			this.rbtnCuentaCorriente.AutoSize = true;
			this.rbtnCuentaCorriente.Location = new System.Drawing.Point(149, 323);
			this.rbtnCuentaCorriente.Name = "rbtnCuentaCorriente";
			this.rbtnCuentaCorriente.Size = new System.Drawing.Size(136, 21);
			this.rbtnCuentaCorriente.TabIndex = 15;
			this.rbtnCuentaCorriente.TabStop = true;
			this.rbtnCuentaCorriente.Text = "Cuenta Corriente";
			this.rbtnCuentaCorriente.UseVisualStyleBackColor = true;
			// 
			// lblConfirmePin
			// 
			this.lblConfirmePin.AutoSize = true;
			this.lblConfirmePin.Location = new System.Drawing.Point(9, 269);
			this.lblConfirmePin.Name = "lblConfirmePin";
			this.lblConfirmePin.Size = new System.Drawing.Size(90, 17);
			this.lblConfirmePin.TabIndex = 16;
			this.lblConfirmePin.Text = "Confirme PIN";
			// 
			// txtConfirmaPin
			// 
			this.txtConfirmaPin.Location = new System.Drawing.Point(149, 269);
			this.txtConfirmaPin.Name = "txtConfirmaPin";
			this.txtConfirmaPin.Size = new System.Drawing.Size(156, 22);
			this.txtConfirmaPin.TabIndex = 17;
			// 
			// btnRegistrarCuenta
			// 
			this.btnRegistrarCuenta.Location = new System.Drawing.Point(621, 227);
			this.btnRegistrarCuenta.Name = "btnRegistrarCuenta";
			this.btnRegistrarCuenta.Size = new System.Drawing.Size(133, 27);
			this.btnRegistrarCuenta.TabIndex = 18;
			this.btnRegistrarCuenta.Text = "Registrar Cuenta";
			this.btnRegistrarCuenta.UseVisualStyleBackColor = true;
			// 
			// btnLimpiarRegistroCuenta
			// 
			this.btnLimpiarRegistroCuenta.Location = new System.Drawing.Point(621, 261);
			this.btnLimpiarRegistroCuenta.Name = "btnLimpiarRegistroCuenta";
			this.btnLimpiarRegistroCuenta.Size = new System.Drawing.Size(133, 27);
			this.btnLimpiarRegistroCuenta.TabIndex = 19;
			this.btnLimpiarRegistroCuenta.Text = "Limpiar Pantalla";
			this.btnLimpiarRegistroCuenta.UseVisualStyleBackColor = true;
			// 
			// btnRegresarCuenta
			// 
			this.btnRegresarCuenta.Location = new System.Drawing.Point(621, 308);
			this.btnRegresarCuenta.Name = "btnRegresarCuenta";
			this.btnRegresarCuenta.Size = new System.Drawing.Size(133, 27);
			this.btnRegresarCuenta.TabIndex = 20;
			this.btnRegresarCuenta.Text = "Regresar";
			this.btnRegresarCuenta.UseVisualStyleBackColor = true;
			// 
			// AgregarCuentas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnRegresarCuenta);
			this.Controls.Add(this.btnLimpiarRegistroCuenta);
			this.Controls.Add(this.btnRegistrarCuenta);
			this.Controls.Add(this.txtConfirmaPin);
			this.Controls.Add(this.lblConfirmePin);
			this.Controls.Add(this.rbtnCuentaCorriente);
			this.Controls.Add(this.rbtnCuentaAhorros);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtPinTarjeta);
			this.Controls.Add(this.txtNumeroCuenta);
			this.Controls.Add(this.lblNumeroCuenta);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtNumeroTarjeta);
			this.Controls.Add(this.lblNumeroTarjeta);
			this.Controls.Add(this.txtApellidoCliente);
			this.Controls.Add(this.lblApellidoCliente);
			this.Controls.Add(this.txtNombreCliente);
			this.Controls.Add(this.lblNombreCliente);
			this.Controls.Add(this.txtDocumentoCliente);
			this.Controls.Add(this.comboBox1);
			this.Name = "AgregarCuentas";
			this.Text = "AgregarCuentas";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox txtDocumentoCliente;
		private System.Windows.Forms.Label lblNombreCliente;
		private System.Windows.Forms.TextBox txtNombreCliente;
		private System.Windows.Forms.Label lblApellidoCliente;
		private System.Windows.Forms.TextBox txtApellidoCliente;
		private System.Windows.Forms.Label lblNumeroTarjeta;
		private System.Windows.Forms.TextBox txtNumeroTarjeta;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Denominacion;
		private System.Windows.Forms.DataGridViewTextBoxColumn CantidadBilletes;
		private System.Windows.Forms.Label lblNumeroCuenta;
		private System.Windows.Forms.TextBox txtNumeroCuenta;
		private System.Windows.Forms.TextBox txtPinTarjeta;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.RadioButton rbtnCuentaAhorros;
		private System.Windows.Forms.RadioButton rbtnCuentaCorriente;
		private System.Windows.Forms.Label lblConfirmePin;
		private System.Windows.Forms.TextBox txtConfirmaPin;
		private System.Windows.Forms.Button btnRegistrarCuenta;
		private System.Windows.Forms.Button btnLimpiarRegistroCuenta;
		private System.Windows.Forms.Button btnRegresarCuenta;
	}
}