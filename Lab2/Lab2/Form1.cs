using Lab2.Commands;
using Lab2.FigureCreators;
using Lab2.FigureModels;
using Newtonsoft.Json;
using System.Text;

namespace Lab2
{
    public partial class Form1 : Form
    {
        Pen _pen = new Pen(Color.Black, 1);
        SolidBrush _brush = new SolidBrush(Color.White);
        bool isDrawing = false;
        bool isBrushable = false;
        bool isSelecting = false;
        bool isDragging = false;
        bool Dragged = false;
        Point _point;
        List<Point> _points = new List<Point>();
        Figure? _selectedFigure;
        FigureCreator _figureCreator = new LineCreator();
        Figures _figures = new Figures();
        CommandManager _manager = new CommandManager();

        public Form1()
        {
            InitializeComponent();

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

            if (e.Button == MouseButtons.Left && _selectedFigure != null && isDragging)
            {
                for (int i = 0; i < _selectedFigure.points.Length; i++)
                {
                    _selectedFigure.points[i] = new Point(_points[i].X + e.Location.X - _point.X, _points[i].Y + e.Location.Y - _point.Y);
                }

                Dragged = true;
                pictureBox.Invalidate();
            }
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (_selectedFigure != null && _figures.Contains(_selectedFigure))
            {
                _selectedFigure.DrawFocus(e.Graphics);
            }

            foreach (var figure in _figures)
            {
                figure.Draw(e.Graphics);
            }

            if (isDrawing)
            {
                _points.Add(_point);
                var figure = _figureCreator.Create();
                figure.PenColor = _pen.Color;
                figure.PenWidth = _pen.Width;

                if (isBrushable)
                {
                    figure.Brush = true;
                    figure.BrushColor = _brush.Color;
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
                if (!isSelecting)
                {
                    if (!isDrawing)
                    {
                        _points.Clear();
                        _points.Add(e.Location);
                        isDrawing = true;
                    }
                    else
                    {
                        _points.Add(e.Location);
                        var figure = _figureCreator.Create();
                        figure.PenColor = _pen.Color;
                        figure.PenWidth = _pen.Width;

                        if (isBrushable)
                        {
                            figure.Brush = true;
                            figure.BrushColor = _brush.Color;
                        }

                        figure.SetPoints(_points);

                        var command = new AddFigureCommand(_figures, figure);
                        _manager.Execute(command);

                        _points.Clear();
                        isDrawing = false;
                    }
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
            isBrushable = checkBoxBrush.Checked;
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

        private void radioSelect_CheckedChanged(object sender, EventArgs e)
        {
            isSelecting = radioSelect.Checked;

            if (!isSelecting)
            {
                _selectedFigure = null;
                buttonCopyFigure.Enabled = false;
                pictureBox.Invalidate();
            }
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (_selectedFigure != null && _selectedFigure.InFigure(e.Location))
                {
                    _point = e.Location;
                    _points = _selectedFigure.points.ToList();
                    isDragging = true;
                    return;
                }

                if (isSelecting)
                {
                    _selectedFigure = null;
                    buttonCopyFigure.Enabled = false;

                    foreach (var figure in _figures.Reverse())
                    {
                        if (figure.InFigure(e.Location))
                        {
                            _selectedFigure = figure;
                            buttonCopyFigure.Enabled = true;
                        }
                    }

                    pictureBox.Invalidate();
                }
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (_selectedFigure != null && Dragged && _point != e.Location)
                {
                    var command = new MoveFigureCommand(_figures, _selectedFigure, _points);
                    _manager.Execute(command);

                    _points.Clear();
                    isDragging = false;
                    Dragged = false;
                }
            }
        }

        private void buttonCopyFigure_Click(object sender, EventArgs e)
        {
            if (_selectedFigure != null)
            {
                var figure = _selectedFigure.Clone();
                var points = _selectedFigure.points.ToList();

                for (int i = 0; i < points.Count; i++)
                {
                    points[i] = new Point(points[i].X + 20, points[i].Y + 20);
                }

                figure.SetPoints(points);

                var command = new AddFigureCommand(_figures, figure);
                _manager.Execute(command);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (saveDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            string filename = saveDialog.FileName;

            using (StreamWriter stream = File.CreateText(filename))
            {
                JsonSerializerSettings settings = new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.All,
                    Formatting = Formatting.Indented 
                };
                JsonSerializer serializer = JsonSerializer.Create(settings);

                if (_selectedFigure != null)
                {
                    var list = new List<Figure> { _selectedFigure };
                    serializer.Serialize(stream, list);
                }
                else
                {
                    serializer.Serialize(stream, _figures.ToList());
                }
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (openDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            string filename = openDialog.FileName;

            using (FileStream stream = File.OpenRead(filename))
            {
                JsonSerializerSettings settings = new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.All,
                    Formatting = Formatting.Indented
                };
                byte[] array = new byte[stream.Length];
                stream.Read(array, 0, array.Length);
                string json = Encoding.Default.GetString(array);
                var figures = JsonConvert.DeserializeObject<List<Figure>>(json, settings);

                if (figures != null)
                {
                    foreach (var figure in figures)
                    {
                        var command = new AddFigureCommand(_figures, figure);
                        _manager.Execute(command);
                    }
                }
            }
        }
    }
}
