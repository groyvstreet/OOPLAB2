using Lab2.FigureCreators;
using Lab2.FigureModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezoid
{
    internal class TrapezoidCreator : FigureCreator
    {
        public override Figure Create()
        {
            return new Trapezoid();
        }
    }
}
