namespace Lab2.FigureModels
{
    [Serializable]
    abstract class Figure
    {
        public Point[] points = Array.Empty<Point>();
        public Color PenColor { get; set; }
        public float PenWidth { get; set; }
        public Color BrushColor { get; set; }
        public bool Brush { get; set; }
        //public Pen Pen { get; set; }
        //public SolidBrush? Brush { get; set; }

        /*public Figure()
        {
            points = Array.Empty<Point>();
            //Pen = new Pen(Color.Black);
        }*/

        public abstract void SetPoints(List<Point> points);
        public abstract void Draw(Graphics graphics);
        public abstract Figure Clone();

        public virtual void DrawFocus(Graphics graphics)
        {
            Pen pen = new(PenColor, PenWidth);
            PenColor = Color.Gray;
            PenWidth = 15;
            Draw(graphics);
            PenColor = pen.Color;
            PenWidth = pen.Width;
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
