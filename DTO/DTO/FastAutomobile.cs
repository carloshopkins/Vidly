using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class FastAutomobile : ITestInt
    {
        public void Start()
        {
            Console.WriteLine("Starting fast");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping fast");
        }
        public void BreakDown()
        {
            Console.WriteLine("I'm stuck :(");
        }
    }
}
