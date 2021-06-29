using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;

namespace lab3_sanchez_pablo_sn
{
    class ConexionBD
    {
        public string conexion = @"Data Source=DESKTOP-0AEJ0VK\SQLEXPRESS;Initial Catalog=Lab3;Integrated Security=True";
        public SqlConnection conectarBD = new SqlConnection();

        public ConexionBD() { conectarBD.ConnectionString = conexion; }

        public void abrirBD()
        {
            try 
            {
                conectarBD.Open();
                //System.Windows.Forms.MessageBox.Show("Conexion Abierta!");
            }
            catch (Exception ex) 
            {
                System.Windows.Forms.MessageBox.Show("Error: "+ex.Message);
            }
        }

        public void cerrarBD() 
        {
            try
            {
                conectarBD.Close();
                //System.Windows.Forms.MessageBox.Show("Conexcion Cerrada!");
            }
            catch (Exception ex) 
            {
                System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
