using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadania
{
    internal class Circle : Shape
    {
        public Circle(double x, double y, double height, string name) : base(x, y, height, name)
        {
        }

        public override void Draw()
        {
            Console.WriteLine($"Rysuje {this.Name}, o wspolrzednych X: {this.X}" +
                $", Y = {this.Y}, promien: {this.Height}");
        }
    }
}
