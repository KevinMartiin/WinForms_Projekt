using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Projekt
{
    public class Triangle : Shape
    {
        private Point[] points = new Point[3];

        public Triangle(Point startPoint, Color color) : base(startPoint, color)
        {
        }

        public override void UpdateSize(Point endPoint)
        {
            points[0] = startPoint;
            points[1] = new Point(startPoint.X + (endPoint.X - startPoint.X) / 2, endPoint.Y);
            points[2] = new Point(endPoint.X, startPoint.Y);
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawPolygon(pen, points);
        }
    }
}
