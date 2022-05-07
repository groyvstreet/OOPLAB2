using Lab2.PluginBase;

namespace Trapezoid
{
    public class Plugin : IPlugin
    {
        public string Name
        {
            get
            {
                return "Трапеция";
            }
        }

        public void Run(IHost host)
        {
            var radioTrapezoid = new RadioButton
            {
                Text = "Трапеция",
                AutoSize = true,
                Cursor = Cursors.Hand,
                Location = new Point(3, 183),
                Name = "radioTrapezoid"
            };
            host.AddControl(radioTrapezoid, new TrapezoidCreator());
        }
    }
}
