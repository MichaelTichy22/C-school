using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv05
{
    class Player
    {
        public string Name { get; set; }
        public FootballClub Club { get; set; }
        public int NumberOfGoals { get; set; }

        public Player(string name, FootballClub club, int numberOfGoals)
        {
            Name = name;
            Club = club;
            NumberOfGoals = numberOfGoals;
        }
    }
}
