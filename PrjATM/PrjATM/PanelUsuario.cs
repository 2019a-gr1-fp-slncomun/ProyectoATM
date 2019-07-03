using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjATM
{
    public partial class PanelUsuario : Form
    {
        public PanelUsuario()
        {
            InitializeComponent();
        }

        private void BtnRetiro_Click(object sender, EventArgs e)
        {
            // creamos la instancia del retiro
            Retiro obj = new Retiro();
            //Llamamos el objeto de el form2 y lo ponemos visible
            obj.Visible = true;
            //ocultamos el formulario 1
            Visible = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            RetiroRapido obj = new RetiroRapido();
            obj.Visible = true;
            Visible = false;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            CambiarPIN obj = new CambiarPIN();
            obj.Visible = true;
            Visible = false;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Consulta obj = new Consulta();
            obj.Visible = true;
            Visible = false;
        }
    }
}
