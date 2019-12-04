using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_2
{
    abstract class Figure
    {
        public string Type
        {
            get
            {
                return this._Type;
            }
            protected set
            {
                this._Type = value;
            }
        }
        string _Type;

        public abstract double Area();

        public override string ToString()
        {
            return this._Type + this.Area().ToString();
        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 8f91a9d8df73add73ff2ccdf65b4f6d0d88dd89a
