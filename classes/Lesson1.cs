using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goit.TerraSoft.HomeWork
{
    class Lesson1
    {
        public static void Run()
        {
            Console.WriteLine("Перше завдання: \n\n");
            Part1();
            Console.Write("\nPress any key to see next part");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Друге завдання: \n");
            Part2();
        }
        private static void Part1()
        {
            //sample: Type byte: default value 0, min 0, max 255

            string strFormatNum = "Type {0,-14}: default value {1,5}, min {2,-32}, max {3}";
            string strFormatBoolChar = "Type {0,-14}: default value {1,5}";
            string[] resultStrs = {
                string.Format(strFormatNum,typeof(byte),default(byte),byte.MinValue,byte.MaxValue),
                string.Format(strFormatNum,typeof(byte),default(byte),byte.MinValue,byte.MaxValue),
                string.Format(strFormatNum,typeof(sbyte),default(sbyte),sbyte.MinValue,sbyte.MaxValue),
                string.Format(strFormatNum,typeof(short),default(short),short.MinValue,short.MaxValue),
                string.Format(strFormatNum,typeof(ushort),default(ushort),ushort.MinValue,ushort.MaxValue),
                string.Format(strFormatNum,typeof(int),default(int),int.MinValue,int.MaxValue),
                string.Format(strFormatNum,typeof(uint),default(uint),uint.MinValue,uint.MaxValue),
                string.Format(strFormatNum,typeof(long),default(long),long.MinValue,long.MaxValue),
                string.Format(strFormatNum,typeof(ulong),default(ulong),ulong.MinValue,ulong.MaxValue),
                string.Format(strFormatNum,typeof(decimal),default(decimal),decimal.MinValue,decimal.MaxValue),
                string.Format(strFormatNum,typeof(float),default(float),float.MinValue,float.MaxValue),
                string.Format(strFormatNum,typeof(double),default(double),double.MinValue,double.MaxValue),
                string.Format(strFormatBoolChar,typeof(bool),default(bool)),
                string.Format(strFormatBoolChar,typeof(char),default(char)),
            };
            foreach (string value in resultStrs)
            {
                Console.WriteLine(value);
            }

        }
        private static void Part2()
        {
            //sample: Char h: dec 104, hex 68
            Console.WriteLine(new String('-', 15));
            string strValue = "Hello world!";
            string strFormat = "Char {0,2}: dec {1,-3:G}, hex {1:X}";
            char[] charSet = strValue.ToCharArray();
            foreach (char value in charSet)
            {
                Console.WriteLine(string.Format(strFormat, value, (ushort)value));
            }
        }
    }
}
