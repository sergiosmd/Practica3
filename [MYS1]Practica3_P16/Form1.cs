using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SimioAPI;

namespace _MYS1_Practica3_P16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ModelEntity = 0;
            int Model = 1;

            ISimioProject practica3;
            string proyectoBase = "ModelBase.spfx";
            string proyectoPractica3 = "Practica3.spfx";
            string[] warnings;
            IIntelligentObjects objIIObjs;
            IModel model;

            practica3 = SimioProjectFactory.LoadProject(proyectoBase, out warnings);
            model = practica3.Models[Model];
            objIIObjs = model.Facility.IntelligentObjects;

            for (int i = 0; i < 100; i++)
            {
                //objIIObjs.CreateObject();
            }

            SimioProjectFactory.SaveProject(practica3, proyectoPractica3, out warnings);
        }
    }
}
