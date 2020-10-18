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
        public void Enlazar(INodeObject nodoInicio, INodeObject nodoFin)
        {
            model.Facility.IntelligentObjects.CreateLink("Path", nodoInicio, nodoFin, null);
        }
    }
}
