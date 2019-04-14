using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tichy_SemestralniPrace
{
    class Planet : GameObject
    {
        const int BORDER_POINT_COUNT = 32;
        const double CONTACT_POINTS_CONST = 1.0;
        const double ORBIT_POINTS_CONST = 1.4;

        public int UnitCount { get; set; }
        public Point ContactPoint { get; }
        public Point OrbitPoint { get; }


        public override void Refresh(int time)
        {
            if (Owner == PlayerColor.GREY)
            {
                return;
            }

            if (UnitCount == BORDER_POINT_COUNT)
            {
                Size = Size * 3;
            }

            if (true)
            {

            }

        }

        public void ShipArrival(Spaceship spaceship)
        {
            if (spaceship.Owner == Owner)
            {
                UnitCount += spaceship.UnitsCount;
            }
            else
            {
                UnitCount -= spaceship.UnitsCount;
                if (UnitCount < 0)
                {
                    Owner = spaceship.Owner;
                }
            }
        }
    }
}
