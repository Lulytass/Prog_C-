using clase22_3;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            vectoresParalelos vp = new vectoresParalelos();
            vp.ordenar();
            vp.imprimir();
        }
    }
}
