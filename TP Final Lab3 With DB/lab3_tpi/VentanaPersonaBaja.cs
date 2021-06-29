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
    public partial class VentanaPersonaBaja : Form
    {
        public VentanaPersonaBaja()
        {
            InitializeComponent();
           
        }

        private void button1_cancelar_Click(object sender, EventArgs e)
        {
            VentanaPersona vtPadre = Owner as VentanaPersona;
            vtPadre.Visible = true;
            this.Close();
        }

      

        private void VentanaPersonaBaja_Load(object sender, EventArgs e)
        {
            VentanaPersona vtPadre = Owner as VentanaPersona;
            int dni = Convert.ToInt32(vtPadre.textBox1_DNI.Text);
            traerPersona(dni);
        }

        private void traerPersona(int dni) 
        {
            ConexionBD traerPersonaDB = new ConexionBD();
            string query = "SELECT * from Personas where DNI = @dni";
            using (SqlCommand cmd = new SqlCommand(query, traerPersonaDB.conectarBD))
            {
                traerPersonaDB.abrirBD();
                cmd.Parameters.AddWithValue("@dni", dni);
                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(cmd);
                DataTable dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);
                dataGridView1.DataSource = dtRecord;
                dataGridView1.AllowUserToAddRows = false;


            }
            traerPersonaDB.cerrarBD();
        }

        private void eliminarPersona(int dni) 
        {
            ConexionBD eliminarDb = new ConexionBD();
            string query = "DELETE FROM PERSONAS WHERE DNI = @dni";
            using (SqlCommand cmd = new SqlCommand(query, eliminarDb.conectarBD))
            {
                eliminarDb.abrirBD();
                cmd.Parameters.AddWithValue("@dni", dni);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se ha dado la Baja de la persona Correctamente");

            }
            eliminarDb.cerrarBD();
        }

        private void button1_aceptar_Click(object sender, EventArgs e)
        {
            VentanaPersona vtPadre = Owner as VentanaPersona;
            int dni = Convert.ToInt32(vtPadre.textBox1_DNI.Text);
            eliminarPersona(dni);
            vtPadre.Visible = true;
            vtPadre.textBox1_DNI.Clear();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
