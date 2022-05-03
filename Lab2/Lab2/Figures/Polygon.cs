using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Figures
{
    internal class Polygon : Figure
    {
        public List<Point> Points;

        public Polygon() : base()
        {
            Points = new List<Point>();
        }

        public override void Draw(Graphics graphics)
        {
            GraphicsPath path = new GraphicsPath(FillMode.Winding);
            PointF[] points = new PointF[Points.Count + 3];
            points[0] = BeginPoint;

            for (int i = 1, j = 0; i < points.Length - 2; i++, j++)
            {
                points[i] = Points[j];
            }

            points[points.Length - 2] = EndPoint;
            points[points.Length - 1] = BeginPoint;
            path.AddLines(points);
            graphics.FillPath(Brush, path);
            graphics.DrawLines(Pen, points);
        }
    }
}
