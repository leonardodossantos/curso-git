using System.Globalization;

namespace CursoUdemy
{
    class BankAccount
    {
        public int AccountNumber { get; private set; }
        public string OwnerOfTheAccount { get; set; }
        public double AccountBalance { get; private set; }

        public BankAccount(int accountNumber, string ownerOfTheAccount)
        {
            AccountNumber = accountNumber;
            OwnerOfTheAccount = ownerOfTheAccount;
        }
        public BankAccount(int accountNumber, string ownerOfTheAccount, double initialDeposit) : this(accountNumber, ownerOfTheAccount)
        {
            Deposit(initialDeposit);
        }

        public void Deposit(double quantity)
        {
            AccountBalance += quantity;
        }
        public void Sake(double quantity)
        {
            AccountBalance -= quantity + 5.0;
        }

        public override string ToString()
        {
            return "Conta"
                + AccountNumber
                + ", Titular: "
                + OwnerOfTheAccount
                + ", Saldo: $ "
                + AccountBalance.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
/*BankAccount account;

            Console.Write("Entre o número da conta: ");
            int accountNumber = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string ownerOfTheAccount = Console.ReadLine();
            Console.Write("Haverá deposito inicial (s/n)? ");
            char answer = char.Parse(Console.ReadLine());
            if (answer == 's' || answer == 'S')
            {
                Console.WriteLine("Entre com o valor de deposito inicial: ");
                double initialDeposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account = new BankAccount(accountNumber, ownerOfTheAccount, initialDeposit);
            }
            else
            {
                account = new BankAccount(accountNumber, ownerOfTheAccount);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(account);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double quantity = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            account.Deposit(quantity);
            Console.WriteLine("Dados atualizados:");
            Console.WriteLine(account);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            quantity = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.Sake(quantity);
            Console.WriteLine("Dados atualizados:");
            Console.WriteLine(account);*/
