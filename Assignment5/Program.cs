using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course[] course =
            {
           new Course {Id= 1, Name = "MCA", Fees = 340000 },
            new Course  { Id = 2,Name = "BBA",Fees = 25000},
         new Course  { Id = 4,Name = "BCA",Fees = 45000},
            };

            foreach (Course c in course) 
            {
                Console.WriteLine(c);
            }

        }
    }
}
