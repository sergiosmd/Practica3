using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using _MYS1_Practica3_P16.Excel;
using SimioAPI;

namespace _MYS1_Practica3_P16.SimioApi
{
    class Modelo
    {
        string nombrePryctBase;
        string nombrePryctNuevo;
        ISimioProject modSimioNuevo;
        string[] warnings;
        public Modelo(string nombreMdlBase, string nombreMdlFinal)
        {

            this.nombrePryctBase = nombreMdlBase;
            this.nombrePryctNuevo = nombreMdlFinal;
        }

        public void crearModelo()
        {

            string[] warnings;
            ReadExcel objExcel;
            INodeObject nodoInicio = null;
            INodeObject nodoFin = null;
            INodeObject nodoInicioMapa = null;
            Path objPath = new Path();

            modSimioNuevo = SimioProjectFactory.LoadProject(nombrePryctBase, out warnings);
            Base.model = modSimioNuevo.Models[(int)Tipo.Model];

            objExcel = new ReadExcel();
            var listPuntos = objExcel.readCSV("puntos.csv",false);

            foreach(var item in listPuntos)
            {
                TransferNode tn = new TransferNode(item.id, item.ejeX, item.ejeY);
                nodoFin = tn.getTransferNode();

                if(nodoInicioMapa == null)
                {
                    nodoInicioMapa = nodoFin;
                }

                if (nodoInicio != null)
                {
                    objPath.Enlazar(nodoInicio, nodoFin);
                }
                nodoInicio = nodoFin;
            }

            objPath.Enlazar(nodoFin, nodoInicioMapa);
        }

        private void WriteLog(string v)
        {
            string path = "logGT.txt";
            using(StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(v);
            }
        }

        public void guardarNuevoProyecto()
        {
            SimioProjectFactory.SaveProject(modSimioNuevo, nombrePryctNuevo, out warnings);
        }

        enum Tipo
        {
            ModelEntity = 0,
            Model = 1
        }

    }
}
