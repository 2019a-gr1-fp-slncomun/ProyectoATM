namespace PrjATM
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.txtContraseña = new System.Windows.Forms.TextBox();
			this.btnEntrar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.btnCleanText = new System.Windows.Forms.Button();
			this.txtPIN = new System.Windows.Forms.TextBox();
			this.txtCedula = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
			this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
			this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
			this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
			this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtUsuario
			// 
			this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtUsuario.Enabled = false;
			this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsuario.ForeColor = System.Drawing.Color.DimGray;
			this.txtUsuario.Location = new System.Drawing.Point(449, 107);
			this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(483, 20);
			this.txtUsuario.TabIndex = 2;
			this.txtUsuario.Text = "USUARIO";
			this.txtUsuario.TextChanged += new System.EventHandler(this.TxtUsuario_TextChanged);
			this.txtUsuario.Enter += new System.EventHandler(this.TxtUsuario_Enter);
			this.txtUsuario.Leave += new System.EventHandler(this.TxtUsuario_Leave);
			// 
			// txtContraseña
			// 
			this.txtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtContraseña.Enabled = false;
			this.txtContraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtContraseña.ForeColor = System.Drawing.Color.DimGray;
			this.txtContraseña.Location = new System.Drawing.Point(445, 167);
			this.txtContraseña.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtContraseña.Name = "txtContraseña";
			this.txtContraseña.Size = new System.Drawing.Size(483, 20);
			this.txtContraseña.TabIndex = 3;
			this.txtContraseña.Text = "CONTRASEÑA";
			this.txtContraseña.TextChanged += new System.EventHandler(this.TxtContraseña_TextChanged);
			this.txtContraseña.Enter += new System.EventHandler(this.TxtContraseña_Enter);
			this.txtContraseña.Leave += new System.EventHandler(this.TxtContraseña_Leave);
			// 
			// btnEntrar
			// 
			this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.btnEntrar.FlatAppearance.BorderSize = 0;
			this.btnEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.btnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEntrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEntrar.ForeColor = System.Drawing.Color.LightGray;
			this.btnEntrar.Location = new System.Drawing.Point(453, 350);
			this.btnEntrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnEntrar.Name = "btnEntrar";
			this.btnEntrar.Size = new System.Drawing.Size(155, 28);
			this.btnEntrar.TabIndex = 5;
			this.btnEntrar.Text = "Entrar";
			this.btnEntrar.UseVisualStyleBackColor = false;
			this.btnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(657, 11);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(137, 21);
			this.label1.TabIndex = 6;
			this.label1.Text = "Tipo de Usuario";
			// 
			// comboBox1
			// 
			this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.ForeColor = System.Drawing.Color.DimGray;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Administrador",
            "Cliente"});
			this.comboBox1.Location = new System.Drawing.Point(661, 36);
			this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.comboBox1.Size = new System.Drawing.Size(160, 24);
			this.comboBox1.TabIndex = 7;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
			// 
			// btnCleanText
			// 
			this.btnCleanText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.btnCleanText.FlatAppearance.BorderSize = 0;
			this.btnCleanText.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.btnCleanText.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnCleanText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCleanText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCleanText.ForeColor = System.Drawing.Color.LightGray;
			this.btnCleanText.Location = new System.Drawing.Point(763, 350);
			this.btnCleanText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnCleanText.Name = "btnCleanText";
			this.btnCleanText.Size = new System.Drawing.Size(172, 28);
			this.btnCleanText.TabIndex = 8;
			this.btnCleanText.Text = "Limpiar Pantalla";
			this.btnCleanText.UseVisualStyleBackColor = false;
			this.btnCleanText.Click += new System.EventHandler(this.BtnCleanText_Click);
			// 
			// txtPIN
			// 
			this.txtPIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.txtPIN.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPIN.Enabled = false;
			this.txtPIN.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPIN.ForeColor = System.Drawing.Color.DimGray;
			this.txtPIN.Location = new System.Drawing.Point(453, 295);
			this.txtPIN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtPIN.Name = "txtPIN";
			this.txtPIN.Size = new System.Drawing.Size(480, 20);
			this.txtPIN.TabIndex = 12;
			this.txtPIN.Text = "PIN DE TARJETA";
			this.txtPIN.Enter += new System.EventHandler(this.TxtPIN_Enter);
			this.txtPIN.Leave += new System.EventHandler(this.TxtPIN_Leave);
			// 
			// txtCedula
			// 
			this.txtCedula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtCedula.Enabled = false;
			this.txtCedula.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCedula.ForeColor = System.Drawing.Color.DimGray;
			this.txtCedula.Location = new System.Drawing.Point(452, 230);
			this.txtCedula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtCedula.Name = "txtCedula";
			this.txtCedula.Size = new System.Drawing.Size(481, 20);
			this.txtCedula.TabIndex = 11;
			this.txtCedula.Text = "CEDULA";
			this.txtCedula.Enter += new System.EventHandler(this.TxtCedula_Enter);
			this.txtCedula.Leave += new System.EventHandler(this.TxtCedula_Leave);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(333, 406);
			this.panel1.TabIndex = 13;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(44, 60);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(233, 251);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 0;
			this.pictureBox2.TabStop = false;
			// 
			// shapeContainer1
			// 
			this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
			this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
			this.shapeContainer1.Name = "shapeContainer1";
			this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
			this.shapeContainer1.Size = new System.Drawing.Size(1040, 406);
			this.shapeContainer1.TabIndex = 14;
			this.shapeContainer1.TabStop = false;
			// 
			// lineShape4
			// 
			this.lineShape4.BorderColor = System.Drawing.Color.DimGray;
			this.lineShape4.Name = "lineShape4";
			this.lineShape4.X1 = 341;
			this.lineShape4.X2 = 702;
			this.lineShape4.Y1 = 261;
			this.lineShape4.Y2 = 261;
			// 
			// lineShape3
			// 
			this.lineShape3.BorderColor = System.Drawing.Color.DimGray;
			this.lineShape3.Name = "lineShape3";
			this.lineShape3.X1 = 340;
			this.lineShape3.X2 = 701;
			this.lineShape3.Y1 = 208;
			this.lineShape3.Y2 = 208;
			// 
			// lineShape2
			// 
			this.lineShape2.BorderColor = System.Drawing.Color.DimGray;
			this.lineShape2.Name = "lineShape2";
			this.lineShape2.X1 = 334;
			this.lineShape2.X2 = 695;
			this.lineShape2.Y1 = 159;
			this.lineShape2.Y2 = 159;
			// 
			// lineShape1
			// 
			this.lineShape1.BorderColor = System.Drawing.Color.DimGray;
			this.lineShape1.Name = "lineShape1";
			this.lineShape1.X1 = 337;
			this.lineShape1.X2 = 698;
			this.lineShape1.Y1 = 112;
			this.lineShape1.Y2 = 112;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(1004, 14);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(20, 18);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 15;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.ClientSize = new System.Drawing.Size(1040, 406);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.txtPIN);
			this.Controls.Add(this.txtCedula);
			this.Controls.Add(this.btnCleanText);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnEntrar);
			this.Controls.Add(this.txtContraseña);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.shapeContainer1);
			this.ForeColor = System.Drawing.Color.DimGray;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Opacity = 0.9D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnCleanText;
        private System.Windows.Forms.TextBox txtPIN;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

