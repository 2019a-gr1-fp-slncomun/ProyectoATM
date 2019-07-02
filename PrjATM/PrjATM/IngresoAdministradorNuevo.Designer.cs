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
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarioyContrase)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuarioyContrase
            // 
            this.dgvUsuarioyContrase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarioyContrase.Location = new System.Drawing.Point(414, 12);
            this.dgvUsuarioyContrase.Name = "dgvUsuarioyContrase";
            this.dgvUsuarioyContrase.Size = new System.Drawing.Size(374, 202);
            this.dgvUsuarioyContrase.TabIndex = 0;
            // 
            // btnGuardarAdministrador
            // 
            this.btnGuardarAdministrador.Location = new System.Drawing.Point(65, 262);
            this.btnGuardarAdministrador.Name = "btnGuardarAdministrador";
            this.btnGuardarAdministrador.Size = new System.Drawing.Size(181, 23);
            this.btnGuardarAdministrador.TabIndex = 1;
            this.btnGuardarAdministrador.Text = "Guardar Nuevo Adminsitrador";
            this.btnGuardarAdministrador.UseVisualStyleBackColor = true;
            this.btnGuardarAdministrador.Click += new System.EventHandler(this.BtnLeerDatos_Click);
            // 
            // IngresoAdministradorNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.btnGuardarAdministrador);
            this.Controls.Add(this.dgvUsuarioyContrase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IngresoAdministradorNuevo";
            this.Text = "IngresoAdministradorNuevo";
            this.Load += new System.EventHandler(this.IngresoAdministradorNuevo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarioyContrase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dgvUsuarioyContrase;
        public System.Windows.Forms.Button btnGuardarAdministrador;
    }
}