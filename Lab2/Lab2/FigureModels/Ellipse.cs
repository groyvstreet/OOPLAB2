namespace Lab2.FigureModels
{
    internal class Ellipse : Figure
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
            else if (width >= 0 && height < 0)
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

            if (Brush != null)
            {
                graphics.FillEllipse(Brush, rectangle);
            }

            graphics.DrawEllipse(Pen, rectangle);
        }

        public override Figure Clone()
        {
            var figure = new Ellipse();
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
