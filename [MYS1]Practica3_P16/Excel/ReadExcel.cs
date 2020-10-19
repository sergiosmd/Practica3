using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _MYS1_Practica3_P16.DTO;
using Newtonsoft.Json;

namespace _MYS1_Practica3_P16.Excel
{
    class ReadExcel
    {
        public List<CoordenadaDTO> readCSV(string pathCSV, bool blnHeader)
        {
            var listPuntos = new List<CoordenadaDTO>();

            using (var reader = new StreamReader(pathCSV))
            {
                if (blnHeader) {
                    reader.ReadLine();
                }

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');
                    listPuntos.Add(new CoordenadaDTO
                    {
                        id = int.Parse(values[0]),
                        ejeX = int.Parse(values[1]),
                        ejeZ = int.Parse(values[2]),
                        ejeY = int.Parse(values[3]),
                        distancia = int.Parse(values[5])
                    }
                    ); ;

                }
            }
            return listPuntos;
        }
    }
}
