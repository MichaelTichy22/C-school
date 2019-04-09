using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tichy_SemestralniPrace
{
    class Planet : GameObject
    {
        public int UnitCount { get; set; }

        const int BORDER_POINT_COUNT = 32;
        const double CONTACT_POINTS_CONST = 1.0;
        const double ORBIT_POINTS_CONST = 1.4;

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

        }
    }
}
