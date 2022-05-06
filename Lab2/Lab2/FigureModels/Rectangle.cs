namespace Lab2.FigureModels
{
    [Serializable]
    internal class Rectangle : Figure
    {
        public override void SetPoints(List<Point> points)
        {
            this.points = new Point[2];
            this.points[0] = points[0];
            this.points[1] = points[^1];
        }

        public override void Draw(Graphics graphics)
        {
            int width = points[1].X - points[0].X;
            int height = points[1].Y - points[0].Y;
            System.Drawing.Rectangle rectangle;

            if (width >= 0 && height >= 0)
            {
                rectangle = new System.Drawing.Rectangle(points[0].X, points[0].Y, width, height);
            }
            else if(width >= 0 && height < 0)
            {
                rectangle = new System.Drawing.Rectangle(points[0].X, points[1].Y, width, Math.Abs(height));
            }
            else if (width < 0 && height >= 0)
            {
                rectangle = new System.Drawing.Rectangle(points[1].X, points[0].Y, Math.Abs(width), height);
            }
            else
            {
                rectangle = new System.Drawing.Rectangle(points[1].X, points[1].Y, Math.Abs(width), Math.Abs(height));
            }

            if (Brush)
            {
                graphics.FillRectangle(new SolidBrush(BrushColor), rectangle);
            }

            graphics.DrawRectangle(new Pen(PenColor, PenWidth), rectangle);
        }

        public override Figure Clone()
        {
            var figure = new Rectangle();
            figure.PenColor = PenColor;
            figure.PenWidth = PenWidth;
            figure.Brush = Brush;
            figure.BrushColor = BrushColor;
            figure.SetPoints(points.ToList());
            return figure;
        }
    }
}
