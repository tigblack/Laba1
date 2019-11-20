using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_2
{
    // Класс квадрат
    class Square : Rectangle
    {

        public Square(double length) : base(length, length) { }
        public override string ToString()
        {
            return "Площадь квадрата =  " + Area().ToString();
        }

    }
}