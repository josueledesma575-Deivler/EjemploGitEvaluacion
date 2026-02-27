using System;

namespace EjemploGitEvaluacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();
            int resultado = calc.Sumar(5, 7);
            Console.WriteLine($"El resultado de la suma es: {resultado}");
            int resultadoResta = calc.Restar(10, 3);
            Console.WriteLine($"El resultado de la resta es: {resultadoResta}");
        }
    }

    public class Calculadora
    {
        public int Sumar(int a, int b)
        {
            return a + b; // Aquí experimentamos y creamos la solución
        }
         public int Restar(int a, int b)
         { return a - b; }
    }
}
