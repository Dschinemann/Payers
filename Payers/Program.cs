using Payers.Entities;
using System.Globalization;

class Program
{
    public static void Main()
    {
        Console.Write("Enter the number of tax payers: ");
        int n = int.Parse(Console.ReadLine());
        List<Payer> payers = new List<Payer>();

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Tax payer #{i+1} data:");
            Console.Write("Individual or company (i/c)?");
            bool isCompany = Console.ReadLine().Equals("c") ? true : false;
            Console.Write("Name:");
            string name = Console.ReadLine();
            Console.Write("Anual income: ");
            double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (isCompany)
            {
                Console.Write("Number of employees: ");
                int numberOfEmployess = int.Parse(Console.ReadLine());
                payers.Add(new Company(numberOfEmployess, name,income)) ;
            }
            else
            {
                Console.Write("Health expenditures: ");
                double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                payers.Add(new Individual(healthExpenditures,name,income));
            }

        }
        Console.WriteLine("TAXES PAID:");
        double totalTaxes = 0;
        foreach (Payer payer in payers)
        {
            Console.WriteLine($"{payer.Name}: $ {payer.tax():F2}");
            totalTaxes += payer.tax();
        }
        Console.WriteLine($"TOTAL TAXES: $ {totalTaxes:F2}");

    }
}