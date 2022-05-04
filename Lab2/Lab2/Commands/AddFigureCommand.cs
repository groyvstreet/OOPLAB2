using Lab2.FigureModels;

namespace Lab2.Commands
{
    internal class AddFigureCommand : ICommand
    {
        private Figures figures;
        private Figure figure;

        public AddFigureCommand(Figures figures, Figure figure)
        {
            this.figures = figures;
            this.figure = figure;
        }

        public void Execute()
        {
            figures.Add(figure);
        }

        public void UnExecute()
        {
            figures.RemoveLast();
        }
    }
}
