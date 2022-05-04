using Lab2.FigureModels;

namespace Lab2.FigureCreators
{
    internal class EllipseCreator : FigureCreator
    {
        public override Figure Create()
        {
            return new Ellipse();
        }
    }
}
