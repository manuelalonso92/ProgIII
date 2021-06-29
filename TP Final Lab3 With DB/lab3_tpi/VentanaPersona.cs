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
    
    public partial class VentanaPersona : Form
    {
        
        public VentanaPersona()
        {
            InitializeComponent();
           
        }

        private void button1_alta_Click(object sender, EventArgs e)
        {
            VentanaPersonaALTA darAlta = new VentanaPersonaALTA();
            darAlta.ShowDialog();
        }

        private void button1_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_buscar_Click(object sender, EventArgs e)
        {
            
            int dni = Convert.ToInt32(textBox1_DNI.Text);
            ConexionBD personas = new ConexionBD();
            string query = "SELECT * from Personas where DNI = @dni";
            using (SqlCommand cmd = new SqlCommand(query, personas.conectarBD))
            {
                personas.abrirBD();
                cmd.Parameters.AddWithValue("@dni", dni);
                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(cmd);
                DataTable dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);
                dataGridView1.DataSource = dtRecord;
                dataGridView1.AllowUserToAddRows = false;

                if (dataGridView1.RowCount == 0)
                {
                    MessageBox.Show("Sin datos para mostrar");
                }
            }
        }

            

        
        private void button1_ver_Click(object sender, EventArgs e)
        {
            //Traer toda la tabla de Personas
            ConexionBD personas = new ConexionBD();
            string query = "SELECT * from Personas";
            using (SqlCommand cmd = new SqlCommand(query, personas.conectarBD))
            {
                personas.abrirBD();
                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(cmd);
                DataTable dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);
                dataGridView1.DataSource = dtRecord;
                dataGridView1.AllowUserToAddRows = false;

            }

            personas.cerrarBD();
        }
        private void button1_baja_Click(object sender, EventArgs e)
        {
            //hacer la baja de una Persona por DNI
            Boolean control = false;
            
            if (string.IsNullOrEmpty(textBox1_DNI.Text))
            {
                MessageBox.Show("Ingrese un DNI para dar Baja!");
                control = false;                
            }
            else
            {
                int dni = Convert.ToInt32(textBox1_DNI.Text);
                
                //Query de Control de existencia
                
                if (existeDni(dni) == true)
                {
                    control = true;
                }
                
                //*******************
                
                if (control == true)
                {                    //abre una ventana
                    this.Visible = false;
                    VentanaPersonaBaja darBaja = new VentanaPersonaBaja();
                    AddOwnedForm(darBaja);
                    darBaja.ShowDialog();                    
                }
                else
                {
                    MessageBox.Show("No existe ese Usuario");
                    this.Close();
                }
            }    
        }

        private Boolean existeDni(int dni) 
        {
            Boolean existe;
            ConexionBD DniBD = new ConexionBD();
            string query = "SELECT dni from Personas where DNI = @dni";
            using (SqlCommand cmd = new SqlCommand(query, DniBD.conectarBD))
            {
                DniBD.abrirBD();
                cmd.Parameters.AddWithValue("@dni", dni);
                int result = Convert.ToInt32(cmd.ExecuteScalar());



                if (result != 0)
                {

                    existe = true;
                    return existe;
                }
                else
                {
                    existe = false;
                    return existe;
                }

                
            }
           
        }

        private void button1_modificacion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1_DNI.Text))
            {
                MessageBox.Show("Error! Debe ingresar un DNI");
            }
            else
            {
                BuscarParaMod(Convert.ToInt32(textBox1_DNI.Text));
                this.Visible = false;
                VentanaPersonaMod modificar = new VentanaPersonaMod();
                AddOwnedForm(modificar);
                modificar.textBox4_dni.Text = textBox1_DNI.Text;
                modificar.textBox2_apellido.Text = txtApellido.Text;
                modificar.textBox1_nombre.Text = txtNombre.Text;
                modificar.comboBox1_estado.Text = txt_estado.Text;
                modificar.comboBox2_sexo.Text = txt_sexo.Text;
                modificar.dateTimePicker1_nacimiento.Value = txt_fechaNac.Value;
                modificar.textBox4_dni.Enabled = false;
                modificar.ShowDialog();                
            }                           
        }
        public void BuscarParaMod(int dni)
        {
            //Traer datos para cargar estos campos
            //por DNI de tabla Persona

            //  |
            //  |  *QUERY TABLA PERSONA * DNI 

            ConexionBD buscar = new ConexionBD();
            string query = "SELECT idFamilia, nombre, apellido, sexo, fechaNac, estado from Personas WHERE dni = @dni";
            using (SqlCommand cmd = new SqlCommand(query, buscar.conectarBD)) 
            {
                buscar.abrirBD();
                cmd.Parameters.AddWithValue("@dni", dni);
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    txtApellido.Text = sdr["apellido"].ToString();
                    txtNombre.Text = sdr["nombre"].ToString();
                    txtFamilia.Text = sdr["idFamilia"].ToString();
                    txt_estado.Text = sdr["estado"].ToString();
                    txt_sexo.Text = sdr["sexo"].ToString();
                    txt_fechaNac.Value = Convert.ToDateTime(sdr["fechaNac"].ToString());
                }

            }

            //  V
            /* datos para cargar aqui */

            //*******************************
            //Boolean control = true;//existe el usuario?
            //cargar estos campos
            //if (control == true)//si existe
            //{
            //    textBox1_DNI.Text = Convert.ToString(dni);
            //    txtApellido.Text = "soto";
            //    txtNombre.Text = "pepito";
            //    txtFamilia.Text = "151";
            //    txt_estado.Text = "morido";
            //    txt_sexo.Text = "anal isando";
            //    txt_fechaNac.Value = Convert.ToDateTime("15/12/1998");
                
            //}
            //else//no existe
            //{
            //    MessageBox.Show("Ese usuario no Existe!");
            //}            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VentanaPersona_Load(object sender, EventArgs e)
        {
            
        }
    }
}
