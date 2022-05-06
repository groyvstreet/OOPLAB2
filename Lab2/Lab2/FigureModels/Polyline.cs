namespace Lab2.FigureModels
{
    [Serializable]
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
            graphics.DrawLines(new Pen(PenColor, PenWidth), points);
        }

        public override Figure Clone()
        {
            var figure = new Polyline();
            figure.PenColor = PenColor;
            figure.PenWidth = PenWidth;
            figure.Brush = Brush;
            figure.BrushColor = BrushColor;
            figure.SetPoints(points.ToList());
            return figure;
        }
    }
}
