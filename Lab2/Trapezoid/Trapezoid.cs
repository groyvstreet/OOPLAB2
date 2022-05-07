using Lab2.FigureModels;
using System.Drawing.Drawing2D;

namespace Trapezoid
{
    internal class Trapezoid : Figure
    {
        public override void SetPoints(List<Point> points)
        {
            this.points = new Point[3];
            this.points[0] = points[0];
            this.points[1] = points[^2];
            this.points[2] = new Point(points[^1].X, this.points[1].Y);
        }

        public override void Draw(Graphics graphics)
        {
            Point[] points = new Point[5];
            points[0] = this.points[0];
            points[1] = this.points[1];
            points[2] = this.points[2];
            
            if (Math.Abs(points[2].X - points[0].X) <= Math.Abs(points[1].X - points[0].X))
            {
                points[2] = points[1];
            }

            points[3] = new Point(points[2].X + points[1].X - points[0].X, points[0].Y);
            points[4] = points[0];
            GraphicsPath path = new(FillMode.Winding);
            path.AddLines(points);

            if (Brush)
            {
                graphics.FillPath(new SolidBrush(BrushColor), path);
            }

            graphics.DrawLines(new Pen(PenColor, PenWidth), points);
        }

        public override Figure Clone()
        {
            var figure = new Trapezoid();
            figure.PenColor = PenColor;
            figure.PenWidth = PenWidth;
            figure.Brush = Brush;
            figure.BrushColor = BrushColor;
            figure.SetPoints(points.ToList());
            return figure;
        }
    }
}
