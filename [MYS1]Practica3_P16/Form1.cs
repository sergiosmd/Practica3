using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using _MYS1_Practica3_P16.Excel;


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
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReadExcel objExcel = new ReadExcel();
            string objJson = objExcel.readCSV("mapa.csv", true);
            Console.WriteLine(objJson);

        }
    }
}
