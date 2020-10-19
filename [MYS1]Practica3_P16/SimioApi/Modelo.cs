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

            modSimioNuevo = SimioProjectFactory.LoadProject(nombrePryctBase, out warnings);
            Base.model = modSimioNuevo.Models[(int)Tipo.Model];
        }

        public void crearFuerzaArmada() {
            Source fa = new Source(100, -35000, -360000);
        }

        public void crearModelo()
        {
            ReadExcel objExcel;
            INodeObject nodoInicio = null;
            INodeObject nodoFin = null;
            INodeObject nodoInicioMapa = null;
            Path objPath = new Path();
            int distanciaIni = 0;
            int distanciaNodoAnterior = 0;

            objExcel = new ReadExcel();
            var listPuntos = objExcel.readCSV("coordenadasmapalite.csv", true);

            foreach(var item in listPuntos)
            {
                TransferNode tn = new TransferNode(item.id, item.ejeX, item.ejeY);
                nodoFin = tn.getTransferNode();
               

                if(nodoInicioMapa == null)
                {
                    nodoInicioMapa = nodoFin;
                    distanciaIni = item.distancia;
                }

                if (nodoInicio != null)
                {
                    objPath.idpath = item.id;
                    objPath.Enlazar(nodoInicio, nodoFin);
                    objPath.setDistancia(distanciaNodoAnterior);
                    
                }
                nodoInicio = nodoFin;
                distanciaNodoAnterior = item.distancia;
                
            }

            objPath.idpath =1;
            objPath.Enlazar(nodoFin, nodoInicioMapa);
            objPath.setDistancia(distanciaNodoAnterior);
            
        }

        public static void WriteLog(string v)
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
