using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumakov14
{
    [AccountInfo("людмила бродовская", "втб")]
    internal class Bank1
    {
        public int[] number;
        public double balance;
        public Type type;
        private string accountHolder;
        public Queue<BankTransaction1> transactions { get; set; }
        public string AccountHolder
        {
            get
            {
                return accountHolder;
            }
            set
            {
                accountHolder = value;
            }
        }
        public Bank1()
        {
            GenerateBankNumber(number);
            transactions = new Queue<BankTransaction1>();
        }
        public Bank1(double Balance)
        {
            number = GenerateBankNumber(number);
            balance = Balance;
            transactions = new Queue<BankTransaction1>();
        }
        public Bank1(Type typee)
        {
            number = GenerateBankNumber(number);
            type = typee;
            transactions = new Queue<BankTransaction1>();
        }
        public Bank1(double Balance, Type typee)
        {
            number = GenerateBankNumber(number);
            balance = Balance;
            type = typee;
            transactions = new Queue<BankTransaction1>();
        }
        public int[] GenerateBankNumber(int[] number)
        {
            number = new int[16];
            Random random = new Random();
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = random.Next(0, 10);
            }
            return number;
        }
        public void AddSum(double sum)
        {
            if (sum >= 0)
            {
                balance += sum;
            }
            var transaction = new BankTransaction1(sum);
            transactions.Enqueue(transaction);
        }
        public void WithdrawSum(double sum)
        {
            if (sum >= 0 && sum < balance)
            {
                balance -= sum;
            }
            var transaction = new BankTransaction1(-sum);
            transactions.Enqueue(transaction);
        }
        public void TransferMoney(Bank1 fromAccount, Bank1 account2, double amount)
        {
            if (amount <= fromAccount.balance)
            {
                fromAccount.balance -= amount;
                balance += amount;
                Console.WriteLine($"перевод в размере {amount} успешно выполнен");
            }
            else
            {
                Console.WriteLine("недостаточно средств на счете");
            }
            var transaction = new BankTransaction1(amount);
            transactions.Enqueue(transaction);
        }
        public BankTransaction1 this[int index]
        {
            get
            {
                if (index < 0 || index >= transactions.Count)
                {
                    throw new IndexOutOfRangeException("индекс находится вне диапазона");
                }
                return transactions.ElementAt(index);
            }
            set
            {

            }
        }
        [Conditional("DEBUG_ACCOUNT")]
        public void DumpToScreen()
        {
            Console.WriteLine($"владелец счёта: {AccountHolder}");
            Console.WriteLine($"баланс: {balance}");
        }
    }
}
