using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_2
{
    class Program

    {
        static void Main(string[] args)
        {
            Console.Title = "Саргсян Т.А. ИУ5-32Б";
            double a, b, c, d;
            Console.WriteLine("Введите длину и высоту прямоугольника");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            Rectangle rect = new Rectangle(a, b);
            rect.Print();
            Console.ReadKey();
            Console.WriteLine("Введите сторону квадрата");
            c = double.Parse(Console.ReadLine());
            Square square = new Square(c);
            square.Print();
            Console.ReadKey();
            Console.WriteLine("Введите радиус круга");
            d = double.Parse(Console.ReadLine());
            Circle circle = new Circle(d);
            circle.Print();
            Console.ReadKey();
            System.Environment.Exit(0);
            Console.ReadLine();
        }
    }
    // Интерфуйс IPrint
    interface IPrint
    {
        void Print();
    }


}
