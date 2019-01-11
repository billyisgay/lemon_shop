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

            user  = new string("1234");
            pass  = new string("abcd");

            console.Wrteline("user name");
            user1 = Console.ReadLine();
            console.Wrteline("password");
            pass1 = Console.ReadLine;


            menu1  = new string[3]("borgor", "£3.00", stock1);
            menu2  = new string[3]("cheese borgor", "£3.50", stock1);
            menu3  = new string[3]("chips", "£1.50", stock1);
            menu4  = new string[3]("lemonade", "£1.00", stock1);
            menu5  = new string[3]("coke", "£1.00", stock1);
            menu6  = new string[3]("fanta", "£1.00", stock1);
            menuall = new string[6][](menu1, menu2, menu3, menu4, menu5, menu6);




            foreach (char i in user)
            {
                if (user1 == user)
                {
                    if (pass1 == pass)
                    {

                        console.Wrteline(menu);






                    }
                    else
                    {
                        console.Wrteline("wrong password!!!");
                    }

                }
                else
                {
                    console.Wrteline("wrong username!!!");
                }
            }


        }


    }
}
