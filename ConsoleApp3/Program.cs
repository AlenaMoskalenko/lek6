using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    interface IGeometrical // объявление интерфейса
    {
        void GetPerimeter();
        void GetArea();
    }
    class Rectangle : IGeometrical //реализация интерфейса
    {
        public void GetPerimeter()
        {
            Console.WriteLine("Rectangle GetPerimeter (a+b)*2");
        }

        public void GetArea()
        {
            Console.WriteLine("Rectangle GetArea a*b");
        }
    }
    class Circle : IGeometrical //реализация интерфейса
    {

        public void GetPerimeter()
        {
            Console.WriteLine("Circle GetPerimeter 2*pi*r");
        }

        public void GetArea()
        {
            Console.WriteLine("Circle GetArea pi*r^2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<IGeometrical> figures = new List<IGeometrical>();
            figures.Add(new Rectangle());
            figures.Add(new Circle());
            foreach (IGeometrical f in figures)
            {
                f.GetPerimeter();
                f.GetArea();
            }
            Console.ReadLine();
        }
    }
}
