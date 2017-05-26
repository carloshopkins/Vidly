using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    abstract class Animal : IAnimal
    {
        protected abstract void ExcecuteAlert();
        public void Alert()
        {
            Console.WriteLine("Taking a deep breath...");
            ExcecuteAlert();
        }

    }
}
