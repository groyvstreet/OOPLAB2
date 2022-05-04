using Lab2.FigureModels;

namespace Lab2.FigureCreators
{
    internal class PolylineCreator : FigureCreator
    {
        public override Figure Create()
        {
            return new Polyline();
        }
    }
}
