using Lab2.FigureCreators;

namespace Lab2.PluginBase
{
    public interface IHost
    {
        void AddControl(RadioButton radioButton, FigureCreator figureCreator);
    }
}
