namespace Lab2.FigureModels
{
    abstract class Figure
    {
        public Point[] points;
        public Pen Pen { get; set; }
        public SolidBrush? Brush { get; set; }

        public Figure()
        {
            points = Array.Empty<Point>();
            Pen = new Pen(Color.Black);
        }

        public abstract void SetPoints(List<Point> points);
        public abstract void Draw(Graphics graphics);

        public virtual void DrawFocus(Graphics graphics)
        {
            Pen pen = new(Pen.Color, Pen.Width);
            Pen.Color = Color.Gray;
            Pen.Width = 15;
            Draw(graphics);
            Pen.Color = pen.Color;
            Pen.Width = pen.Width;
        }

        public virtual bool InFigure(Point point)
        {
            foreach (var p in points)
            {
                if (Math.Abs(point.X - p.X) <= 10 && Math.Abs(point.Y - p.Y) <= 10)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
