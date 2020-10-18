using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using _MYS1_Practica3_P16.Excel;
using _MYS1_Practica3_P16.SimioApi;

namespace _MYS1_Practica3_P16
{
    public partial class Form1 : Form
    {
        Modelo miModelo;
        public Form1()
        {
            miModelo = new Modelo("ModelBase.spfx", "Practica3.spfx");
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            miModelo.crearModelo();
            miModelo.guardarNuevoProyecto();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
