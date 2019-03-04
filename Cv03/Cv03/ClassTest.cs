using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv03
{

    internal class MyInteger
    {
        public uint Value {
            get
            {
                return Value;
            }
            set
            {
                Value = value;
            }
        }

        private int value2;

        public int Value2
        {
            get { return (int)value2; }
            set
            {
                if (value > 1000000)
                    throw new ArgumentOutOfRangeException("Value cannot be higher than 1000000");
                //Minus = value < 0;
                value2 = value2;
            }
        }

        public bool Signed { get; private set; }

        public MyInteger()
        {
        }

        public MyInteger(uint value, bool signed)
        {
            Value = value;
            Signed = signed;
        }

        public static implicit operator MyInteger(int v)
        {
            return new MyInteger() { Value = (uint)Math.Abs(v), Signed = v < 0};
        }
    }
    class ClassTest
    {
        public static void DoIt()
        {
            MyInteger myInteger = new MyInteger() { Value = 33 };
            MyInteger myInteger2 = new MyInteger(33, true);

            MyInteger myInteger3 = 125;
        }
    }
}
