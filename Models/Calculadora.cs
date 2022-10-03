using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace operadores_aritmeticos.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }


        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
public void Multiplicarr(int x, int y)
{
    Console.WriteLine($"{x} * {y} = {x * y}");
}
public void Dividir(int x, int y)
{
    Console.WriteLine($"{x} / {y} = {x / y}");
}
public void Potencia(int x, int y)
{
    double pot = Math.Pow(x, y);//a classe math ja tem pronto o metodo de potencia
            Console.WriteLine($"{x}*{y} = {pot}");
        }

    }
    }

    