using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Figures
{
    internal class Polyline : Figure
    {
        public List<Point> Points;

        public Polyline() : base()
        {
            Points = new List<Point>();
        }

        public override void Draw(Graphics graphics)
        {
            PointF[] points = new PointF[Points.Count + 2];
            points[0] = BeginPoint;

            for (int i = 1, j = 0; i < points.Length - 1; i++, j++)
            {
                points[i] = Points[j];
            }

            points[points.Length - 1] = EndPoint;
            graphics.DrawLines(Pen, points);
        }
    }
}
