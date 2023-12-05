using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace dz11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // tasks 13.1, 13.2
            Bank bank = new Bank();
            bank[0] = new BankTransaction(100.0);
            bank[1] = new BankTransaction(-50.0);
            bank[2] = new BankTransaction(200);
            for (int i = 0; i < 3; i++)
            {
                BankTransaction transaction = bank[i];
                if (transaction != null)
                {
                    Console.WriteLine($"транзакция {i + 1}: сумма = {transaction.Sum}, дата = {transaction.Date}");
                }
                else
                {
                    Console.WriteLine($"транзакция {i + 1}: нет транзакций");
                }
            }

            // dz 13.1, 13.2
            Building building = new Building();
            BuildingCollection buildingCollection = new BuildingCollection();
            building.CalculateFloorHeight();
            building.CalculateApartmentsPerEntrance();
            building.CalculateApartmentsPerFloor();
        }
    }
}
