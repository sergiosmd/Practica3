using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SimioAPI;
using SimioAPI.Extensions;
using SimioAPI.Graphics;
using Simio;
using Simio.SimioEnums;

namespace _MYS1_Practica3_P16.SimioApi
{
    class TransferNode: Base
    {
        public TransferNode() { }

        public TransferNode(int id, int ejeX, int ejeY)
        {
            this.id = id;
            this.ejeX = ejeX;
            this.ejeY = ejeY;
            this.tipo = Base.Tipo.TransferNode.ToString();

            //Creacion de TransferNode1
            model.Facility.IntelligentObjects.CreateObject("TransferNode", new FacilityLocation(ejeX, 0, ejeY));
            //Cambio de Nombre
            model.Facility.IntelligentObjects[this.tipo+"1"].ObjectName = "gt" + id.ToString();

        }

        public INodeObject getTransferNode()
        {
            return (INodeObject) model.Facility.IntelligentObjects["gt" + this.id.ToString()];
        }
    }
}
