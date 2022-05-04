﻿using Lab2.FigureModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.FigureCreators
{
    internal class RectangleCreator : FigureCreator
    {
        public override Figure Create()
        {
            return new FigureModels.Rectangle();
        }
    }
}
