using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Projekt
{
    public abstract class Shape
    {
        protected Pen pen;
        protected Brush brush;
        protected Point startPoint;

        public Shape(Point startPoint, Color color)
        {
            this.startPoint = startPoint;
            pen = new Pen(color);
            brush = new SolidBrush(color);
        }

        public abstract void UpdateSize(Point endPoint);

        public abstract void Draw(Graphics graphics);
    }
}
