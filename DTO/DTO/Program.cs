using Stuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class Program
    {
        /*
        Def of DTOs very between devs
        Most consider them a state
        DTOs are complex data types
        Could be seen as a collection of primatives
        Once a DTO has a method it is no longer a DTO
        DTO is not a code concept, but more of a coder concept
        */
        static void Main(string[] args)
        {
            var animals = new List<Animal>();
            animals.Add(new Cat());
            animals.Add(new Doggo());
            animals.Add(new Birdo());
            animals.ForEach(a => a.Alert());

        }

    }
}
