using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goit.TerraSoft.HomeWork
{
    class Scout
    {
        public static List<Scout> ListOfScouts;

        public string Name { get;  set; }
        public int Age { get;  set; }
        public string Gender { set; get; }
        protected List<string> _listOfAwards = new List<string>();
        protected List<int> _scoreOfAwards = new List<int>();
        //public int ScoreOfExperience { get; set; }

        public List<string> AwardsName { get { return _listOfAwards; } }
        public List<int> AwardsScore { get { return _scoreOfAwards; } }

        protected int _numberOfAwards;
        protected int _allScoreOfAwards;
        protected int _avarageScoreOfAwards;

        public int AvarageScoreOfScout { get { return _avarageScoreOfAwards; } }
        public int AllScoreOfScout { get { return _allScoreOfAwards; } }
        public int NumberOfAwards { get { return _numberOfAwards; } }


        static Scout()
        {

            ListOfScouts = new List<Scout>() {

                
               // new Girl(){ Name = "Veronika", Age = 6, Gender = "female" , FemaleSport = ""},
                //new Girl(){ Name = "Kelly", Age = 12, Gender = "female", FemaleSport = "" },
                
                //new Boy(){ Name = "Nelly", Age = 10, Gender = "male" , MaleSport = ""},
               // new Boy(){ Name = "JayZ", Age = 11, Gender = "male" , MaleSport = ""}

            };


            
        }

        public void AddAward(string nameOfAward,int scoreOfAward )
        {
            this._listOfAwards.Add(nameOfAward);
            this._scoreOfAwards.Add(scoreOfAward);

            _numberOfAwards = _scoreOfAwards.Count;
            foreach (int item in _scoreOfAwards)
            {
                _allScoreOfAwards += item;
            }
            _avarageScoreOfAwards = _allScoreOfAwards / _numberOfAwards;
        } 
    }

    class Boy : Scout
    {
        public static string[] sport = new string[] { "box", "bjj", "wrestling", "bike", "shoot" };
        private string _maleSport = "male kind of sport";

        public string MaleSport {
            get { return _maleSport; }
            set
            {
                
                foreach (var item in Girl.sport)
                {
                    if (value == item) { _maleSport = value; break; }
                }
            }
        }
        
    }
    class Girl : Scout
    {
        public static string[] sport = new string[] { "swim", "run", "jump", "box", "shoot" };

        private string _femaleSport = "female kind of sport";

        public string FemaleSport
        {
            get { return _femaleSport; }
            set
            {
                
                foreach (var item in Girl.sport)
                {
                    if (value == item) { _femaleSport = value; break; }  
                }
            }
        }
        
    }

}
