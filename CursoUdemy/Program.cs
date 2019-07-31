using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

namespace CursoUdemy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com valor: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com valor: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com valor: ");
            int c = int.Parse(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine(a+" he o maior!");

            }else if(b>a && b > c)
            {
                Console.WriteLine(b+" he o maior!");
            }else
            {
                Console.WriteLine(c+" he o maior!");
            }

        }


    }
}
