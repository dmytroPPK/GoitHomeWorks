using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goit.TerraSoft.HomeWork
{
    class Lesson3
    {
        static string msgW = "\nPlease enter the correct data to get information: ";
        static bool flag = false;
        static string login = default(string);
        static bool confirmPass = false;
        static int countPrompt = default(int);

        static string[] admin = {
            "role: admin, login: admin, pwd: 1111, name: Eric ",
            "role: admin, login: root, pwd: 1112, name: Smitty "
        };
        static string[] moderator = {
            "role: moderator, login: moderator, pwd: 2222, name: Billy ",
            "role: moderator, login: moder, pwd: 2244, name: Kelly"
        };
        static string[] user = {
            "role: user, login: user, pwd: 4444, name: John ",
            "role: user, login: baklan, pwd: 4123, name: Eddie ",
            "role: user, login: torpeda, pwd: 4454, name: Tommy ",
            "role: user, login: power, pwd: 4112, name: Mark ",
            "role: user, login: mike12, pwd: 4544, name: Mike ",
            "role: user, login: stifler, pwd: 4223, name: Veronica "
        };

        public static void Run()
        {
            //   role        login     password
            //   admin       admin     1111
            //   moderator   moder     2222
            //   user        user      4444
            Part1();
        }

        private static void Part1()
        {

            do {
                countPrompt += 1;
                flag = false;
                Console.WriteLine(msgW+ "attempt " + countPrompt);
                Console.Write("Your Login: ");
                login = Console.ReadLine();
                switch (login.ToLower())
                {
                    case "admin":
                        ConfirmPassword(role: "admin");
                        break;
                    case "moder":
                        ConfirmPassword(role: "moderator");
                        break;
                    case "user":
                        ConfirmPassword(role: "user");
                        break;
                    default:
                        flag = (countPrompt < 5) ? true : false;
                        Console.Clear();
                        break;
                }
                if (countPrompt == 5 && !confirmPass)
                {
                    Console.WriteLine("Sorry you got 5 attemps. Your login is invalid. Try again next time. Bye!");
                    Console.ReadKey();
                }
                if (countPrompt == 10)
                {
                    Console.WriteLine("\nWow !!! Incorrect data type!!! Bye !!!");
                    Console.ReadKey();
                }
            } while (flag);
        }
        static void ConfirmPassword(string role)
        {
            int check = 1;
            while (check <4) {
                
                try {
                    Console.Write("{"+check+"}"+"Your password: ");
                    string password = Console.ReadLine();
                    int passNum = int.Parse(password);
                    //admin area
                    if (passNum == 1111 && role == "admin") {
                        confirmPass = true;
                        Console.WriteLine("admin area:\n");
                        foreach (string value in admin)
                        {
                            Console.WriteLine(value);
                        }
                        Console.WriteLine();
                        foreach (string value in moderator)
                        {
                            Console.WriteLine(value);
                        }
                        Console.WriteLine();
                        foreach (string value in user)
                        {
                            Console.WriteLine(value);
                        }
                        Console.ReadKey();
                        break;
                    }
                    //moder area
                    else if (passNum == 2222 && role == "moderator")
                    {
                        confirmPass = true;
                        Console.WriteLine("moderator area:\n");
                        Console.WriteLine("Quantity of all users: "+(admin.Length+user.Length+moderator.Length));
                        Console.ReadKey();
                        break;
                    }
                    //user area
                    else if (passNum == 4444 && role == "user")
                    {
                        confirmPass = true;
                        Console.WriteLine("user area:\n");
                        Console.WriteLine("Quantity of persons with {role - User}: "+ user.Length);
                        foreach (string value in user)
                        {
                            Console.WriteLine(" - "+ value.Substring(value.IndexOf("name")+6));
                        }
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        check++;
                    }
                    
                }
                catch (Exception e) {
                    countPrompt = 10;
                    check = 4;
                }
            }
            if (check >= 4 && countPrompt != 10)
            {
                Console.WriteLine("Oops, you made 3 attempts. You didn'n know a correct password.");
                Console.Write("\nPress any key to exit ");
                Console.ReadKey();
            }
        }
    }
}
