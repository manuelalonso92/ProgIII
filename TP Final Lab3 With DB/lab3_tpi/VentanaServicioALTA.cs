using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace lab3_sanchez_pablo_sn
{
    public partial class VentanaServicioALTA : Form
    {
        public VentanaServicioALTA()
        {
            InitializeComponent();
        }

        private void button2_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_aceptar_Click(object sender, EventArgs e)
        {
            Boolean control = true;
            if (string.IsNullOrEmpty(textBox1_nombre.Text)) //nombre
            {
                MessageBox.Show("¡Error! debe cargar el nombre de la empresa");
                control = false;
            }
            if (string.IsNullOrEmpty(comboBox1_servicio.Text)) //servicio
            {
                MessageBox.Show("¡Error! debe seleccionar el Servicio");
                control = false;
            }
            if (string.IsNullOrEmpty(textBox3_costo.Text)) //costo
            {
                MessageBox.Show("¡Error! debe cargar el costo del servicio en $");
                control = false;
            }                       
            if (control == true)
            {
                cargaDatos();
            }
        }
        //Captura de datos para el Alta de un Servicio
        public void cargaDatos()
        {
            string nombreEmpresa = textBox1_nombre.Text;
            string servicio = comboBox1_servicio.Text;
            string costo = textBox3_costo.Text;
            Boolean premium = checkBox1_premium.Checked;
            int titularDNI = Convert.ToInt32(textBox1_DNI_titular.Text);
            int nroFamilia = traerIdFamilia(titularDNI);

            if (textBox1_DNI_titular.Text == "")
            {
                MessageBox.Show("Ingrese DNI del Titular!");
            }
            else
            {

                Boolean CrudControl = existeTitular(titularDNI);// que consulte si existe ese DNI en la BD
                if (CrudControl == true)
                {
                    CrudServicioAlta(nombreEmpresa, servicio, costo, premium, titularDNI, nroFamilia);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No existe ese titular, Intente otra vez!");
                }
            }
        }
        public Boolean existeTitular(int dni)
        {   //hacer consulta de la existencia de
            //un titular por su DNI en tabla Persona
            //Boolean control = false;//variable de control

            int NroFamilia;
            ConexionBD seltitularBD = new ConexionBD();
            string query = "SELECT idFamilia from Personas where DNI = @dni";
            using (SqlCommand cmd = new SqlCommand(query, seltitularBD.conectarBD))
            {
                seltitularBD.abrirBD();
                cmd.Parameters.AddWithValue("@dni", dni);
                NroFamilia = Convert.ToInt32(cmd.ExecuteScalar());

                if (NroFamilia != 0)
                {
                    return true;

                }
                else { return false; }


                //seltitularBD.cerrarBD();
            }
        }

        public int traerIdFamilia(int dni)
        {

            int NroFamilia;
            ConexionBD seltitularBD = new ConexionBD();
            string query = "SELECT idFamilia from Personas where DNI = @dni";
            using (SqlCommand cmd = new SqlCommand(query, seltitularBD.conectarBD))
            {
                seltitularBD.abrirBD();
                cmd.Parameters.AddWithValue("@dni", dni);
                NroFamilia = Convert.ToInt32(cmd.ExecuteScalar());

                if (NroFamilia != 0)
                {
                    return NroFamilia;

                }
                else { return 0; }


                //seltitularBD.cerrarBD();
            }

        }
        //hacer el Alta de Servicio
        public void CrudServicioAlta(string nombreEmpresa, string servicio, string costo, Boolean premium, int titularDNI, int NroFamilia)
        {
            Boolean CrudControl = existeTitular(titularDNI);
            if (CrudControl == false || NroFamilia == 0)//condicion para que cuando el dni no se encuentre no tome el servicio
            {
                this.Close();
            }
            else
            {

                //Los mensajes estos son para testear
                //********************************** Son las variables del Alta en la BD
                MessageBox.Show("servicio:\n" + servicio);
                MessageBox.Show("empresa:\n" + nombreEmpresa);
                MessageBox.Show("costo:\n" + costo);
                MessageBox.Show("premium:\n" + premium);


                //ACA SE HACE EL INSERT GENERAL A LA BD
                ConexionBD insPersonaBD = new ConexionBD();

                string query = "INSERT INTO SERVICIOS (idFamilia, servicio, empresa, costo, premium) VALUES (@idFamilia, @servicio, @empresa, @costo, @premium)";
                using (SqlCommand cmd = new SqlCommand(query, insPersonaBD.conectarBD))
                {
                    insPersonaBD.abrirBD();
                    cmd.Parameters.AddWithValue("@idFamilia", NroFamilia);

                    cmd.Parameters.AddWithValue("@servicio", servicio);

                    cmd.Parameters.AddWithValue("@empresa", nombreEmpresa);
                    cmd.Parameters.AddWithValue("@costo", costo);
                    cmd.Parameters.AddWithValue("@premium", premium);

                    int result = cmd.ExecuteNonQuery();

                    if (result < 0)
                    {
                        MessageBox.Show("Error en insert!");
                    }
                    else
                    {
                        MessageBox.Show("Nuevo Servicio Cargado a la Base de Datos");
                        this.Close();
                    }

                }

            }

        }

        private void VentanaServicioALTA_Load(object sender, EventArgs e)
        {

        }
    }
}
