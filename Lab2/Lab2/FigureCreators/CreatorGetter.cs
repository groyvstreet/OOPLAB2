using Lab2.FigureModels;

namespace Lab2.FigureCreators
{
    internal class CreatorGetter
    {
        public FigureCreator Get(object _object)
        {
            if(_object is Line)
            {
                return new LineCreator();
            }

            if (_object is FigureModels.Rectangle)
            {
                return new RectangleCreator();
            }

            if (_object is Ellipse)
            {
                return new EllipseCreator();
            }

            if (_object is Polyline)
            {
                return new PolylineCreator();
            }

            if (_object is Polygon)
            {
                return new PolygonCreator();
            }

            throw new Exception("Impregnable object type");
        }
    }
}
