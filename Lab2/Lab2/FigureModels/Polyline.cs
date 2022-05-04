using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.FigureModels
{
    internal class Polyline : Figure
    {
        public override void SetPoints(List<Point> points)
        {
            this.points = new Point[points.Count];

            for (int i = 0; i < this.points.Length; i++)
            {
                this.points[i] = points[i];
            }
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawLines(Pen, points);
        }
    }
}
