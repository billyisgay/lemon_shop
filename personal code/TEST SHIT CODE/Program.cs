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
            String[,] accnts = { { "reggie", "1234" }, { "bildo", "1234" }, { "isaac", "1234" } };
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
                int till_check = 0;
                Random rnd = new Random();
                int till_float = rnd.Next(0, 11);


                while (true)
                {

                    Console.WriteLine("what do you want to do?");
                    Console.WriteLine("check till works or 1");
                    Console.WriteLine("check float or 2");
                    Console.WriteLine("wait for customers or 3");

                    string input = Console.ReadLine();

                    if (input == "1")
                    {
                        Console.WriteLine("checking till");
                        if (till_check == 0)
                        {
                            till_check++;

                            Console.WriteLine("till is working");
                            System.Threading.Thread.Sleep(1000);
                            Console.Clear();
                            
                        }
                        else if (till_check == 1)
                        {

                            Console.WriteLine("till is still working");
                            System.Threading.Thread.Sleep(1000);
                            Console.Clear();
                            
                        }

                    }
                    if (input == "2")
                    {
                        Console.WriteLine("checking float");
                        if (till_check == 0)
                        {
                            Console.WriteLine("please check till is working first");
                            System.Threading.Thread.Sleep(1000);
                            Console.Clear();
                            
                        }
                        if (till_check == 1)
                        {
                            Console.WriteLine("you have {0} in your float", till_float);
                            Console.WriteLine("is this okay?");
                            string answer = Console.ReadLine();
                            if ((answer == "no") || (answer == "n"))
                            {
                                Console.WriteLine("okay");
                                Console.WriteLine("do you want to remove money from the bank");
                                string user_input = Console.ReadLine();
                                if ((user_input == "yes") || (user_input == "y"))
                                {
                                    int money_needed = 10 - till_float;
                                    Console.WriteLine(money_needed);
                                    int final_float = money_needed + till_float;
                                    till_float = final_float;
                                    Console.WriteLine("your new float is {0}", final_float);
                                    System.Threading.Thread.Sleep(2000);
                                    Console.Clear();
                                    
                                }
                                if ((user_input == "no") || (user_input == "n"))
                                {
                                    Console.WriteLine("okay - breaking ");
                                    System.Threading.Thread.Sleep(500);
                                    
                                }


                            }
                            if ((answer == "yes") || (answer == "y"))
                            {
                                Console.WriteLine("your float is {0}", till_float);
                                System.Threading.Thread.Sleep(1000);
                                Console.Clear();
                                
                            }
                        }
                    }
                    {

                        if (input == "3")
                        {
                            Console.Clear();
                            Random rnd2 = new Random();
                            int customer_wait = rnd2.Next(1500, 7000);
                            System.Threading.Thread.Sleep(customer_wait);
                            Console.WriteLine("welcome to the shop customer");
                            Console.WriteLine("kill me");

                        }
                    }
                }
            }
        }
    }
}