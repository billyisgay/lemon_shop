using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemon_shop
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            String username;
            String password;
            String[,] accnts = { { "cads123", "dadada" }, { "bildo", "1234" }, { "delossantos", "gagaga" } };
            int row;
            bool isValideUser = false;
            for (int x = 3; x >= 1; x--)
            {
                Console.WriteLine("You have " + x + " attempt/s.");
                Console.Write("Enter Username>> ");
                username = Console.ReadLine();
                Console.Write("Enter Password>> ");
                password = Console.ReadLine();
                for (row = 0; row < 3; row++)
                {
                    if (username.Equals(accnts[row, 0]) && password.Equals(accnts[row, 1]))
                    {
                        Console.WriteLine("Welcome " + accnts[row, 0] + "!");
                        isValideUser = true;
                        break;
                    }
                }
                if (!isValideUser)
                {
                    Console.WriteLine("Invalid Input.");
                    if (x != 1)
                    {
                        Console.WriteLine("Please Try Again.");
                        Console.Write("\n");
                    }
                    else if (x.Equals(1))
                    {
                        Console.Write("Goodbye!");
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
            {
                Console.WriteLine("login correct");
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("welcome to the shop");
                Random rnd = new Random();
                int till_float = rnd.Next(0, 11);
                Console.WriteLine(till_float);
                while (true)
                {

                    Console.WriteLine("what do you want to do?");
                    Console.WriteLine("check till works or 1");
                    Console.WriteLine("check float or 2");
                    Console.WriteLine("wait for customers or 3");

                    string input = Console.ReadLine();
                    int till_check = 0;
                    if (input == "1")

                    {
                        Console.WriteLine("checking till");
                        till_check++;
                    }
                    else if (input == "2")
                    {
                        Console.WriteLine("checking float");
                        if (till_check == 0)
                        {
                            Console.WriteLine("please check till is working first");
                            System.Threading.Thread.Sleep(1000);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("you have {0} in your float", till_float);
                            Console.WriteLine("is this okay?");
                            string answer = Console.ReadLine();
                            if ((answer == "yes") || (answer == "y"))
                            {
                                Console.WriteLine("okay");
                                Console.WriteLine("do you want to remove money from the bank");
                                string user_input = Console.ReadLine();
                                if ((answer == "yes") || (answer == "y"))
                                {
                                    int money_needed = 10 - till_float;
                                    int final_float = money_needed + till_float;
                                    Console.WriteLine("your new float is {0}", final_float);
                                }
                                else
                                {
                                    Console.WriteLine("okay - breaking ");
                                    System.Threading.Thread.Sleep(500);

                                }


                            }
                        }
                    }
                }
            }
        }
    }
}
                        
                    
             

                        
                        

                        
                            
                    
                                        
                    

           