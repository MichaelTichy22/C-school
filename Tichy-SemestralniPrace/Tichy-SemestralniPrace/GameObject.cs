using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tichy_SemestralniPrace
{
    abstract class GameObject
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int Size { get; set; }
        public PlayerColor Owner { get; set; }
        public bool isFinished { get; set; }

        public abstract void Refresh(int time);
    }
}
