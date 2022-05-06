namespace Lab2.FigureModels
{
    [Serializable]
    internal class Line : Figure
    {
        public override void SetPoints(List<Point> points)
        {
            this.points = new Point[2];
            this.points[0] = points[0];
            this.points[1] = points[^1];
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawLine(new Pen(PenColor, PenWidth), points[0].X, points[0].Y, points[1].X, points[1].Y);
        }

        public override Figure Clone()
        {
            var figure = new Line();
            figure.PenColor = PenColor;
            figure.PenWidth = PenWidth;
            figure.Brush = Brush;
            figure.BrushColor = BrushColor;
            figure.SetPoints(points.ToList());
            return figure;
        }
    }
}
