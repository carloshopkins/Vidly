using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stuff
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new List<User>();
            users.Add(new User() { Name = "Alpha", IsActive = true, Height = 10 });
            users.Add(new User() { Name = "Bravo", IsActive = true, Height = 20 });
            users.Add(new User() { Name = "Charlie", IsActive = false, Height = 30 });
            users.Add(new User() { Name = "Delta", IsActive = false, Height = 90 });
            users.Add(new User() { Name = "Echo", IsActive = true, Height = 140 });
            //average height 58

            var users2 = users.Select(u => new { u.Name, IsTall = u.Height >= 20 }).ToList();

            users2.ForEach(u => Console.WriteLine($"{u.Name}: {u.IsTall}"));
        }

    }
}
//Linq is for using sets
//Linq does not offer performance improvments, but is used for readability.
