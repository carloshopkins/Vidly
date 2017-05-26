using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class SlowAutomobile : ITestInt
    {
        public void Start()
        {
            Console.WriteLine("Starting slow");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping slow");
        }
    }
}
