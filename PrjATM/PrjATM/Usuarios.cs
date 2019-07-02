using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using LinqToExcel;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PrjATM
{
    
    public class Usuarios
    {
       public string rutaArchivo = Application.StartupPath + @"\" + @"Archivos\Administradores.txt";
     

        public DataTable LecturaAdministradores()
        {
            string texto = string.Empty;
            DataTable dtAdministrador = new DataTable();
            dtAdministrador.Columns.Add("Usuario", typeof(string), null);
            dtAdministrador.Columns.Add("contraseña", typeof(string), null);
            using (FileStream filestream = new FileStream(rutaArchivo, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (StreamReader file = new StreamReader(filestream))
                {
                    while ((texto = file.ReadLine())!=null)
                    {
                        dtAdministrador.Rows.Add(texto.Split('-'));
                    }
                }
                
               
            }
            return dtAdministrador;

        }

        public void GuardarAdministradores(DataTable dtAdministrador )
        {
            string fila=string.Empty;
            using (FileStream fileStream = new FileStream(rutaArchivo, FileMode.Create, FileAccess.Write, FileShare.Write))
            {
                using(StreamWriter file = new StreamWriter(fileStream))
                {
                    for (int i =0; i<dtAdministrador.Rows.Count;i++)
                    {
                        fila = dtAdministrador.Rows[i][0].ToString() + "-" + dtAdministrador.Rows[i][1].ToString();
                        file.WriteLine((fila));
                    }
                }
            }
                
        }
        

            
               




            
           
            

    


        

    }


    
}
