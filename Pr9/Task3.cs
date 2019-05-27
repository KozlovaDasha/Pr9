using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr9
{
    
    class Task3
    {
        delegate double MyDelegate(double rad);

        private static MyDelegate someActions;

        static void Main()
        {
            AnotherClass someObj = new AnotherClass();

            someActions += someObj.GetS;
            someActions += someObj.GetLength;
            someActions += someObj.GetV;

            someActions(10.32);

            Console.ReadLine();
        }
    }

    class AnotherClass
    {
        public double GetS(double rad)
        {
            double square = Math.PI * Math.Pow(rad, 2);
            Console.WriteLine($"The square is {square}");
            return square;
        }

        public double GetLength(double rad)
        {
            double length = 2 * Math.PI * rad;
            Console.WriteLine($"The length is {length}");
            return length;
        }

        public double GetV(double rad)
        {
            double volume = 4 / 3 * Math.PI * Math.Pow(rad, 3);
            Console.WriteLine($"The volume is {volume}");
            return volume;
        }
    }
}
