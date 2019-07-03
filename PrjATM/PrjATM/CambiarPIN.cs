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
    public partial class CambiarPIN : Form
    {
        public CambiarPIN()
        {
            InitializeComponent();
        }

        private void BtnSalir1_Click(object sender, EventArgs e)
        {
            // creamos la instancia del retiro
            Form1 obj = new Form1();
            //Llamamos el objeto de el form2 y lo ponemos visible
            obj.Visible = true;
            //ocultamos el formulario 1
            Visible = false;
        }
    }
}
