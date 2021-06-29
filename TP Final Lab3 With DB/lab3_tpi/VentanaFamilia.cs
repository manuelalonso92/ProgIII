using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_sanchez_pablo_sn
{
    public partial class VentanaFamiliaConsulta : Form
    {
        public VentanaFamiliaConsulta()
        {
            InitializeComponent();
            groupBox1.Enabled = false;
        }

        private void button1_no_Click(object sender, EventArgs e)
        {
            VentanaPersonaALTA vtPadre = Owner as VentanaPersonaALTA;
            vtPadre.textBox1_ConsultaDNI.Text = "";
            vtPadre.Visible = true;
            this.Close();
        }

        private void button2_si_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentanaPersonaALTA vtPadre = Owner as VentanaPersonaALTA;
            vtPadre.textBox1_ConsultaDNI.Text = textBox1_dni.Text;
            vtPadre.Visible = true;
            this.Close();
        }
    }
}
