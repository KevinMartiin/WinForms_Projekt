using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Projekt
{
    public class Circle : Shape
    {
        private int diameter;

        public Circle(Point startPoint, Color color) : base(startPoint, color)
        {
        }

        public override void UpdateSize(Point endPoint)
        {
            diameter = Math.Max(Math.Abs(endPoint.X - startPoint.X), Math.Abs(endPoint.Y - startPoint.Y));
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawEllipse(pen, startPoint.X - diameter / 2, startPoint.Y - diameter / 2, diameter, diameter);
        }
    }
}
