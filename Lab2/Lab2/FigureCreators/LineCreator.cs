using Lab2.FigureModels;

namespace Lab2.FigureCreators
{
    internal class LineCreator : FigureCreator
    {
        public override Figure Create()
        {
            return new Line();
        }
    }
}
