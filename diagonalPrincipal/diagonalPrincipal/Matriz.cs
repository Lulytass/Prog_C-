using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diagonalPrincipal
{
    internal class Matriz
    {
        int[,] numeros = new int[5,5];
        int[] linea = new int[5];
        public void cargarMatriz()
        {
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0;j < 5; j++)
                {
                    Console.WriteLine("Ingrese un numero entero");

                    numeros[i,j] = int.Parse( Console.ReadLine() );
                }
            }
        }
        public void mostrarMatriz()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(numeros[i,j]);

                }
                Console.WriteLine();
            }
        }
        public void mostrarDiagonal()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if(i == j)
                    {
                        linea[i] = numeros[i, j];
                    }
                }
            }
            for(int f = 0; f < 5; f++)
            {
                Console.Write(linea[f] + " - ");
            }
        }
    }
}
