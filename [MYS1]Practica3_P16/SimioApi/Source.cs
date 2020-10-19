using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SimioAPI;
using SimioAPI.Extensions;
using SimioAPI.Graphics;
using Simio;
using Simio.SimioEnums;


namespace _MYS1_Practica3_P16.SimioApi
{
    class Source: Base
    {

        public Source(int id, int intEjeX, int intEjeY) {
            this.id = id;
            this.ejeX = intEjeX;
            this.ejeY = intEjeY;
            this.tipo = Base.Tipo.Source.ToString();
            Path objPath = new Path();
            TransferNode tn = new TransferNode();

            //Creacion de TransferNode1
            model.Facility.IntelligentObjects.CreateObject("Source", new FacilityLocation(ejeX, 0, ejeY));
            
                model.Facility.IntelligentObjects["DefaultEntity"].Size = new FacilitySize(30250, 20679, 20205);
            model.Facility.IntelligentObjects[this.tipo + "1"].Size = new FacilitySize(30250, 20679, 20205);
            //Cambio de Nombre
            model.Facility.IntelligentObjects[this.tipo + "1"].Properties["EntityType"].Value = "DefaultEntity";
            model.Facility.IntelligentObjects[this.tipo + "1"].Properties["InterarrivalTime"].Value = "Random.Poisson(3)";
            model.Facility.IntelligentObjects[this.tipo + "1"].ObjectName = "src" + id.ToString();

            objPath.idpath = id;
            objPath.EnlazarSourceTN(id.ToString(),  ((IFixedObject)model.Facility.IntelligentObjects["src" + id.ToString()]).Nodes[0], tn.getTransferNode("gt5"));
            objPath.setDistancia(1);

        }
    }
}
