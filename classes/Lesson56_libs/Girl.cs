using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goit.TerraSoft.HomeWork
{
    class Girl : Scout
    {
        public static readonly string[] sport;
        static Girl()
        {
            sport = new string[] {
                                   "run",
                                   "swim",
                                   "gymnastic",
                                   "finder",
                                   "shoot",
                                   "judo",
                                   "jump",
                                   "dance"
                                 };
        }
    }
}
