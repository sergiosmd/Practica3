using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _MYS1_Practica3_P16.Excel;
using SimioAPI;

namespace _MYS1_Practica3_P16.SimioApi
{
    class Modelo
    {

        public Modelo()
        {


        }

        public void crearModelo()
        {

            ISimioProject practica3;
            string proyectoBase = "ModelBase.spfx";
            string proyectoPractica3 = "Practica3.spfx";
            string[] warnings;
            IIntelligentObjects objIIObjs;
            IModel model;
            ReadExcel objExcel;

            practica3 = SimioProjectFactory.LoadProject(proyectoBase, out warnings);
            model = practica3.Models[(int)Tipo.Model];
            objIIObjs = model.Facility.IntelligentObjects;

            objExcel = new ReadExcel();
            var listPuntos = objExcel.readCSV("mapa.csv", true);


            guardarNuevoProyecto(practica3, proyectoPractica3, out warnings);

        }

        private void guardarNuevoProyecto(ISimioProject practica3, string proyectoPractica3, out string[] warnings)
        {
            SimioProjectFactory.SaveProject(practica3, proyectoPractica3, out warnings);
        }

        enum Tipo
        {
            ModelEntity = 0,
            Model = 1
        }

    }
}
