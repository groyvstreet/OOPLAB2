using Lab2.Commands;
using Lab2.FigureCreators;
using Lab2.FigureModels;

namespace Lab2
{
    public partial class Form1 : Form
    {
        Pen _pen;
        SolidBrush _brush;
        bool isDrawing;
        bool isBrushable;
        Point _point;
        List<Point> _points;
        FigureCreator _figureCreator;
        Figures _figures;
        CommandManager _manager;

        public Form1()
        {
            InitializeComponent();

            _pen = new Pen(Color.Black, 1);
            _brush = new SolidBrush(Color.White);

            isDrawing = false;
            isBrushable = false;

            _point = new Point(0, 0);
            _points = new List<Point>();

            _figureCreator = new LineCreator();
            _figures = new Figures();
            _manager = new CommandManager();

            manager_Changed();

            _figures.Changed += figures_Changed;
            _manager.Changed += manager_Changed;
        }

        private void figures_Changed()
        {
            pictureBox.Invalidate();
        }

        private void manager_Changed()
        {
            buttonUndo.Enabled = _manager.CanUndo;
            buttonUndoAll.Enabled = _manager.CanUndo;
            buttonRedo.Enabled = _manager.CanRedo;
            buttonRedoAll.Enabled = _manager.CanRedo;
        }

        private void buttonBrushColor_Click(object sender, EventArgs e)
        {
            if (penColorDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            _pen.Color = penColorDialog.Color;
            buttonPenColor.BackColor = penColorDialog.Color;
            pictureBox.Invalidate();
        }

        private void buttonFillColor_Click(object sender, EventArgs e)
        {
            if (brushColorDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            _brush.Color = brushColorDialog.Color;
            buttonBrushColor.BackColor = brushColorDialog.Color;
            pictureBox.Invalidate();
        }

        private void trackPenWidth_Scroll(object sender, EventArgs e)
        {
            _pen.Width = trackPenWidth.Value;
            pictureBox.Invalidate();
        }

        private void radioLine_CheckedChanged(object sender, EventArgs e)
        {
            _figureCreator = new LineCreator();
        }

        private void radioRectangle_CheckedChanged(object sender, EventArgs e)
        {
            _figureCreator = new RectangleCreator();
        }

        private void radioEllipse_CheckedChanged(object sender, EventArgs e)
        {
            _figureCreator = new EllipseCreator();
        }

        private void radioPolyline_CheckedChanged(object sender, EventArgs e)
        {
            _figureCreator = new PolylineCreator();
        }

        private void radioPolygon_CheckedChanged(object sender, EventArgs e)
        {
            _figureCreator = new PolygonCreator();
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                _point = e.Location;
                pictureBox.Invalidate();
            }
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            foreach (var figure in _figures)
            {
                figure.Draw(e.Graphics);
            }

            if (isDrawing)
            {
                _points.Add(_point);
                var figure = _figureCreator.Create();
                figure.Pen = _pen;

                if (isBrushable)
                {
                    figure.Brush = _brush;
                }

                figure.SetPoints(_points);
                figure.Draw(e.Graphics);
                _points.RemoveAt(_points.Count - 1);
            }
        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!isDrawing)
                {
                    isDrawing = true;
                    _points.Add(e.Location);
                }
                else
                {
                    isDrawing = false;
                    _points.Add(e.Location);
                    var figure = _figureCreator.Create();
                    figure.Pen.Color = _pen.Color;
                    figure.Pen.Width = _pen.Width;

                    if (isBrushable)
                    {
                        figure.Brush = new SolidBrush(_brush.Color);
                    }

                    figure.SetPoints(_points);

                    var command = new AddFigureCommand(_figures, figure);
                    _manager.Execute(command);

                    _points.Clear();
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (isDrawing)
                {
                    _points.Add(e.Location);
                }
            }
        }

        private void checkBoxBrush_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBrush.Checked)
            {
                isBrushable = true;
            }
            else
            {
                isBrushable = false;
            }

            pictureBox.Invalidate();
        }

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            _manager.Undo();
        }

        private void buttonRedo_Click(object sender, EventArgs e)
        {
            _manager.Redo();
        }

        private void buttonUndoAll_Click(object sender, EventArgs e)
        {
            _manager.UndoAll();
        }

        private void buttonRedoAll_Click(object sender, EventArgs e)
        {
            _manager.RedoAll();
        }
    }
}
