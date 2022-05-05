using System.Drawing.Drawing2D;

namespace Lab2.FigureModels
{
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

            if (Brush != null)
            {
                graphics.FillPath(Brush, path);
            }

            graphics.DrawLines(Pen, points);
        }

        public override Figure Clone()
        {
            var figure = new Polygon();
            figure.Pen.Color = Pen.Color;
            figure.Pen.Width = Pen.Width;

            if (Brush != null)
            {
                figure.Brush = new SolidBrush(Brush.Color);
            }

            figure.SetPoints(points.ToList());
            return figure;
        }
    }
}
