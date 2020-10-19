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
using System.Security.Permissions;

namespace _MYS1_Practica3_P16.SimioApi
{
    class Region:Base
    {

        private IIntelligentObjects intelligentObjects;
        public int contador_path = 1;

        public Region() {
             
             
        }

        public void CrearModelo() {
       
            //Regiones (SERVERS)
            createServer(0, 0);
            createServer(25000, -100000);
            createServer(150000, -50000);
            createServer(75000, 100000);
            createServer(-75000, 100000);
            createServer(-200000, 50000);
            createServer(-200000, -100000);
            createServer(50000, -250000);
            //Crear Estaciones (SOURCE)
            createSource(0, 10);
            createSource(25000, -99990);
            createSource(150000, -49990);
            createSource(75000, 100010);
            createSource(-75000, 100010);
            createSource(-200000, 50010);
            createSource(-200000, -99990);
            createSource(50000, -249990);
            //Crear Salidas (SINK)
            createSink(0, -10);
            createSink(25000, -100010);
            createSink(150000, -50010);
            createSink(75000, 99990);
            createSink(-75000, 99990);
            createSink(-200000, 49990);
            createSink(-200000, -100010);
            createSink(50000, -250010);
            //Puntos Cardinales (TRANSFERNODE)
            createTransferNode(0, -500000);
            createTransferNode(0, 350000);
            createTransferNode(-450000, 0);
            createTransferNode(450000, 0);
            
            //Modificar Parametros de los Objetos.
            Enlace_Source_Server_Sink();
            Parametros_Server();
            Parametros_Transfer();
            Parametros_Source2();

            for (int x=1; x<=8;x++) {
                Cambiar_Nombre_Source(x);
                Cambiar_Nombre_Sink(x);
            }

            //Rutas Turistas ()
            //Rutas_Turistas();
            Rutas_De_Tres("Sur_Occidente","Salida6", "Nor_Occidente", "Central", "0.35", "0.30", "0.35", "0", "87000", "155000");
            Rutas_De_Tres("Peten", "Salida8", "Norte", "Nor_Oriente", "0.5", "0.25", "0.25", "0", "147000", "282000");

            Rutas_De_Cuatro("Metropolitana", "Salida1", "Central","Sur_Oriente","Nor_Oriente","0.35","0.30","0.15","0.20","0","63000","124000","241000");
            Rutas_De_Cuatro("Norte", "Salida2", "Peten", "Nor_Oriente", "Nor_Occidente", "0.40", "0.40", "0.10", "0.10", "0", "147000", "138000", "145000");
            Rutas_De_Cuatro("Sur_Oriente", "Salida4", "Nor_Oriente", "Metropolitana", "Central", "0.40", "0.20", "0.25", "0.15", "0", "231000", "124000", "154000");
            Rutas_De_Cuatro("Nor_Occidente", "Salida7", "Sur_Occidente", "Central", "Norte", "0.40", "0.30", "0.10", "0.20", "0", "87000", "269000", "145000");

            Rutas_De_Cinco("Central", "Salida5", "Metropolitana", "Sur_Oriente", "Sur_Occidente","Nor_Occidente", "0.35", "0.35", "0.05", "0.15","0.10", "0", "63000", "154000", "155000","269000");
            Rutas_De_Cinco("Nor_Oriente", "Salida3", "Metropolitana", "Norte", "Sur_Oriente", "Peten", "0.20", "0.30", "0.15", "0.05", "0.30", "0", "241000", "138000", "231000", "288000");


        }

        public void Parametros_Server() {
            //Region 1
            Parametros_Server2("Server1","200", "2",  "Metropolitana");
            //Region 2
            Parametros_Server2("Server2", "50", "5", "Norte");
            //Region 3
            Parametros_Server2("Server3", "40", "3", "Nor_Oriente");
            //Region 4
            Parametros_Server2("Server4", "30", "4", "Sur_Oriente");
            //Region 5
            Parametros_Server2("Server5", "100", "5", "Central");
            //Region 6
            Parametros_Server2("Server6", "120", "3", "Sur_Occidente");
            //Region 7
            Parametros_Server2("Server7", "30", "6", "Nor_Occidente");
            //Region 8
            Parametros_Server2("Server8", "150", "4", "Peten");
           
        }

        public void Parametros_Server2(String servidor, String capacidad, String exponencial, String region){
            //Region 
            updateProperty(servidor, "InitialCapacity", capacidad);
            updateProperty(servidor, "ProcessingTime", "Random.Exponential("+exponencial+")");
            updateName(servidor, region);
            updateProperty("Output@"+ region, "OutboundLinkRule", "ByLinkWeight");

        }


            public void Parametros_Transfer() {
            //TransferNode 1
            updateName("TransferNode1", "NNORTE");
            //TransferNode 2
            updateName("TransferNode2", "SUR");
            //TransferNode 3
            updateName("TransferNode3", "OESTE");
            //TransferNode 4
            updateName("TransferNode4", "ESTE");         

        }

        public void Cambiar_Nombre_Source(int x) {
            //Source
            updateName("Source"+x, "Estacion"+x);
            
        }

        public void Cambiar_Nombre_Sink(int x) {
            //Sink
            updateName("Sink"+x, "Salida"+x);
        }

        public void Parametros_Source2()
        {
            //Source
            updateProperty("Source1", "InterarrivalTime", "Random.Poisson(2)");
            updateProperty("Source2", "InterarrivalTime", "Random.Poisson(8)");
            updateProperty("Source3", "InterarrivalTime", "Random.Poisson(6)");
            updateProperty("Source4", "InterarrivalTime", "Random.Poisson(10)");
            updateProperty("Source5", "InterarrivalTime", "Random.Poisson(3)");
            updateProperty("Source6", "InterarrivalTime", "Random.Poisson(4)");
            updateProperty("Source7", "InterarrivalTime", "Random.Poisson(12)");
            updateProperty("Source8", "InterarrivalTime", "Random.Poisson(4)");

        }

        public void Enlace_Source_Server_Sink()
        {

            for (int x = 1; x <= 8; x++)
            {
                createPath(getNodo("Source" + x, 0), getNodo("Server" + x, 0));
                updateName("Path1", "L" + x);               

            }

        }



        public void Rutas_De_Cuatro(String L1, String L2, String L3, String L4, String L5, String P1, String P2, String P3, String P4, String K1, String K2, String K3, String K4) {
            
            createPath(getNodo(L1, 1), getNodo(L2, 0));
            updateName("Path1", "E" + contador_path);
            updateProperty("E"+contador_path, "SelectionWeight", P1);
            updateProperty("E" + contador_path, "SpeedLimit", "19.4");
           

            contador_path++;

            createPath(getNodo(L1, 1), getNodo(L3, 0));
            updateName("Path1", "E" + contador_path);
            updateProperty("E" + contador_path, "SelectionWeight", P2);
            updateProperty("E" + contador_path, "DrawnToScale", "False");
            updateProperty("E" + contador_path, "LogicalLength", K2);
            updateProperty("E" + contador_path, "SpeedLimit", "19.4");
            contador_path++;

            createPath(getNodo(L1, 1), getNodo(L4, 0));
            updateName("Path1", "E" + contador_path);
            updateProperty("E" + contador_path, "SelectionWeight", P3);
            updateProperty("E" + contador_path, "DrawnToScale", "False");
            updateProperty("E" + contador_path, "LogicalLength", K3);
            updateProperty("E" + contador_path, "SpeedLimit", "19.4");
            contador_path++;

            createPath(getNodo(L1, 1), getNodo(L5, 0));
            updateName("Path1", "E" + contador_path);
            updateProperty("E" + contador_path, "SelectionWeight", P4);
            updateProperty("E" + contador_path, "DrawnToScale", "False");
            updateProperty("E" + contador_path, "LogicalLength", K4);
            updateProperty("E" + contador_path, "SpeedLimit", "19.4");
            contador_path++;
        }

        public void Rutas_De_Tres(String L1, String L2, String L3, String L4, String P1, String P2, String P3, String K1, String K2, String K3)
        {

            createPath(getNodo(L1, 1), getNodo(L2, 0));
            updateName("Path1", "E" + contador_path);
            updateProperty("E" + contador_path, "SelectionWeight", P1);
            updateProperty("E" + contador_path, "SpeedLimit", "19.4");

            contador_path++;

            createPath(getNodo(L1, 1), getNodo(L3, 0));
            updateName("Path1", "E" + contador_path);
            updateProperty("E" + contador_path, "SelectionWeight", P2);
            updateProperty("E" + contador_path, "DrawnToScale", "False");
            updateProperty("E" + contador_path, "LogicalLength", K2);
            updateProperty("E" + contador_path, "SpeedLimit", "19.4");
            contador_path++;

            createPath(getNodo(L1, 1), getNodo(L4, 0));
            updateName("Path1", "E" + contador_path);
            updateProperty("E" + contador_path, "SelectionWeight", P3);
            updateProperty("E" + contador_path, "DrawnToScale", "False");
            updateProperty("E" + contador_path, "LogicalLength", K3);
            updateProperty("E" + contador_path, "SpeedLimit", "19.4");
            contador_path++;
            
        }

        public void Rutas_De_Cinco(String L1, String L2, String L3, String L4, String L5, String L6, String P1, String P2, String P3, String P4, String P5, String K1, String K2, String K3, String K4, String K5)
        {
            createPath(getNodo(L1, 1), getNodo(L2, 0));
            updateName("Path1", "E" + contador_path);
            updateProperty("E" + contador_path, "SelectionWeight", P1);
            updateProperty("E" + contador_path, "SpeedLimit", "19.4");

            contador_path++;

            createPath(getNodo(L1, 1), getNodo(L3, 0));
            updateName("Path1", "E" + contador_path);
            updateProperty("E" + contador_path, "SelectionWeight", P2);
            updateProperty("E" + contador_path, "DrawnToScale", "False");
            updateProperty("E" + contador_path, "LogicalLength", K2);
            updateProperty("E" + contador_path, "SpeedLimit", "19.4");
            contador_path++;

            createPath(getNodo(L1, 1), getNodo(L4, 0));
            updateName("Path1", "E" + contador_path);
            updateProperty("E" + contador_path, "SelectionWeight", P3);
            updateProperty("E" + contador_path, "DrawnToScale", "False");
            updateProperty("E" + contador_path, "LogicalLength", K3);
            updateProperty("E" + contador_path, "SpeedLimit", "19.4");
            contador_path++;

            createPath(getNodo(L1, 1), getNodo(L5, 0));
            updateName("Path1", "E" + contador_path);
            updateProperty("E" + contador_path, "SelectionWeight", P4);
            updateProperty("E" + contador_path, "DrawnToScale", "False");
            updateProperty("E" + contador_path, "LogicalLength", K4);
            updateProperty("E" + contador_path, "SpeedLimit", "19.4");
            contador_path++;

            createPath(getNodo(L1, 1), getNodo(L6, 0));
            updateName("Path1", "E" + contador_path);
            updateProperty("E" + contador_path, "SelectionWeight", P5);
            updateProperty("E" + contador_path, "DrawnToScale", "False");
            updateProperty("E" + contador_path, "LogicalLength", K5);
            updateProperty("E" + contador_path, "SpeedLimit", "19.4");
            contador_path++;

        }
      

        

        public void createTransferNode(int x, int y)
        {
            this.createObject("TransferNode", x, y);
        }

        public void createServer(int x, int y)
        {
            this.createObject("Server", x, y);           
        }

        public void createSource(int x, int y)
        {
            this.createObject("Source", x, y);
        }
        
        public void createSink(int x, int y) {

            this.createObject("Sink",x,y);
        }

        //---------------------------------- Crear objetos y enlaces ----------------------------------//
        public void createObject(String type, int x, int y)
        {
            //intelligentObjects.CreateObject(type, new FacilityLocation(x, 0, y));
            model.Facility.IntelligentObjects.CreateObject(type, new FacilityLocation(x, 0, y));
        }

        public void createLink(String type, INodeObject nodo1, INodeObject nodo2)
        {
            model.Facility.IntelligentObjects.CreateLink(type, nodo1, nodo2, null);
        }

        //------------------------------------- Modificar propiedades --------------------------------//
        public void updateProperty(String name, String property, String value)
        {
            model.Facility.IntelligentObjects[name].Properties[property].Value = value;
        }

        public void updateProperty2(String name, String property, String value)
        {
            model.Facility.IntelligentObjects[name].Properties[property].Value = value;
        }


        //--------------------------------------- Modificar nombre  -----------------------------------//
        public void updateName(String oldName, String newName)
        {
            model.Facility.IntelligentObjects[oldName].ObjectName = newName;
        }

        //--------------------------------------- Crear Enlace  -----------------------------------//
        public void createPath(INodeObject nodo1, INodeObject nodo2)
        {
            this.createLink("Path", nodo1, nodo2);
            Console.WriteLine("path creado...");
        }
        public INodeObject getNodo(String name, int nodo)
        {
            return ((IFixedObject)model.Facility.IntelligentObjects[name]).Nodes[nodo];
        }
    }
}
