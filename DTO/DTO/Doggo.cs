using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class Doggo : Animal
    {
        protected override void ExcecuteAlert()
        {
            Console.WriteLine("Woof");
        }
    }
}
