using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Figures
{
    internal class Line : Figure
    {
        public override void Draw(Graphics graphics)
        {
            graphics.DrawLine(Pen, BeginPoint.X, BeginPoint.Y, EndPoint.X, EndPoint.Y);
        }
    }
}
