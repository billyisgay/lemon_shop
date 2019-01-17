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
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();

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
                int float_check = 0;
                int customers = 0;
                Random rnd = new Random();
                int till_float = rnd.Next(0, 11);
                while (true)
                {
                    Console.WriteLine("what do you want to do?");
                    Console.WriteLine("check till works or 1");
                    Console.WriteLine("check float or 2");
                    Console.WriteLine("wait for customers or 3");
                    string answer = Console.ReadLine();

                    switch (answer)
                    {
                        case "1":


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


                            switch (till_check)
                            {
                                case 0:
                                    Console.WriteLine("please open the till first");
                                    System.Threading.Thread.Sleep(1000);
                                    Console.Clear();
                                    break;
                                case 1:
                                    float_check++;
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
                            switch (till_check)
                            {
                                case 1:
                                    Console.WriteLine("till checked");
                                    switch (float_check)
                                    {
                                        case 0:
                                            Console.WriteLine("please check your float");
                                            System.Threading.Thread.Sleep(1000);
                                            Console.Clear();
                                            break;

                                        case 1:
                                            Console.WriteLine("float checked");
                                            System.Threading.Thread.Sleep(1000);
                                            Console.Clear();
                                            customers++;
                                            break;
                                    }break;
         
                                case 0:
                                    Console.WriteLine("please check till");
                                    System.Threading.Thread.Sleep(1000);
                                    Console.Clear();
                                    break;
                            }
                            break;




                    }if (customers == 0)
                    {
                        
                    }
                    else
                    {
                        ///// BILLY IS NEEDED HERE SO PUT YOUR GOD DAM MENU IN HERE ASAP PLEASE X 

                        Console.WriteLine("fixed");
                        Console.ReadLine();
                    }


                }
            }
        }
    }

}

                

                                    
                              
                               

                            
                            

                                                

                                            
                                     
                                    
       
