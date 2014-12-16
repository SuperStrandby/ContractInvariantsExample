using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvariantsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Johne", 10);
            
            Console.WriteLine("Name: {0}, Age: {1}", student.Name, student.Age);
        }
    }
}
