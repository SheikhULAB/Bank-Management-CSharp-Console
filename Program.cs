using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {


            String input;
            Bank bank = new Bank();
            Console.WriteLine("*** Bank Management C# Console ***");
            while (true)
            {
                Console.WriteLine("What you want to do:");
                Console.WriteLine("0. Generate Account");
                Console.WriteLine("1. Show account Data");
                Console.WriteLine("2. Deposit money to account");
                Console.WriteLine("3. Withdraw money from account");
                Console.WriteLine("4. Give all account with ID");
                Console.WriteLine("5. Clear screen");
                Console.WriteLine("6. Exit");
                object ob1 = Console.ReadLine();
                input = Convert.ToString(ob1);

                
               switch(input)
                {
                    case "0":
                    Console.WriteLine("Enter account Type :");
                        bank.create_account();
                    break;

                    case "1":
                        Console.Write("Enter account Number :");
                        bank.showInfo();
                        break;

                    case "2":
                        Console.WriteLine("Enter Account Id: ");
                        bank.deposit();
                        break;

                    case "3":
                        Console.WriteLine("Enter Account Id: ");
                        bank.withdraw();
                        break;

                    case "4":
                        bank.showAllAccount();
                        break;

                    case "5":
                        Console.Clear();
                        break;

                    case "6":
                        Environment.Exit(0);
                        break;



                }
               
                   
    
                Console.ReadKey();


            }

           

        }



    }
}