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
    class Base
    {
        IModel model;
        public string tipo;
        public string nombre;
        public int ejeX;
        public int ejeY;

        public Base() { }

        enum Tipo 
        {
            Server,
            Combiner,
            Source,
            TimePath,
            Path
        }
    }
}
