using Lab2.FigureCreators;
using Lab2.Figures;

namespace Lab2
{
    public partial class Form1 : Form
    {
        Point _beginPoint;
        Point _endPoint;
        Pen _pen;
        SolidBrush _brush;
        FigureCreator _figureCreator;
        bool isDrawing;
        List<Figure> _figures;
        List<Point> _points;

        public Form1()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            _beginPoint = new Point(0, 0);
            _endPoint = new Point(0, 0);
            _pen = new Pen(Color.Black, 1);
            _brush = new SolidBrush(Color.White);
            _figureCreator = new LineCreator();
            isDrawing = false;
            _figures = new List<Figure>();
            _points = new List<Point>();
        }

        private void buttonBrushColor_Click(object sender, EventArgs e)
        {
            if (penColorDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            _pen.Color = penColorDialog.Color;
            buttonPenColor.BackColor = penColorDialog.Color;
        }

        private void buttonFillColor_Click(object sender, EventArgs e)
        {
            if (brushColorDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            _brush.Color = brushColorDialog.Color;
            buttonBrushColor.BackColor = brushColorDialog.Color;
        }

        private void trackPenWidth_Scroll(object sender, EventArgs e)
        {
            _pen.Width = trackPenWidth.Value;
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
                _endPoint = e.Location;
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
                var figure = _figureCreator.Create();
                figure.BeginPoint = _beginPoint;
                figure.EndPoint = _endPoint;
                figure.Pen = _pen;
                figure.Brush = _brush;

                if (figure is Polyline)
                {
                    Polyline polyline = (Polyline)figure;

                    foreach (var point in _points)
                    {
                        polyline.Points.Add(point);
                    }
                }

                if (figure is Polygon)
                {
                    Polygon polyline = (Polygon)figure;

                    foreach (var point in _points)
                    {
                        polyline.Points.Add(point);
                    }
                }

                figure.Draw(e.Graphics);
            }
        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!isDrawing)
                {
                    isDrawing = true;
                    _beginPoint = e.Location;
                }
                else
                {
                    isDrawing = false;
                    _endPoint = e.Location;
                    var figure = _figureCreator.Create();
                    figure.BeginPoint = _beginPoint;
                    figure.EndPoint = _endPoint;
                    figure.Pen.Color = _pen.Color;
                    figure.Pen.Width = _pen.Width;
                    figure.Brush.Color = _brush.Color;

                    if (figure is Polyline)
                    {
                        Polyline polyline = (Polyline)figure;

                        foreach (var point in _points)
                        {
                            polyline.Points.Add(point);
                        }
                    }

                    if (figure is Polygon)
                    {
                        Polygon polyline = (Polygon)figure;

                        foreach (var point in _points)
                        {
                            polyline.Points.Add(point);
                        }
                    }

                    _figures.Add(figure);
                    _points.Clear();
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (isDrawing && (radioPolyline.Checked || radioPolygon.Checked))
                {
                    _points.Add(e.Location);
                }
            }
        }
    }
}
