using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Projekt
{
    public class Square : Shape
    {
        private int sideLength;

        public Square(Point startPoint, Color color) : base(startPoint, color)
        {
        }

        public override void UpdateSize(Point endPoint)
        {
            sideLength = Math.Max(Math.Abs(endPoint.X - startPoint.X), Math.Abs(endPoint.Y - startPoint.Y));
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawRectangle(pen, startPoint.X, startPoint.Y, sideLength, sideLength);
        }
    }
}
