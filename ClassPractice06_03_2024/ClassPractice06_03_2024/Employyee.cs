using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice06_03_2024
{
    internal class Employyee
    {
        public int Id { get; set; }
        public int Age { get; set; }



        public static bool operator > (Employyee emp1, Employyee emp2)
        {
            return emp1.Age > emp2.Age;
        }

        public static bool operator < (Employyee emp1, Employyee emp2)
        {
            return emp1.Age < emp2.Age;
        }

    }
}
