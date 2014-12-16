using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvariantsExample
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(string name, int age)
        {
            Contract.Requires<ArgumentException>(name.Length >= 5);
            Contract.Requires<ArgumentException>(age >= 10);
            Name = name;
            Age = age;
        }
        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(Name.Length >= 5);
            Contract.Invariant(Age >= 10);
        }
    }
}
