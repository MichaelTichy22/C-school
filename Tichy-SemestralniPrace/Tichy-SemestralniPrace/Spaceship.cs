using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tichy_SemestralniPrace
{
    class Spaceship : GameObject
    {
        private Planet SourcePlanet { get; set; }
        private Planet DestinationPlanet { get; set; }
        private int UnitsCount { get; set; }
        private Point Path { get; set; }

        public override void Refresh(int time)
        {
            throw new NotImplementedException();
        }
    }
}
