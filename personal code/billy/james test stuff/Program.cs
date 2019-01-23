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
                Random rnd = new Random();
                int till_float = rnd.Next(0, 11);
                while (true)
                {
                    Console.WriteLine("what do you want to do?");
                    Console.WriteLine("check till works or 1");
                    Console.WriteLine("check float or 2");
                    Console.WriteLine("wait for customers or 3");
                    string answer = Console.ReadLine();

                    if (answer == "1")
                    {
                        Console.WriteLine("you have chosen 1");
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
                    }
                    else if (answer == "2")
                    {
                        Console.WriteLine("you have chosen 2");
                        if (till_check == 0)
                        {
                            Console.WriteLine("please open the till first");
                            System.Threading.Thread.Sleep(1000);
                            Console.Clear();
                            continue;
                        }
                        else if (till_check == 1)
                        {
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
                                            Console.WriteLine("okay");
                                            System.Threading.Thread.Sleep(500);
                                            Console.Clear();
                                            break;

                                    }
                                    continue;

                                case "yes":
                                case "y":
                                    Console.WriteLine("your float is {0}", till_float);
                                    System.Threading.Thread.Sleep(1000);
                                    Console.Clear();
                                    continue;
                                default:
                                    Console.WriteLine("please say yes or no");
                                    System.Threading.Thread.Sleep(1500);
                                    Console.Clear();
                                    break;
                            }

                        }


                    }
                    else if (answer == "3")
                    {
                        Console.WriteLine("you have chosen 3");
                        if (till_check == 0)
                        {
                            Console.WriteLine("please check the till");
                            System.Threading.Thread.Sleep(1500);
                            Console.Clear();
                            continue;
                        }
                        else if (till_check == 1)
                        {
                            if (float_check == 0)
                            {
                                Console.WriteLine("please check your float");
                                System.Threading.Thread.Sleep(1500);
                                Console.Clear();
                                continue;
                            }
                            else if (float_check == 1)
                            {
                                while (true)
                                {
                                    bool going = true; 
                                    Console.Clear();
                                    Random customer_wait = new Random();
                                    int wait_time = customer_wait.Next(1000, 4000);
                                    System.Threading.Thread.Sleep(wait_time);
                                    // my code here

                                    


                                    while (going)
                                    {
                                        int total = 0;
                                        Random nd1 = new Random();
                                        int s1 = nd1.Next(1,10);
                                        string stock1 =  s1.ToString();
                                        Random nd2 = new Random();
                                        int s2 = nd2.Next(1, 10);
                                        string stock2 = s2.ToString();
                                        Random nd3 = new Random();
                                        int s3 = nd3.Next(1, 10);
                                        string stock3 = s3.ToString();
                                        Random nd4 = new Random();
                                        int s4 = nd4.Next(1, 10);
                                        string stock4 = s4.ToString();
                                        Random nd5 = new Random();
                                        int s5 = nd5.Next(1, 10);
                                        string stock5 = s5.ToString();
                                        Random nd6 = new Random();
                                        int s6 = nd6.Next(1, 10);
                                        string stock6 = s5.ToString();

                                        int p1 = 3;
                                        string price1 = p1.ToString();
                                        int  p2 = 4;
                                        string price2 = p2.ToString();
                                        int p3 = 1;
                                        string price3 = p3.ToString();
                                        int p4 = 1;
                                        string price4 = p4.ToString();
                                        int p5 = 1;
                                        string price5 = p5.ToString();
                                        int p6 = 1;
                                        string price6 = p6.ToString();
                                        //wagwan this is where i am
                                        Console.WriteLine("hello pick sum food");


                                        string[] menu0 = new string[] { " " };
                                        string[] menu1 = new string[] { "borgor [1]", " £",price1, " ", stock1 };
                                        string[] menu2 = new string[] { "cheese borgor [2]", " £", price2, " ", stock2 };
                                        string[] menu3 = new string[] { "chips [3]", " £", price3, " ", stock3 };
                                        string[] menu4 = new string[] { "lemonade [4]", " £", price4, " ", stock4 };
                                        string[] menu5 = new string[] { "coke [5]", " £", price5, " ", stock5 };
                                        string[] menu6 = new string[] { "fanta [6]", " £", price6, " ", stock6 };
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

                                        Console.WriteLine("if you would like quit or if your finished enter [q]");
                                        
                                        
                                        bool ded = true;
                                        while(ded)
                                        {
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
                                            Console.WriteLine("is this everything? [y] ");
                                            string die = Console.ReadLine();
                                            foreach(char i in die)
                                            {
                                                if (i == 'y')
                                                {
                                                    ded = false;
                                                }
                                                else
                                                {
                                                    ded = true;
                                                }

                                            }
                                        }
                                        
                                        bool money = true;
                                        while(money)
                                        {
                                            foreach (string[] i in Order)
                                            {
                                                foreach (string j in i)
                                                {
                                                    if(j == stock1)
                                                    {                                                       
                                                        total = total + s1;
                                                    }
                                                    if (j == stock2)
                                                    {
                                                        total = total + s2;
                                                    }
                                                    if (j == stock3)
                                                    {
                                                        total = total + s3;
                                                    }
                                                    if (j == stock4)
                                                    {
                                                        total = total + s4;
                                                    }
                                                    if (j == stock5)
                                                    {
                                                        total = total + s5;
                                                    }
                                                    if (j == stock6)
                                                    {
                                                        total = total + s6;
                                                    }

                                                }

                                            }
                                            string total1 = total.ToString();
                                            Console.WriteLine("this costs ", total1);
                                            Console.WriteLine("please put the amount you will pay");
                                            string pay = Console.ReadLine();
                                            int pay1 = Convert.Int32(pay);
                                            if (pay1 >= total)
                                            {
                                                int change = pay1 - total;
                                                string pay2 = change.ToString();
                                                Console.WriteLine("*gives order* with ",pay2);
                                                break;
                                            }
                                            if (pay1 == total)
                                            {
                                                
                                                Console.WriteLine("*gives order*");
                                                break;
                                            }
                                            if (pay1 <= total)
                                            {
                                                Console.WriteLine("this is not enough kys , NO FOOD 4 U"); ;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                            

                                        }

                                    }

                                }

                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("please choose an option");
                        System.Threading.Thread.Sleep(1500);
                        Console.Clear();

                    }

                }
            }
        }
    }
}