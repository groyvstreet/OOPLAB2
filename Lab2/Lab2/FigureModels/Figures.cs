using System.Collections;

namespace Lab2.FigureModels
{
    internal class Figures : IEnumerable<Figure>
    {
        public delegate void FiguresHandler();
        public event FiguresHandler Changed;
        private List<Figure> figures;

        public Figures()
        {
            Changed = delegate { };
            figures = new List<Figure>();
        }

        public void Add(Figure figure)
        {
            figures.Add(figure);
        }

        public void RemoveLast()
        {
            if (figures.Any())
            {
                figures.RemoveAt(figures.Count - 1);
            }
        }

        public void OnChanged()
        {
            Changed();
        }

        public IEnumerator<Figure> GetEnumerator()
        {
            return figures.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
