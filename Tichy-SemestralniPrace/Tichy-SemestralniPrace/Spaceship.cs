using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tichy_SemestralniPrace
{
    class Spaceship : GameObject
    {
        public Planet SourcePlanet { get; set; }
        public Planet DestinationPlanet { get; set; }
        public int UnitsCount { get; set; }
        public Point Path { get; set; }
        public int DistanceTraveled { get; set; }

        public int PositionX { get => Path.X + DistanceTraveled; set => PositionX = value; }
        public int PositionY { get => Path.Y + DistanceTraveled; set => PositionY = value; }

        public override void Refresh(int time)
        {
            DistanceTraveled = time / 8;
            if (PositionX == DestinationPlanet.PositionX && PositionY == DestinationPlanet.PositionY)
            {
                DestinationPlanet.ShipArrival(this);
            }
        }

        


    }
}
