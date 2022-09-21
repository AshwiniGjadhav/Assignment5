using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Course
    {
       // class Course with course id , name, fees.create an array of courses & display the list

            public int Id{get;set;}
             public string Name { get;set;}

            public int Fees { get;set;}

            public override string ToString()
        {
            return $"Course Details: {Id} {Name} {Fees}";
        }

    }
}
