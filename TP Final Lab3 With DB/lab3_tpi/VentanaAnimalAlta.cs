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
    public partial class VentanaAnimalAlta : Form
    {
        public VentanaAnimalAlta()
        {
            InitializeComponent();
        }

        private void button2_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //HACER EL ALTA de ANIMAL
        private void button1_aceptar_Click(object sender, EventArgs e)
        {            
            Boolean control = true;
            if (string.IsNullOrEmpty(textBox1_nombre.Text)) 
            {
                MessageBox.Show("¡Error! debe cargar el nombre del animal");
                control = false;
            }
            if (string.IsNullOrEmpty(textBox2_tipo.Text))
            {
                MessageBox.Show("¡Error! debe cargar el tipo de animal");
                control = false;
            }
            if (string.IsNullOrEmpty(textBox1_origen.Text))
            {
                MessageBox.Show("¡Error! debe cargar su origen");
                control = false;
            }            
            if (string.IsNullOrEmpty(textBox1_edad.Text))
            {
                MessageBox.Show("¡Error! debe cargar la edad del animal");
                control = false;
            }
            if (string.IsNullOrEmpty(textBox1_DNI_titular.Text))
            {
                MessageBox.Show("Ingrese DNI del Dueño!");
                control = false;
            }
            if (control == true)
            {
                cargarDatos();
            }
        }


        //Captura de datos para el Alta de Animal
        public void cargarDatos()
        {
            string nombre = textBox1_nombre.Text;
            string tipo = textBox2_tipo.Text;
            string origen = textBox1_origen.Text;
            string edad = textBox1_edad.Text;
            int titularDNI = Convert.ToInt32(textBox1_DNI_titular.Text);
            int nroFamilia = traerIdFamilia(titularDNI);
            Boolean CrudControl = existeTitular(titularDNI);// que consulte si existe ese DNI en la BD
            if (CrudControl == true)
            {
                CrudAnimalAlta(nombre, tipo, origen, edad, titularDNI, nroFamilia);//agregar un parametro
                this.Close();
            }
            else
            {
                MessageBox.Show("No existe esa Persona, Intente otra vez!");
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
        public Boolean existeTitular(int dni)
        {
            //hacer consulta de la existencia de
            //un dueño por su DNI en tabla Persona
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
        //hacer el Alta de Animal
        public void CrudAnimalAlta(string nombre, string tipo, string origen, string edad, int titularDNI, int NroFamilia)
        {
            Boolean CrudControl = existeTitular(titularDNI);
            if (CrudControl == false || NroFamilia == 0)//condicion para que cuando el dni no se encuentre no tome el animal
            {
                this.Close();
            }
            else
            {

                //Los mensajes estos son para testear
                //********************************** Son las variables del Alta en la BD
                MessageBox.Show("Nombre:\n" + nombre);
                MessageBox.Show("Edad:\n" + edad);
                MessageBox.Show("Tipo:\n" + tipo);
                MessageBox.Show("Origen:\n" + origen);


                //ACA SE HACE EL INSERT GENERAL A LA BD
                ConexionBD insPersonaBD = new ConexionBD();

                string query = "INSERT INTO ANIMALES (idFamilia, nombre, edad, tipo, origen) VALUES (@idFamilia, @nombre, @edad, @tipo, @origen)";
                using (SqlCommand cmd = new SqlCommand(query, insPersonaBD.conectarBD))
                {
                    insPersonaBD.abrirBD();
                    cmd.Parameters.AddWithValue("@idFamilia", NroFamilia);

                    cmd.Parameters.AddWithValue("@nombre", nombre);

                    cmd.Parameters.AddWithValue("@edad", edad);
                    cmd.Parameters.AddWithValue("@tipo", tipo);
                    cmd.Parameters.AddWithValue("@origen", origen);

                    int result = cmd.ExecuteNonQuery();

                    if (result < 0)
                    {
                        MessageBox.Show("Error en insert!");
                    }
                    else
                    {
                        MessageBox.Show("Nuevo Animal Cargado a la Base de Datos");
                        this.Close();
                    }

                }

            }



        }

        private void VentanaAnimalAlta_Load(object sender, EventArgs e)
        {

        }
    }
}
