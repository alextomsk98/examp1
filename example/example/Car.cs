using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example
{
    class Car
    {
       
            public string petName;
            public int currSpeed;
            public void PrintState()
            {
                Console.WriteLine("{0} is going {1} MPN.", petName, currSpeed);
            }
            public void SpeedUp(int delta)
            {
                currSpeed += delta;
            }
        }
    }

