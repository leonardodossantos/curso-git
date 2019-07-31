using System;
using System.Collections.Generic;
using System.Text;

namespace CursoUdemy
{
    class Pessoas
    {
        public string nome;
        public int idade;
        public double salario;
    }
}
/*
Pessoas x, y;
x = new Pessoas();
y = new Pessoas();

Console.WriteLine("Dados da Primeira Pessoa: ");
            Console.Write("Nome: ");
            x.nome = Console.ReadLine();
            Console.Write("Idade: ");
            x.idade = int.Parse(Console.ReadLine());
Console.Write("Salário: ");
            x.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Dados da Segunda Pessoa: ");
            Console.Write("Nome: ");
            y.nome = Console.ReadLine();
            Console.Write("Idade: ");
            y.idade = int.Parse(Console.ReadLine());
Console.Write("Salário: ");
            y.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            if (x.idade > y.idade)
            {
                Console.WriteLine("Pessoa mais velha:"+x.nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + y.nome);
            }
            double media = (x.salario + y.salario) / 2;

Console.WriteLine("Salário médio = " +media.ToString("F2"));*/
