// Tarea Semana 2: Programa en C#

using System;

namespace FigurasGeometricas
{
    // Clase base Figura
    public abstract class Figura
    {
        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();
    }

    // Clase Circulo que hereda de Figura
    public class Circulo : Figura
    {
        public double Radio { get; set; }

        public override double CalcularArea()
        {
            // Calcular el área de un círculo: π * radio^2
            return Math.PI * Math.Pow(Radio, 2);
        }

        public override double CalcularPerimetro()
        {
            // Calcular el perímetro de un círculo: 2 * π * radio
            return 2 * Math.PI * Radio;
        }
    }

    // Clase Cuadrado que hereda de Figura
    public class Cuadrado : Figura
    {
        public double Lado { get; set; }

        public override double CalcularArea()
        {
            // Calcular el área de un cuadrado: lado * lado
            return Lado * Lado;
        }

        public override double CalcularPerimetro()
        {
            // Calcular el perímetro de un cuadrado: 4 * lado
            return 4 * Lado;
        }
    }

    // Clase Rectangulo que hereda de Figura
    public class Rectangulo : Figura
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public override double CalcularArea()
        {
            // Calcular el área de un rectángulo: base * altura
            return Base * Altura;
        }

        public override double CalcularPerimetro()
        {
            // Calcular el perímetro de un rectángulo: 2 * (base + altura)
            return 2 * (Base + Altura);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Crear objetos de las clases
            Circulo circulo = new Circulo { Radio = 8 };
            Cuadrado cuadrado = new Cuadrado { Lado = 6 };
            Rectangulo rectangulo = new Rectangulo { Base = 4, Altura = 8 };

            // Calcular y mostrar el área y perímetro
            Console.WriteLine("Área del círculo: " + circulo.CalcularArea());
            Console.WriteLine("Perímetro del círculo: " + circulo.CalcularPerimetro());

            Console.WriteLine("Área del cuadrado: " + cuadrado.CalcularArea());
            Console.WriteLine("Perímetro del cuadrado: " + cuadrado.CalcularPerimetro());

            Console.WriteLine("Área del rectángulo: " + rectangulo.CalcularArea());
            Console.WriteLine("Perímetro del rectángulo: " + rectangulo.CalcularPerimetro());
        }
    }
}

445