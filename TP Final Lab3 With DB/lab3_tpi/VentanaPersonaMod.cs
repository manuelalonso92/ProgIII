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
    public partial class VentanaPersonaMod : Form
    {
        public VentanaPersonaMod()
        {
            InitializeComponent();
        }
        public void ModificarDatos(int dni)
        {
            VentanaPersona vtPadre = Owner as VentanaPersona;

            //modificar
           
            
            ConexionBD modif = new ConexionBD();
            string query = "UPDATE Personas SET nombre = @nombre, apellido = @apellido, sexo = @sexo, estado = @estado, fechaNac = @fechaNac WHERE dni = @dni";
            using (SqlCommand cmd = new SqlCommand(query, modif.conectarBD))
            {
                modif.abrirBD();
                cmd.Parameters.AddWithValue("@dni", dni);
                cmd.Parameters.AddWithValue("@nombre", textBox1_nombre.Text);
                cmd.Parameters.AddWithValue("@apellido", textBox2_apellido.Text);
                cmd.Parameters.AddWithValue("@estado", comboBox1_estado.Text);
                cmd.Parameters.AddWithValue("@sexo", comboBox2_sexo.Text);
                cmd.Parameters.AddWithValue("@fechaNac", dateTimePicker1_nacimiento.Value);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Datos Actualizados!");
                this.Close();

            }
        }
        private void button2_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_aceptar_Click(object sender, EventArgs e)
        {
            //realiazar la Query de Modificacion
            ModificarDatos(Convert.ToInt32(textBox4_dni.Text));
            
           


        }
    }
}

