using Lab2.FigureModels;

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
