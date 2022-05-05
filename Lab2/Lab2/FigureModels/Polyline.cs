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

        public override Figure Clone()
        {
            var figure = new Polyline();
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
