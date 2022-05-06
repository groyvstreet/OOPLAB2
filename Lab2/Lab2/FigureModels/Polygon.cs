using System.Drawing.Drawing2D;

namespace Lab2.FigureModels
{
    [Serializable]
    internal class Polygon : Figure
    {
        public override void SetPoints(List<Point> points)
        {
            this.points = new Point[points.Count + 1];

            for (int i = 0; i < this.points.Length - 1; i++)
            {
                this.points[i] = points[i];
            }

            this.points[^1] = points[0];
        }

        public override void Draw(Graphics graphics)
        {
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
            var figure = new Polygon();
            figure.PenColor = PenColor;
            figure.PenWidth = PenWidth;
            figure.Brush = Brush;
            figure.BrushColor = BrushColor;
            figure.SetPoints(points.ToList());
            return figure;
        }
    }
}
