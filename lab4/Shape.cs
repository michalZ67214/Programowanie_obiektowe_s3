using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadania
{
    internal class Shape
    {
        // wlasciwosci(zawsze sa public) pola
        public double X { get; set; }
        public double Y { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public string Name { get; set; }

        public Shape(double x, double y, double height, double width, string name)
        {
            X = x;
            Y = y;
            Height = height;
            Width = width;
            Name = name;
        }

        public Shape(double x, double y, double height, string name)
        {
            X = x;
            Y = y;
            Height = height;
            Name = name;
        }

        public virtual void Draw() { }
    }
}
