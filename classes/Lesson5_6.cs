using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goit.TerraSoft.HomeWork
{
    class Lesson5_6
    {
        public static void Run()
        {
            Menu.Show();
            
        }
    }
    //Menu class
    static partial class Menu
    {
        private static string _content;
        private static string _strSelected;

        public static string SelectedPoint { get { return _strSelected; } }

        private static bool _showAgain = true;

        private static void RowsOfMenu()
        {
            StringBuilder content = new StringBuilder();
            content.Append("1. Add a new scout\n")
                   .Append("2. Add sport for scout\n")
                   .Append("3. Delete sport of scout\n")
                   .Append("4. List of all scouts\n")
                   .Append("5. List of all: {Name} - {Male/Female}\n")
                   .Append("6. List of boys: {Name}\n")
                   .Append("7. List of girls: {Name}\n")
                   .Append("8. Calculate -> ?\n")
                   .Append("9. EXIT\n");
            _content = content.ToString();
        }
        public static void Show()
        {
            while (Menu._showAgain)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Menu.RowsOfMenu();
                Console.WriteLine(Menu._content);
                Console.Write("Your action: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                _strSelected = Console.ReadLine();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Gray;
                Menu.CheckSelected();
            }
        }

        public static void CheckSelected()
        {
            switch (_strSelected)
            {
                case "1":
                    _showAgain = false;
                    Menu.AddScout();
                    break;
                case "2":
                    _showAgain = false;
                    Menu.AddSport();
                    break;
                case "3":
                    _showAgain = false;
                    Menu.DeleteSport();
                    break;
                case "4":
                    _showAgain = false;
                    Menu.AllList();
                    break;
                case "5":
                    _showAgain = false;
                    Menu.ListGender();
                    break;
                case "6":
                    _showAgain = false;
                    Menu.BoysList();
                    break;
                case "7":
                    _showAgain = false;
                    Menu.GirlsList(); break;
                case "8":
                    _showAgain = false;
                    Menu.Calculate(); break;
                case "9":
                    _showAgain = false;
                    break;
                default:
                    
                        Console.Write("You entered wrong point !!!  ");
                        Console.ReadLine();
                        Console.Clear();
                        break;
            }
        }

        
    }// end Menu class
}
