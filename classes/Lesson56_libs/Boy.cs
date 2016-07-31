using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goit.TerraSoft.HomeWork
{
    class Boy : Scout
    {
        public static readonly string[] sport; 
        static Boy()
        {
            sport = new string[] {
                                   "box",
                                   "bjj",
                                   "wrestling",
                                   "bike",
                                   "shoot",
                                   "karate",
                                   "judo",
                                   "kanoe"
                                 };
        }
    }
}
