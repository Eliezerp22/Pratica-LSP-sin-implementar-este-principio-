using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica_LSP__sin_implementar_este_principio_
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }


public abstract class FiguraGeometrica
    {
        public abstract decimal CalcularArea();
    }

    public class Rectangulo : FiguraGeometrica
    {
        public decimal Base { get; set; }
        public decimal Altura { get; set; }

        public override decimal CalcularArea()
        {
            return Base * Altura;
        }
    }

    public class Cuadrado : FiguraGeometrica
    {
        public decimal Lado { get; set; }

        public override decimal CalcularArea()
        {
            return Lado * Lado;
        }
    }

    public class Programa
    {
        public static void Main()
        {
            FiguraGeometrica rectangulo = new Rectangulo { Base = 5, Altura = 10 };
            Console.WriteLine($"Área del rectángulo: {rectangulo.CalcularArea()}");

            FiguraGeometrica cuadrado = new Cuadrado { Lado = 5 };
            Console.WriteLine($"Área del cuadrado: {cuadrado.CalcularArea()}");
        }
    }

}
