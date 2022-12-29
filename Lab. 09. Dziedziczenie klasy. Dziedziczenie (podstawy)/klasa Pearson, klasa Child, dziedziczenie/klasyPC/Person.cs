using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasyPC
{
    internal class Person
    {
        public Person(string familyName, string firstName, int age)
        {
            try
            {
                if(familyName != "asas")
                {
                    throw new ArgumentException();
                }
                else
                {

                }
            }
            catch(ArgumentException)
            {
                Console.WriteLine("Wrong Name!");
            }
        }
    }
}
