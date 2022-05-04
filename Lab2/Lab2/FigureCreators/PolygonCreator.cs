using Lab2.FigureModels;

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
