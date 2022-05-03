using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Figures
{
    internal class Ellipse : Figure
    {
        public override void Draw(Graphics graphics)
        {
            int width = EndPoint.X - BeginPoint.X;
            int height = EndPoint.Y - BeginPoint.Y;
            System.Drawing.Rectangle rectangle;

            if (width >= 0 && height >= 0)
            {
                rectangle = new System.Drawing.Rectangle(BeginPoint.X, BeginPoint.Y, width, height);
            }
            else if (width >= 0 && height < 0)
            {
                rectangle = new System.Drawing.Rectangle(BeginPoint.X, EndPoint.Y, width, Math.Abs(height));
            }
            else if (width < 0 && height >= 0)
            {
                rectangle = new System.Drawing.Rectangle(EndPoint.X, BeginPoint.Y, Math.Abs(width), height);
            }
            else
            {
                rectangle = new System.Drawing.Rectangle(EndPoint.X, EndPoint.Y, Math.Abs(width), Math.Abs(height));
            }

            graphics.FillEllipse(Brush, rectangle);
            graphics.DrawEllipse(Pen, rectangle);
        }
    }
}
