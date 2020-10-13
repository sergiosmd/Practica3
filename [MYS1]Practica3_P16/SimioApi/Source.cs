using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace _MYS1_Practica3_P16.SimioApi
{
    class Source: Base
    {
        public Source(string strNombre, int intEjeX, int intEjeY) {
            this.nombre = strNombre;
            this.ejeX = intEjeX;
            this.ejeY = intEjeY;
        }
    }
}
