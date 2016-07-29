using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goit.TerraSoft.HomeWork
{
    //Menu class
    static partial class Menu
    {
        
        private static void GirlsList()
        {

            if (Scout.ListOfScouts.Count == 0)
            {
                Console.WriteLine("Add Scout to list. At present no-one is not at list");
                Menu.MenuOrExit();
                return;
            }

            Console.WriteLine("List of Girls:");
            foreach (var item in Scout.ListOfScouts)
            {
                if (item is Girl)
                {
                    Girl girl = (Girl)item;
                    Console.WriteLine(" - name-> " + girl.Name + ": age-> " + girl.Age);
                }
            }
            
            Menu.MenuOrExit();
            
        }

        private static void BoysList()
        {

            if (Scout.ListOfScouts.Count == 0)
            {
                Console.WriteLine("Add Scout to list. At present no-one is not at list");
                Menu.MenuOrExit();
                return;
            }

            Console.WriteLine("List of Boys:");
            foreach (var item in Scout.ListOfScouts)
            {
                if (item is Boy)
                {
                    Boy boy = (Boy)item;
                    Console.WriteLine(" - name-> " + boy.Name + ": age-> " + boy.Age);
                }
            }
            
            
            Menu.MenuOrExit();
            
        }

        private static void ListGender()
        {

            if (Scout.ListOfScouts.Count == 0)
            {
                Console.WriteLine("Add Scout to list. At present no-one is not at list");
                Menu.MenuOrExit();
                return;
            }

            foreach (var item in Scout.ListOfScouts)
            {
                Console.WriteLine(" - name-> " + item.Name + ": age-> " + item.Age + ": gender-> " + item.Gender);
            }
            
            
            Menu.MenuOrExit();
            
        }

        private static void AllList(bool showInteractive = true)
        {


            if (Scout.ListOfScouts.Count == 0)
            {
                Console.WriteLine("Add Scout to list. At present no-one is not at list");
                Menu.MenuOrExit();
                return;
            }


            string typeOfSport= null;
            int idScout = 0;
            int idAward = 0;
            for (int count=0;count<Scout.ListOfScouts.Count;count++)
            {

                //typeOfSport =
                Boy scoutBoy = Scout.ListOfScouts[count] as Boy;
                Girl scoutGirl = Scout.ListOfScouts[count] as Girl;
                if (scoutBoy != null) { typeOfSport = scoutBoy.MaleSport; }
                if (scoutGirl != null) { typeOfSport = scoutGirl.FemaleSport; }
                Console.WriteLine(++idScout + " : name-> " + Scout.ListOfScouts[count].Name + " : age-> " + Scout.ListOfScouts[count].Age+ " : sport-> "+typeOfSport);
                Console.WriteLine("\t- List of Awards - ");
                for (int i=0; i< Scout.ListOfScouts[count].AwardsScore.Count;i++)
                {
                    Console.WriteLine("\t"+(++idAward)+" : "+Scout.ListOfScouts[count].AwardsName[i]+" : "+ Scout.ListOfScouts[count].AwardsScore[i]);
                }
                Console.WriteLine();
            }
            //foreach (var item in Scout.ListOfScouts)
            //{
            //    Console.WriteLine(" - name-> "+item.Name+": age-> " + item.Age);
            //}
            if (showInteractive)
            {
                Menu.MenuOrExit();
            }
        }

        private static void DeleteSport()
        {
            if (Scout.ListOfScouts.Count == 0)
            {
                Console.WriteLine("Add Scout to list. At present no-one is not at list");
                Menu.MenuOrExit();
                return;
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter the id of scout who will be changed by you:");
            Console.ForegroundColor = ConsoleColor.Gray;
            AllList(false);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Enter the id of scout: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\nThis Point has not been done yet !!! Sorry. ");
            //Delay
            Console.ReadKey();
            //Menu.MenuOrExit();

        }

        private static void AddSport(bool showInteractive = true)
        {

            if (Scout.ListOfScouts.Count == 0)
            {
                Console.WriteLine("Add Scout to list. At present no-one is not at list");
                Menu.MenuOrExit();
                return;
            }

            int idEnetered;
            int idList;
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter the id of scout who will be changed by you:");
            Console.ForegroundColor = ConsoleColor.Gray;
            AllList(false);
            Label_id_Scout:
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Enter the id of scout: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Int32.TryParse(Console.ReadLine(),out idEnetered);
            idList = idEnetered - 1;
            if (idList > Scout.ListOfScouts.Count - 1 || idList<0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Boundary of Index");
                goto Label_id_Scout;
            }
            //Delay
            //Console.ReadKey();
            //Menu.MenuOrExit();
            if (Scout.ListOfScouts[idList] is Boy)
            {
                Boy boy = (Boy)Scout.ListOfScouts[idList];
                Console.Clear();
                Console.WriteLine("Boy: "+ boy.Name+ " should choose male kind of sport:");
                Console.Write("\n\t");
                foreach (var item in Boy.sport)
                {
                    Console.Write(" -> " + item);

                }
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\nEnter a sport: ");
                boy.MaleSport = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Added!");
            }
            if (Scout.ListOfScouts[idList] is Girl)
            {
                Girl girl = (Girl)Scout.ListOfScouts[idList];
                Console.Clear();
                Console.WriteLine("Girl: " + girl.Name + " should choose male kind of sport:");
                Console.Write("\n\t");
                foreach (var item in Girl.sport)
                {
                    Console.Write(" -> " + item );

                }
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\nEnter a sport: ");
                girl.FemaleSport = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Added!");

            }

            Menu.MenuOrExit();

        }

        private static void AddScout()
        {
            string name;
            string gender;
            int age =0;
            Console.Clear();
            Console.WriteLine("\t<< Add new scout >>");
            Console.Write(" Enter name: ");
            name = Console.ReadLine();
            Console.Write(" Enter age: ");
            Int32.TryParse(Console.ReadLine(),out age);
            string typeOfSport = null;
        Label_Gender:
            Console.Write(" Enter gender [Male/Female]: ");
            gender = Console.ReadLine().ToLower();
            // block Add scout
            {
                if (gender == "male")
                {

                    Console.WriteLine("Kind of sports for male: ");
                    foreach (var item in Boy.sport) {
                        Console.WriteLine(" -> "+item+" <-");
                    }
                    Console.Write("Choose sport that was listed above: ");
                    typeOfSport = Console.ReadLine();

                    Scout.ListOfScouts.Add(new Boy()
                    {
                        Name = name,
                        Age = age,
                        Gender = gender,
                        MaleSport = typeOfSport
                    });
                }
                else if (gender == "female")
                {

                    Console.WriteLine("Kind of sports for female: ");
                    foreach (var item in Girl.sport)
                    {
                        Console.WriteLine(" -> " + item + " <-");
                    }
                    Console.Write("Choose sport that was listed above: ");
                    typeOfSport = Console.ReadLine();

                    Scout.ListOfScouts.Add(new Girl()
                    {
                        Name = name,
                        Age = age,
                        Gender = gender,
                        FemaleSport = typeOfSport
                    });
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid gender type. Try again!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    goto Label_Gender;
                }

            }
            // block add awards to scout
            {
                bool addAgain = false;
                do
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    string nameOfAward;
                    int scoreOfAward;
                    Console.WriteLine("Now you must add award");
                    Console.Write("Name of Award: ");
                    nameOfAward = Console.ReadLine();
                    Console.Write("Score of Award: ");
                    bool canParse = Int32.TryParse(Console.ReadLine(), out scoreOfAward);
                    if (!canParse) { scoreOfAward = 0; }
                    Scout.ListOfScouts[Scout.ListOfScouts.Count - 1].AddAward(nameOfAward, scoreOfAward);
                    Label_award:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("Do you want to add another award? <yes,no>: ");
                    string answer = Console.ReadLine();
                    if (answer.ToLower() == "yes")
                    {
                        addAgain = true;
                        // or continue;
                    }
                    else if (answer.ToLower() == "no")
                    {
                        break;
                    }
                    else
                    {
                        goto Label_award;
                    }

                } while(addAgain);
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" -> Scout added !!!");
            //Console.ForegroundColor = ConsoleColor.Gray;
            
            Menu.MenuOrExit();
            

        }


        private static void Calculate()
        {

            if (Scout.ListOfScouts.Count == 0)
            {
                Console.WriteLine("Add Scout to list. At present no-one is not at list");
                Menu.MenuOrExit();
                return;
            }
            //Средний бал лагеря
            {
                int avarageCampusScore = 0;
                Console.Clear();
                foreach (var item in Scout.ListOfScouts)
                {
                    avarageCampusScore += item.AvarageScoreOfScout;

                }
                avarageCampusScore /= Scout.ListOfScouts.Count;
                Console.WriteLine("Средний бал лагеря - " + avarageCampusScore);
            }
            Console.WriteLine("---------");
            //Самый высокий средний бал дев и мальчик
            {
                int[] maxOfBoys = new int[Scout.ListOfScouts.Count];
                int[] maxOfGirls = new int[Scout.ListOfScouts.Count];
                for (int i = 0; i < Scout.ListOfScouts.Count; i++)
                {
                    if (Scout.ListOfScouts[i] is Boy)
                    {
                        maxOfBoys[i] = Scout.ListOfScouts[i].AvarageScoreOfScout;
                    }
                    else
                    {
                        maxOfBoys[i] = 0;
                    }
                    if (Scout.ListOfScouts[i] is Girl)
                    {
                        maxOfGirls[i] = Scout.ListOfScouts[i].AvarageScoreOfScout;
                    }
                    else
                    {
                        maxOfGirls[i] = 0;
                    }

                }
                string nameOfBoy = "no-one";
                if (Scout.ListOfScouts[Array.IndexOf(maxOfBoys, maxOfBoys.Max())].AwardsName.Count > 0)
                {
                    nameOfBoy = Scout.ListOfScouts[Array.IndexOf(maxOfBoys, maxOfBoys.Max())].Name;
                }
                string nameOfGirl = "no-one";
                if (Scout.ListOfScouts[Array.IndexOf(maxOfGirls, maxOfGirls.Max())].AwardsName.Count > 0)
                {
                    nameOfGirl = Scout.ListOfScouts[Array.IndexOf(maxOfGirls, maxOfGirls.Max())].Name;
                }
                Console.WriteLine("Мах средний бал среди парней: " + maxOfBoys.Max() + ". У " + nameOfBoy);
                Console.WriteLine("Мах средний бал среди девушек: " + maxOfGirls.Max() + ". У " + nameOfGirl);
            }
            Console.WriteLine("---------");
            //Самого успешного скаута – больше всего балов за все предметы (мальчик и девочка)
            {
                int[] maxOfBoys = new int[Scout.ListOfScouts.Count];
                int[] maxOfGirls = new int[Scout.ListOfScouts.Count];
                for (int i = 0; i < Scout.ListOfScouts.Count; i++)
                {
                    if (Scout.ListOfScouts[i] is Boy)
                    {
                        maxOfBoys[i] = Scout.ListOfScouts[i].AllScoreOfScout;
                    }
                    else
                    {
                        maxOfBoys[i] = 0;
                    }
                    if (Scout.ListOfScouts[i] is Girl)
                    {
                        maxOfGirls[i] = Scout.ListOfScouts[i].AllScoreOfScout;
                    }
                    else
                    {
                        maxOfGirls[i] = 0;
                    }

                }
                string nameOfBoy = "no-one";
                if (Scout.ListOfScouts[Array.IndexOf(maxOfBoys, maxOfBoys.Max())].AwardsName.Count > 0)
                {
                    nameOfBoy = Scout.ListOfScouts[Array.IndexOf(maxOfBoys, maxOfBoys.Max())].Name;
                }
                string nameOfGirl = "no-one";
                if (Scout.ListOfScouts[Array.IndexOf(maxOfGirls, maxOfGirls.Max())].AwardsName.Count > 0)
                {
                    nameOfGirl = Scout.ListOfScouts[Array.IndexOf(maxOfGirls, maxOfGirls.Max())].Name;
                }
                Console.WriteLine("Мах бал за все предметы среди парней: " + maxOfBoys.Max() + ". У " + nameOfBoy);
                Console.WriteLine("Мах бал за все предметы среди девушек: " + maxOfGirls.Max() + ". У " + nameOfGirl);
            }
            Console.WriteLine("---------");
            //Самого активного скаута – больше всего предметов (мальчик и девочка)
            {
                int[] maxOfBoys = new int[Scout.ListOfScouts.Count];
                int[] maxOfGirls = new int[Scout.ListOfScouts.Count];
                for (int i = 0; i < Scout.ListOfScouts.Count; i++)
                {
                    if (Scout.ListOfScouts[i] is Boy)
                    {
                        maxOfBoys[i] = Scout.ListOfScouts[i].NumberOfAwards;
                    }
                    else
                    {
                        maxOfBoys[i] = 0;
                    }
                    if (Scout.ListOfScouts[i] is Girl)
                    {
                        maxOfGirls[i] = Scout.ListOfScouts[i].NumberOfAwards;
                    }
                    else
                    {
                        maxOfGirls[i] = 0;
                    }

                }
                string nameOfBoy = "no-one";
                if (Scout.ListOfScouts[Array.IndexOf(maxOfBoys, maxOfBoys.Max())].AwardsName.Count > 0)
                {
                    nameOfBoy = Scout.ListOfScouts[Array.IndexOf(maxOfBoys, maxOfBoys.Max())].Name;
                }
                string nameOfGirl = "no-one";
                if (Scout.ListOfScouts[Array.IndexOf(maxOfGirls, maxOfGirls.Max())].AwardsName.Count > 0)
                {
                    nameOfGirl = Scout.ListOfScouts[Array.IndexOf(maxOfGirls, maxOfGirls.Max())].Name;
                }
                Console.WriteLine("Больше всего предметов среди парней: " + maxOfBoys.Max() + ". У " + nameOfBoy);
                Console.WriteLine("Больше всего предметов среди девушек: " + maxOfGirls.Max() + ". У " + nameOfGirl);
            }
            Console.WriteLine("---------");
            //Самого большого лентяя мальчика, девочку. (меньше всего предметов)
            {
                int[] maxOfBoys = new int[Scout.ListOfScouts.Count];
                int[] maxOfGirls = new int[Scout.ListOfScouts.Count];
                for (int i = 0; i < Scout.ListOfScouts.Count; i++)
                {
                    if (Scout.ListOfScouts[i] is Boy)
                    {
                        maxOfBoys[i] = Scout.ListOfScouts[i].NumberOfAwards;
                    }
                    else
                    {
                        maxOfBoys[i] = Int32.MaxValue;
                    }
                    if (Scout.ListOfScouts[i] is Girl)
                    {
                        maxOfGirls[i] = Scout.ListOfScouts[i].NumberOfAwards;
                    }
                    else
                    {
                        maxOfGirls[i] = Int32.MaxValue;
                    }

                }
                string nameOfBoy = "no-one";
                if (Scout.ListOfScouts[Array.IndexOf(maxOfBoys, maxOfBoys.Max())].AwardsName.Count > 0)
                {
                    nameOfBoy = Scout.ListOfScouts[Array.IndexOf(maxOfBoys, maxOfBoys.Min())].Name;
                }
                string nameOfGirl = "no-one";
                if (Scout.ListOfScouts[Array.IndexOf(maxOfGirls, maxOfGirls.Max())].AwardsName.Count > 0)
                {
                    nameOfGirl = Scout.ListOfScouts[Array.IndexOf(maxOfGirls, maxOfGirls.Min())].Name;
                }
                Console.WriteLine("Меньше всего предметов среди парней: " + maxOfBoys.Max() + ". У " + nameOfBoy);
                Console.WriteLine("Меньше всего предметов среди девушек: " + maxOfGirls.Max() + ". У " + nameOfGirl);
            }
            Console.WriteLine("---------");
            //Средний бал за все награды у скаутов
            {
                for (int i = 0; i < Scout.ListOfScouts.Count; i++)
                {
                    Console.WriteLine(" - Nmae: " + Scout.ListOfScouts[i].Name + "; average score: " + Scout.ListOfScouts[i].AllScoreOfScout);
                }
            }
            Console.WriteLine("---------");
            Menu.MenuOrExit();

        }



        private static void MenuOrExit()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Press any key to exit");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(" OR ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("enter \"M\" to menu: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            string strFlag = Console.ReadLine();
            if (strFlag.ToLower() == "m")
            {
                Menu._showAgain = true;
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Clear();
                Menu.Show();
            }
        }
    }// end class Menu     console clear and show menu
}
