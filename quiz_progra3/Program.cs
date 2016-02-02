using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_progra3
{
    public class Person
    {
        public string name;

        public Person()
        {
            name = "unknown";
        }
        public Person(string nm)
        {
            name = nm;
        }
        public void Setname(string newName)
        {
            name = newName;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Person person1 = new Person();
            Console.WriteLine(person1.name);

            person1.Setname("Adrian Zúñiga Zamora");
            Console.WriteLine(person1.name);

            Person person2 = new Person("Alejandra Ramirez");
            Console.WriteLine(person2.name);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
