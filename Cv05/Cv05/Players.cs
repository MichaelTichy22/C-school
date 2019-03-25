using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv05
{
    class Players
    {
        public Player[] players { get; set; }

        public Player this[int i]
        {
            get { return players[i]; }
            set { players[i] = value; }
        }

        private int capacity;

        private int count;

        public int Count { get; set; }

        public Players(int capacity)
        {
            this.capacity = capacity;
            players = new Player[capacity];
        }


        public void Remove(int index)
        {
            count--;
            this.players = this.players.Where((e, i) => i != index).ToArray();
        }

        public void Add(Player player)
        {
            
            if (Count < capacity)
            {
                players[Count] = player;
                Count++;
            }
            else
            {
                throw new IndexOutOfRangeException("List hráčů je plný!");
            }
        }

        public void FindTheBestClubs(List<FootballClub> bestClubs,out int numberOfGoals)
        {
            Dictionary<FootballClub, int> clubs = new Dictionary<FootballClub, int>();
            foreach (Enum clubEnum in Enum.GetValues(typeof(FootballClub)))
            {
                clubs.Add((FootballClub)clubEnum, 0);
            }
            foreach (Player player in players)
            {
                if (player != null)
                {
                    clubs[player.Club] += player.NumberOfGoals;
                }
                else
                {
                    break;
                }
            }
            int max = clubs.Values.Max();

            numberOfGoals = max;

            foreach (KeyValuePair<FootballClub, int> club in clubs)
            {
                if (club.Value.Equals(max))
                {
                    bestClubs.Add(club.Key);
                }
            }
            
        }
    }
}
