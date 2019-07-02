using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using LinqToExcel;

namespace PrjATM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCleanText_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtContraseña.Clear();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string operador = comboBox1.Text;
            
            switch (operador)
            {
                case "Cliente":
                    
                    txtCedula.Enabled = true;
                    txtPIN.Enabled = true;
                    break;
                case "Administrador":
                    txtContraseña.Enabled = true;
                    txtUsuario.Enabled = true;
                   
                    break;
            }

        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {


            DataTable dtAdministrador = new Usuarios().LecturaAdministradores();
            bool banderaacceso = false;
          
            
            for(int i =0; i<dtAdministrador.Rows.Count; i++)
            {
                if (txtUsuario.Text == dtAdministrador.Rows[i][0].ToString() && txtContraseña.Text == dtAdministrador.Rows[i][1].ToString())
                {
                    banderaacceso = true;
                    break;
                }

            }
            if(banderaacceso == true)
            {
                this.Hide();
                FrmBienvenida bienvenido = new FrmBienvenida();
                bienvenido.ShowDialog();
                
                new IngresoAdministradorNuevo().Show();
            }
            else
            {
                MessageBox.Show("Usuario o clave no validos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void TxtUsuario_Enter(object sender, EventArgs e)
        {
            if(txtUsuario.Text=="USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            if(txtUsuario.Text=="")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void TxtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.LightGray;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void TxtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void TxtCedula_Enter(object sender, EventArgs e)
        {
            if (txtCedula.Text == "CEDULA")
            {
                txtCedula.Text = "";
                txtCedula.ForeColor = Color.LightGray;
            }
        }

        private void TxtCedula_Leave(object sender, EventArgs e)
        {
            if (txtCedula.Text == "")
            {
                txtCedula.Text = "CEDULA";
                txtCedula.ForeColor = Color.DimGray;
            }
        }

        private void TxtPIN_Enter(object sender, EventArgs e)
        {
            if (txtPIN.Text == "PIN DE TARJETA")
            {
                txtPIN.Text = "";
                txtPIN.ForeColor = Color.LightGray;
                txtPIN.UseSystemPasswordChar = true;
            }
        }

        private void TxtPIN_Leave(object sender, EventArgs e)
        {
            if (txtPIN.Text == "")
            {
                txtPIN.Text = "PIN DE TARJETA";
                txtPIN.ForeColor = Color.DimGray;
                txtPIN.UseSystemPasswordChar = false;
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

		private void TxtUsuario_TextChanged(object sender, EventArgs e)
		{

		}
	}

        /*private void Form1_Load(object sender, EventArgs e)
        {

        }*/
    
}

  