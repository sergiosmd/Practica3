using SimioAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _MYS1_Practica3_P16.SimioApi
{
    class Path: Base
    {
        int velocidadPath = 16; //60k/h = 16m/s
        public int idpath { get; set; }
        public void Enlazar(INodeObject nodoInicio, INodeObject nodoFin, bool validarNombre = true)
        {
           
            if (validarNombre)
            {
                model.Facility.IntelligentObjects.CreateLink("Path", nodoInicio, nodoFin, null);
                model.Facility.IntelligentObjects["Path1"].ObjectName = "ph" + idpath.ToString();
            }
            else {
                model.Facility.IntelligentObjects.CreateLink("Path", nodoInicio, nodoFin, null).Size = new FacilitySize(2, 0.3, 0);
            }

        }

        public void EnlazarSourceTN(String idSource, INodeObject nodoInicio, INodeObject nodoFin)
        {
            model.Facility.IntelligentObjects.CreateLink("Path", nodoInicio, nodoFin, null);
            model.Facility.IntelligentObjects["Path1"].ObjectName = "ph" + idSource;

        }


        internal void setDistancia(int distancia)
        {
            model.Facility.IntelligentObjects["ph" + idpath.ToString()].Properties["DrawnToScale"].Value = "False";
            model.Facility.IntelligentObjects["ph" + idpath.ToString()].Properties["LogicalLength"].Value = distancia.ToString();
            model.Facility.IntelligentObjects["ph" + idpath.ToString()].Properties["SpeedLimit"].Value = velocidadPath.ToString();
        }
    }
}
