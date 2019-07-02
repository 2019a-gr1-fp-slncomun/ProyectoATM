using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinqToExcel;
using System.IO;
using System.Data.OleDb;
namespace PrjATM
{
    public partial class IngresoAdministradorNuevo : Form
    {
        public IngresoAdministradorNuevo()
        {
            InitializeComponent();
        }







        private void IngresoAdministradorNuevo_Load(object sender, EventArgs e)
        {
            dgvUsuarioyContrase.DataSource = new Usuarios().LecturaAdministradores();
            dgvUsuarioyContrase.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void BtnLeerDatos_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = string.Empty;
                string clave = string.Empty;
                DataTable dtAdministrador = new DataTable();
                dtAdministrador.Columns.Add("Usuario", typeof(string), null);
                dtAdministrador.Columns.Add("contraseña", typeof(string), null);
                for (int i = 0; i < dgvUsuarioyContrase.RowCount; i++)
                {
                    if (dgvUsuarioyContrase.Rows[i].Cells[0].Value != null)
                    {
                        usuario = dgvUsuarioyContrase.Rows[i].Cells[0].Value.ToString();
                    }
                    if (dgvUsuarioyContrase.Rows[i].Cells[1].Value != null)
                    {
                        clave = dgvUsuarioyContrase.Rows[i].Cells[1].Value.ToString();
                    }
                    if (usuario != string.Empty && clave != string.Empty)
                    {
                        dtAdministrador.Rows.Add(new Object[] { usuario, clave });
                        usuario = string.Empty;
                        clave = string.Empty;
                    }
                }
                new Usuarios().GuardarAdministradores(dtAdministrador);
                MessageBox.Show("el nuevo Usuario a sido agregado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo grabar la información\n" + ex.ToString());
            }
        }
    }
}
