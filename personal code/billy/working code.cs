using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemon_stand
{
    class Program
    {
        static void Main(string[] args)
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
                        Environment.Exit(0);
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
                    going = true; 
                    Console.WriteLine("what do you want to do?");
                    Console.WriteLine("check till works or 1");
                    Console.WriteLine("check float or 2");
                    Console.WriteLine("wait for customers or 3");
                    string answer = Console.ReadLine();

                    switch (answer)
                    {
                        case "1":
                            Console.WriteLine("slected 1");

                            switch (till_check)
                            {
                                case 0:
                                    till_check++;
                                    Console.WriteLine("till is working");
                                    System.Threading.Thread.Sleep(1000);
                                    Console.Clear();
                                    break;
                                case 1:
                                    Console.WriteLine("till is still working");
                                    System.Threading.Thread.Sleep(1000);
                                    Console.Clear();
                                    break;
                            }
                            break;
                        case "2":
                            Console.WriteLine("selected 2");

                            switch (till_check)
                            {
                                case 0:
                                    Console.WriteLine("please open the till first");
                                    System.Threading.Thread.Sleep(1000);
                                    Console.Clear();
                                    break;
                                case 1:
                                    Console.WriteLine("you have {0} in your float", till_float);
                                    Console.WriteLine("is this okay?");
                                    string user_input = Console.ReadLine();

                                    switch (user_input)
                                    {
                                        case "no":
                                        case "n":
                                            Console.WriteLine("okay");
                                            Console.WriteLine("do you want to remove money from the bank");
                                            string user_input2 = Console.ReadLine();
                                            switch (user_input2)
                                            {
                                                case "yes":
                                                case "y":
                                                    int money_needed = 10 - till_float;
                                                    Console.WriteLine(money_needed);
                                                    int final_float = money_needed + till_float;
                                                    till_float = final_float;
                                                    Console.WriteLine("your new float is {0}", final_float);
                                                    System.Threading.Thread.Sleep(2000);
                                                    Console.Clear();
                                                    break;
                                                case "no":
                                                case "n":
                                                    Console.WriteLine("okay - breaking");
                                                    System.Threading.Thread.Sleep(500);
                                                    Console.Clear();
                                                    break;
                                            }
                                            break;

                                        case "yes":
                                        case "y":
                                            Console.WriteLine("your float is {0}", till_float);
                                            System.Threading.Thread.Sleep(1000);
                                            Console.Clear();
                                            break;
                                        default:
                                            Console.WriteLine("please choose an option");
                                            System.Threading.Thread.Sleep(1500);
                                            Console.Clear();
                                            break;
                                    }
                                    break;
                            }
                            break;

                        case "3":
                            Console.Clear();
                            Random rnd2 = new Random();
                            int customer_wait = rnd2.Next(1500, 7000);
                            System.Threading.Thread.Sleep(customer_wait);

                            while (going)
                            {
                                string stock1 = "0";
                                //wagwan this is where i am
                                Console.WriteLine("hello");
                                

                                string[] menu0 = new string[] { " " };
                                string[] menu1 = new string[] { "borgor [1]", " £3.00", stock1 };
                                string[] menu2 = new string[] { "cheese borgor [2]", " £3.50", stock1 };
                                string[] menu3 = new string[] { "chips [3]", " £1.50", stock1 };
                                string[] menu4 = new string[] { "lemonade [4]", " £1.00", stock1 };
                                string[] menu5 = new string[] { "coke [5]", " £1.00", stock1 };
                                string[] menu6 = new string[] { "fanta [6]", " £1.00", stock1 };
                                string[][] menuall = new string[][] { menu1, menu2, menu3, menu4, menu5, menu6 };
                                string[][] Order = new string[7][] { menu0, menu0, menu0, menu0, menu0, menu0, menu0, };

                                foreach (string[] i in menuall)
                                {
                                    foreach (string j in i)
                                    {
                                        Console.Write(j);
                                    }
                                    Console.WriteLine(" ");
                                }

                                Console.WriteLine("if you would like quit enter [q]");
                                Console.WriteLine("what would you like to do");
                                string choice = Console.ReadLine();

                                foreach (char i in choice)
                                {
                                    if (i == '1')
                                    {
                                        Order[1] = menu1;
                                    }
                                    if (i == '2')
                                    {
                                        Order[2] = menu2;
                                    }
                                    if (i == '3')
                                    {
                                        Order[3] = menu3;
                                    }
                                    if (i == '5')
                                    {
                                        Order[4] = menu4;
                                    }
                                    if (i == '5')
                                    {
                                        Order[5] = menu5;
                                    }
                                    if (i == '6')
                                    {
                                        Order[6] = menu6;
                                    }
                                    if (i == 'q')
                                    {
                                        going = false;
                                    }
                                }


                                foreach (string[] i in Order)
                                {
                                    foreach (string j in i)
                                    {
                                        if (j == " ")
                                        {

                                        }
                                        else
                                        {
                                            Console.Write(j);
                                        }
                                    }
                                    Console.WriteLine(" ");
                                }
                                Console.WriteLine("is this everything?");
                            }

                        default:
                            Console.Clear();
                            break;
                    }
                }
            }
        }
    }
}
