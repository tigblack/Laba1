using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_2
{
    // Класс прямоугольник
    class Rectangle : Figure, IPrint
    {
        double height;
        double width;

        public Rectangle(double hg, double wd)
        {
            this.height = hg;
            this.width = wd;
            this.Type = "Площадь прямоугольника = ";
        }

        public override double Area()
        {
            double result = this.height * this.width;
            return result;
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}