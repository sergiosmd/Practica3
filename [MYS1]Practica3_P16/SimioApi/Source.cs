using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace _MYS1_Practica3_P16.SimioApi
{
    class Source: Base
    {
        public Source(int id, int intEjeX, int intEjeY) {
            this.id = id;
            this.ejeX = intEjeX;
            this.ejeY = intEjeY;
            this.tipo = "Source";
        }
    }
}
