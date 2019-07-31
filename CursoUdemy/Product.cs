using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CursoUdemy
{
    class Product
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public int Room { get; set; }


        public Product()
        {
        }

        public double TotalValueInStock()
        {
            return Price * Quantity;
        }

        public void AddProducts(int quantity)
        {
            Quantity += quantity;
        }
        public void RemuvProducts(int quantity)
        {
            Quantity -= quantity;
        }

        public override string ToString()
        {
            return Name
                + ", "
                + Email
                + ", "
                + Room;
        }
    }
}
/*
 * Product p = new Product();

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            p.Name = Console.ReadLine();
            Console.Write("Preço: ");
            p.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);


            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado oa estoque: ");
            int Add = int.Parse(Console.ReadLine());
            p.AddProducts(Add);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            int Remuv = int.Parse(Console.ReadLine());
            p.RemuvProducts(Remuv);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
*/
