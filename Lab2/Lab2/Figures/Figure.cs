using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Figures
{
    abstract class Figure
    {
        public Point BeginPoint { get; set; }
        public Point EndPoint { get; set; }
        public Pen Pen { get; set; }
        public SolidBrush Brush { get; set; }

        public Figure()
        {
            Pen = new Pen(Color.Black);
            Brush = new SolidBrush(Color.White);
        }

        abstract public void Draw(Graphics graphics);
    }
}
