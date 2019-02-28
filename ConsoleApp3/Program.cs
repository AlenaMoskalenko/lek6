using System;
namespace ConsoleApp1
{
    class Person : ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public object Clone()
        {
            return new Person { Name = this.Name, Age = this.Age };
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person { Name = "Tom", Age = 23 };
            Person p2 = (Person)p1.Clone();
            p2.Name = "Alice";
            Console.WriteLine(p1.Name); // Tom
            Console.WriteLine(p2.Name); // Alice
            Console.Read();
        }
    }
}
