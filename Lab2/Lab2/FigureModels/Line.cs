namespace Lab2.FigureModels
{
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
            graphics.DrawLine(Pen, points[0].X, points[0].Y, points[1].X, points[1].Y);
        }

        public override Figure Clone()
        {
            var figure = new Line();
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
