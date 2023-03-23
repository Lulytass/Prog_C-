using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase22_3
{
    internal class vectoresParalelos
    {
        //variables
        string[] nombres = { "Mariana", "Juan", "Pedro", "Julia", "Federico" };
        int[] edades = { 62, 20, 48, 35, 15 };
        float prom = 0;
        public void ordenar()
        {
            int aux = 0;
            string auxnom;
            for (int i = 0; i < 4; i++)
            {
                for(int f = i+1; f < 5; f++)
                {
                    if (edades[i] < edades[f])
                    {
                        aux = edades[i];
                        edades[i] = edades[f];
                        edades[f] = aux;
                        auxnom = nombres[i];
                        nombres[i] = nombres[f];
                        nombres[f] = auxnom;
                    }
                }
            }
        }  
        public void imprimir()
        {
            Console.WriteLine("Personas mayores de edad.");
            for (int i = 0 ; i < 5 ; i++)
            {
                prom += edades[i];

                Console.WriteLine(nombres[i] + ": " + edades[i]);
            }
            Console.WriteLine("El promedio de edades es: " + prom / 5);
        }
    }
}
