using _MYS1_Practica3_P16.SimioApi;
using SimioAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _MYS1_Practica3_P16.DTO
{
    class NumeroDTO
    {
        public INodeObject nodoA { get; set; }
        public INodeObject nodoB { get; set; }
        public INodeObject nodoC { get; set; }
        public INodeObject nodoD { get; set; }
        public INodeObject nodoE { get; set; }
        public INodeObject nodoF { get; set; }

        public int idNodoNum { get; set; }

        public void asignar(int contador, int posx, int posy)
        {
            TransferNode tn = new TransferNode(idNodoNum, posx, posy);
            switch (contador)
            {
                case 1:
                    nodoA = tn.getTransferNode("gt"+idNodoNum);
                    break;
                case 2:
                    nodoB = tn.getTransferNode("gt" + idNodoNum);
                    break;
                case 3:
                    nodoC = tn.getTransferNode("gt" + idNodoNum);
                    break;
                case 4:
                    nodoD = tn.getTransferNode("gt" + idNodoNum);
                    break;
                case 5:
                    nodoE = tn.getTransferNode("gt" + idNodoNum);
                    break;
                case 6:
                    nodoF = tn.getTransferNode("gt" + idNodoNum);
                    break;

            }
        }

        public void enlazar(string numero)
        {
            if (!numero.Equals(""))
            {
                switch (numero)
                {
                    case "1":
                        CrearUno();
                        break;
                    case "2":
                        CrearDos();
                        break;
                    case "3":
                        CrearTres();
                        break;
                    case "4":
                        CrearCuatro();
                        break;
                    case "5":
                        CrearCinco();
                        break;
                    case "6":
                        CrearSeis();
                        break;
                    case "7":
                        CrearSiete();
                        break;
                    case "8":
                        CrearOcho();
                        break;
                    case "9":
                        CrearNueve();
                        break;
                    case "0":
                        CrearCero();
                        break;
                }
            }
        }

        private void CrearCero()
        {
            Path pt = new Path();
            pt.Enlazar(nodoA, nodoE, false);
            pt.Enlazar(nodoE, nodoF, false);
            pt.Enlazar(nodoF, nodoB, false);
            pt.Enlazar(nodoB, nodoA, false);
        }

        private void CrearNueve()
        {
            Path pt = new Path();
            pt.Enlazar(nodoA, nodoB, false);
            pt.Enlazar(nodoC, nodoD, false);
            pt.Enlazar(nodoA, nodoC, false);
            pt.Enlazar(nodoB, nodoF, false);
        }

        private void CrearOcho()
        {
            Path pt = new Path();
            pt.Enlazar(nodoA, nodoB, false);
            pt.Enlazar(nodoC, nodoD, false);
            pt.Enlazar(nodoE, nodoF, false);
            pt.Enlazar(nodoA, nodoE, false);
            pt.Enlazar(nodoB, nodoF, false);
        }

        private void CrearSiete()
        {
            Path pt = new Path();
            pt.Enlazar(nodoA, nodoB, false);
            pt.Enlazar(nodoB, nodoF, false);
        }

        private void CrearSeis()
        {
            Path pt = new Path();
            pt.Enlazar(nodoA, nodoB, false);
            pt.Enlazar(nodoC, nodoD, false);
            pt.Enlazar(nodoE, nodoF, false);
            pt.Enlazar(nodoA, nodoE, false);
            pt.Enlazar(nodoD, nodoF, false);
        }

        private void CrearCinco()
        {
            Path pt = new Path();
            pt.Enlazar(nodoA, nodoB, false);
            pt.Enlazar(nodoC, nodoD, false);
            pt.Enlazar(nodoE, nodoF, false);
            pt.Enlazar(nodoA, nodoC, false);
            pt.Enlazar(nodoD, nodoF, false);
        }

        private void CrearCuatro()
        {
            Path pt = new Path();
            pt.Enlazar(nodoC, nodoD, false);
            pt.Enlazar(nodoA, nodoC, false);
            pt.Enlazar(nodoB, nodoF, false);

        }

        private void CrearTres()
        {
            Path pt = new Path();
            pt.Enlazar(nodoA, nodoB, false);
            pt.Enlazar(nodoC, nodoD, false);
            pt.Enlazar(nodoE, nodoF, false);
            pt.Enlazar(nodoB, nodoF, false);
        }

        public void CrearDos()
        {
            Path pt = new Path();
            pt.Enlazar(nodoA, nodoB, false);
            pt.Enlazar(nodoB, nodoD, false);
            pt.Enlazar(nodoD, nodoC, false);
            pt.Enlazar(nodoC, nodoE, false);
            pt.Enlazar(nodoE, nodoF, false);
        }

        public void CrearUno()
        {
            Path pt = new Path();
            pt.Enlazar(nodoB, nodoF, false);

        }
    }


}
