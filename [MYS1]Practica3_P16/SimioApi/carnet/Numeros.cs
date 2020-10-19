using _MYS1_Practica3_P16.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _MYS1_Practica3_P16.SimioApi.carnet
{
    class Numeros
    {
        
        string texto = "";
        int numFilas = 3;
        int numColumnas = 2;
        int posActual = 0;
        int posX = 0;
        int posY = 0;

        public Numeros(string textoEntrada)
        {
            this.texto = textoEntrada;
        }

        public void EscribirModelo()
        {
            int separacion = 2;
            int totalNodos = 1;
            int espacioNumero = 4;

            for (int i = 0; i < texto.Length; i++)
            {
                int contador = 1;
                posX = posActual;
                posY = 0;
                NumeroDTO numDto;
                numDto = new NumeroDTO();

                if (texto.ElementAt(i).ToString() !=" ") {
                    for (int j = 1; j <= numFilas; j++)
                    {
                        for (int k = 1; k <= numColumnas; k++)
                        {
                            numDto.idNodoNum = totalNodos;
                            numDto.asignar(contador, posX, posY);
                            posX += separacion;
                            contador += 1;
                            totalNodos += 1;
                        }
                        posY += separacion;
                        posX = posActual;

                    }
                    numDto.enlazar(texto.ElementAt(i).ToString());
                }
                posActual += espacioNumero;
            }

        }

    }
}
