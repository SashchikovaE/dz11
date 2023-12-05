using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumakov14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 14.1
            Bank1 bank = new Bank1();
            bank.DumpToScreen();

            // task 14.2
            foreach (Attribute a in typeof(RationalNumber).GetCustomAttributes(false))
            {
                if (a is DeveloperInfoAttribute)
                {
                    DeveloperInfoAttribute attribute = a as DeveloperInfoAttribute;
                    Console.WriteLine($"девелопер: {attribute.DeveloperName}, дата: {attribute.DevelopmentDate}");
                }
            }

            // dz 14.1
            var attributes = typeof(Bank1).GetCustomAttributes(typeof(AccountInfoAttribute), false);
            if (attributes.Length > 0)
            {
                var accountInfoAttribute = (AccountInfoAttribute)attributes[0];
                Console.WriteLine($"девелопер: {accountInfoAttribute.DeveloperName}");
                Console.WriteLine($"организейшан: {accountInfoAttribute.OrganizationName}");
            }
            else
            {
                Console.WriteLine("атрибуты не найдены.");
            }
        }
    }
}
