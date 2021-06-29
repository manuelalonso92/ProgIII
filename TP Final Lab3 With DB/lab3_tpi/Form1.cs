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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }        
        private void personaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaPersona ventanaPersona = new VentanaPersona();
            AddOwnedForm(ventanaPersona);
            ventanaPersona.ShowDialog();
        }      
        private void servicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaServicio ventanaServicio = new VentanaServicio();
            AddOwnedForm(ventanaServicio);
            ventanaServicio.ShowDialog();
        }
        private void animalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaAnimal vt = new VentanaAnimal();
            AddOwnedForm(vt);
            vt.ShowDialog();
        }
        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
