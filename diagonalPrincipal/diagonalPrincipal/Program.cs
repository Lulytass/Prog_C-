using diagonalPrincipal;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matriz mt = new Matriz();
            mt.cargarMatriz();
            mt.mostrarMatriz();
            mt.mostrarDiagonal();
        }
    }
}