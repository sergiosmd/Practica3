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
using _MYS1_Practica3_P16.SimioApi.carnet;
using Region = _MYS1_Practica3_P16.SimioApi.Region;

namespace _MYS1_Practica3_P16
{
    public partial class Form1 : Form
    {
        Modelo miModelo;
        Modelo modeloCarnet;
        Region objRegion;

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
            miModelo.crearFuerzaArmada();
            objRegion = new Region();
            objRegion.CrearModelo();

            miModelo.guardarNuevoProyecto();

            miModelo = null;

            modeloCarnet = new Modelo("ModelBase.spfx", "CarnetPractica3.spfx");
            Numeros carnets = new Numeros(labTextoNum.Text);
            carnets.EscribirModelo();
            modeloCarnet.guardarNuevoProyecto();

            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show("Generación de modelo Finalizado", "", buttons);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                // Closes the parent form.
                this.Close();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
