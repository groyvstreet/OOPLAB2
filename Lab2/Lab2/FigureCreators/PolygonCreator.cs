using Lab2.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.FigureCreators
{
    internal class PolygonCreator : FigureCreator
    {
        public override Figure Create()
        {
            return new Polygon();
        }
    }
}
