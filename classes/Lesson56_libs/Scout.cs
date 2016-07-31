using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goit.TerraSoft.HomeWork
{
    abstract class Scout
    {
        //static
        public static List<Scout> ListOfScout { get; protected set; }
        
        //this
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Sport> ListOfSport { get; protected set; }
        protected int _numberOfSports;
        protected int _allScoreOfSports;
        protected int _avarageScoreOfSports;
        public int NumSports { get { return _numberOfSports; } }
        public int AllScore { get { return _allScoreOfSports; } }
        public int AvarScore { get { return _avarageScoreOfSports; } }
        

        static Scout()
        {
            ListOfScout = new List<Scout>()
            {
                (new Boy() {Name="Patric", Age= 11}).AddSport("box",23,"good boy").AddSport("karate",35,"middle level").AddSport("shoot", 5,"do more"),
                (new Girl() {Name="Juliya", Age= 10}).AddSport("jump",50,"very good").AddSport("run",18,"good level"),
                (new Boy() {Name="JayZ", Age= 8}).AddSport("judo",23,"fine").AddSport(Boy.sport[3],35,"middle level").AddSport(Boy.sport[7], 42,"so good"),
                (new Girl() {Name="Veronica", Age= 14}).AddSport(Girl.sport[7],48,"good girl.").AddSport(Girl.sport[0],35,"middle level").AddSport(Girl.sport[6], 19,"not bad but do so more")
            };

            foreach(var item in ListOfScout)
            {
                item.Experience();
            }
            
        }
        public Scout()
        {
            this.ListOfSport = new List<Sport>();
        }
        public void Experience()
        {
            if (this.ListOfSport != null && this.ListOfSport.Count != 0)
            {
                foreach (var item in this.ListOfSport)
                {
                    _allScoreOfSports += item.Score;
                }
                _numberOfSports = this.ListOfSport.Count;
                _avarageScoreOfSports = _allScoreOfSports / _numberOfSports;
            }
            else
            {
                _allScoreOfSports = 0;
                _numberOfSports = -1;
                _avarageScoreOfSports = 0;

            }
        }
        public Scout AddSport(string nameSport, int scoreOfSport, string msgAward)
        {
            this.ListOfSport.Add(new Sport {
                Name = nameSport,
                Score = scoreOfSport,
                MsgAward = msgAward
            });
            return this;
        }
        public void DeleteSport(int idOfSport)
        {
            this.ListOfSport.RemoveAt(idOfSport);
        }
    }
}
