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
        public int UnitCount { get; set; }

        const int BORDER_POINT_COUNT = 32;
        const Point CONTACT_POINTS_CONST = 1.0;
        const Point ORBIT_POINTS_CONST = 1.4;

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

        }
    }
}
