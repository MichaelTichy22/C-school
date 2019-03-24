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
            Count++;
            if (Count < capacity)
            {
                players[Count + 1] = player;
            }
            else
            {
                throw new IndexOutOfRangeException("List hráčů je plný!");
            }
        }

        public void FindTheBestClubs(FootballClub[] bestClubs,int numberOfGoals)
        {
            int[] goals = new int[6];
            foreach (Player player in players)
            {

            }
        }
    }
}
