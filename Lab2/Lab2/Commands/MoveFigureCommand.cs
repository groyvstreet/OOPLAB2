using Lab2.FigureModels;

namespace Lab2.Commands
{
    internal class MoveFigureCommand : ICommand
    {
        private Figures figures;
        private Figure figure;
        private List<Point> points;
        private List<Point> prevPoints;

        public MoveFigureCommand(Figures figures, Figure figure, List<Point> points)
        {
            this.figures = figures;
            this.figure = figure;
            this.points = figure.points.ToList();
            prevPoints = new List<Point>();
            figure.SetPoints(points);
        }

        public void Execute()
        {
            prevPoints = figure.points.ToList();
            figure.SetPoints(points);
            figures.OnChanged();
        }

        public void UnExecute()
        {
            figure.SetPoints(prevPoints);
            figures.OnChanged();
        }
    }
}
