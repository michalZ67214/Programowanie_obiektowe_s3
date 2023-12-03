using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadania
{
    internal class Rectangle : Shape
    {
        public Rectangle(double x, double y, double height, double width, string name) : base(x, y, height, width, name)
        {
        }

        public override void Draw()
        {
            Console.WriteLine($"Rysuje {this.Name}, o wspolrzednych X: {this.X}" +
                $", Y = {this.Y}, wysokosc: {this.Height}, szerokosc: {this.Width}");
        }
    }
}
