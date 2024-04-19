using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Projekt
{
    public class PenTool : Shape
    {
        private List<Point> points = new List<Point>();

        public PenTool(Point startPoint, Color color) : base(startPoint, color)
        {
            points.Add(startPoint);
        }

        public override void UpdateSize(Point endPoint)
        {
            points.Add(endPoint);
        }

        public override void Draw(Graphics graphics)
        {
            if (points.Count > 1)
            {
                graphics.DrawLines(pen, points.ToArray());
            }
        }
    }
}
