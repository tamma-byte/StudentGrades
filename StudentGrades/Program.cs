using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Ashley Barty", "Business", 3.6);
            Student student2 = new Student("Venus Williams", "PE", 2.7);

            //ONLY SHOW Students that have Honours
            if(student1.HasHonours() == true)
            {
                Console.WriteLine(student1.name + " has honours.");
            }

            if (student2.HasHonours() == true)
            {
                Console.WriteLine(student2.name + " has honours.");
            }

            //Console.WriteLine(student1.name + " has honours: " +student1.HasHonours());
            //Console.WriteLine(student2.name + " has honours: " +student2.HasHonours());
            Console.ReadLine();
        }
    }
}
