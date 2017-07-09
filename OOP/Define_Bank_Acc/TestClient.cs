using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Define_Bank_Acc
{
    class TestClient
    {
        private static Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();

        static void Main(string[] args)
        {
            while (true)
            {
                var cmd = Console.ReadLine();

                if(cmd.ToLower() == "end")
                {
                    break;
                }

                var cmdArgs = cmd.Split();
                var cmdType = cmdArgs[0];
                var id = int.Parse(cmdArgs[1]);

                switch (cmdType)
                {
                    case "Create":
                        Create(id);
                        break;
                    case "Deposit":
                        Deposit(id, double.Parse(cmdArgs[2]));
                        break;
                    case "Withdraw":
                        Withdraw(id, double.Parse(cmdArgs[2]));
                        break;
                    case "Print":
                        Print(id);
                        break;
                }
            }


        }

        private static void Create(int id)
        {
            if(accounts.ContainsKey(id))
            {
                Console.WriteLine("Account already exists");
            }
            else
            {
                var acc = new BankAccount();
                acc.ID = id;
                accounts.Add(id, acc);
            }
        }

        private static void Deposit(int id, double amount)
        {
            if (accounts.ContainsKey(id) == false)
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                accounts[id].Deposit(amount);
            }
        }

        private static void Withdraw(int id, double amount)
        {
            if (accounts.ContainsKey(id) == false)
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                if(accounts[id].Balance - amount < 0)
                {
                    Console.WriteLine("Insufficient balancce");
                }
                else
                {
                    accounts[id].Withdraw(amount);
                }
            }
        }

        private static void Print(int id)
        {
            if (accounts.ContainsKey(id) == false)
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                Console.WriteLine(accounts[id].ToString());
            }
        }
    }
}
