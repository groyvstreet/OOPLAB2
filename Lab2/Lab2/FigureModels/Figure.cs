namespace Lab2.FigureModels
{
    abstract class Figure
    {
        protected Point[] points;
        public Pen Pen { get; set; }
        public SolidBrush? Brush { get; set; }

        public Figure()
        {
            points = Array.Empty<Point>();
            Pen = new Pen(Color.Black);
        }

        abstract public void SetPoints(List<Point> points);
        abstract public void Draw(Graphics graphics);
    }
}
