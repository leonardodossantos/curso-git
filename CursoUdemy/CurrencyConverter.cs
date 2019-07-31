
namespace CursoUdemy
{
    class CurrencyConverter
    {
        public static double Iof = 6.0;
        public static double DollarForReal(double quantity, double price) {
            double total = quantity * price;
            return total + total * Iof / 100.0;
        }
    }
}
/*
  Console.Write("Qual é a cotação do dólar? ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você deseja copar? ");
            double quantity = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            double result = CurrencyConverter.DollarForReal(quantity, price);
            Console.WriteLine("Valor a ser pago em reais = " + result.ToString("F2", CultureInfo.InvariantCulture));

     */
     