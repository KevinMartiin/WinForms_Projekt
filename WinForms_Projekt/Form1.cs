using System.Windows.Forms;

namespace WinForms_Projekt
{
    public partial class Form1 : Form
    {
        private enum ShapeType { Circle, Square, Triangle, Pen }

        private ShapeType selectedShape = ShapeType.Circle;
        private Color selectedColor = Color.Black;
        private List<Shape> shapes = new List<Shape>();
        private Shape currentShape = null;
        private Point startPoint;
        public Form1()
        {
            InitializeComponent();
        }

        private void panelCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = e.Location;

            switch (selectedShape)
            {
                case ShapeType.Circle:
                    currentShape = new Circle(startPoint, selectedColor);
                    break;
                case ShapeType.Square:
                    currentShape = new Square(startPoint, selectedColor);
                    break;
                case ShapeType.Triangle:
                    currentShape = new Triangle(startPoint, selectedColor);
                    break;
                case ShapeType.Pen:
                    currentShape = new PenTool(startPoint, selectedColor);
                    break;
            }
        }

        private void panelCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && currentShape != null)
            {
                currentShape.UpdateSize(e.Location);
                panelCanvas.Invalidate();
            }
        }

        private void panelCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (currentShape != null)
            {
                shapes.Add(currentShape);
                currentShape = null;
            }
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            selectedShape = ShapeType.Circle;
        }

        private void panelCanvas_Paint(object sender, PaintEventArgs e)
        {
            foreach (var shape in shapes)
            {
                shape.Draw(e.Graphics);
            }

            if (currentShape != null)
            {
                currentShape.Draw(e.Graphics);
            }
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            selectedShape = ShapeType.Square;
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            selectedShape = ShapeType.Triangle;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            shapes.Clear();
            panelCanvas.Invalidate();
            panelCanvas.BackgroundImage = null;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                selectedColor = colorDialog.Color;
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (shapes.Count > 0)
            {
                shapes.RemoveAt(shapes.Count - 1);
                panelCanvas.Invalidate();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PNG Files (*.png)|*.png|JPEG Files (*.jpg)|*.jpg|BMP Files (*.bmp)|*.bmp";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bitmap = new Bitmap(panelCanvas.Width, panelCanvas.Height);
                    panelCanvas.DrawToBitmap(bitmap, new Rectangle(0, 0, panelCanvas.Width, panelCanvas.Height));
                    bitmap.Save(saveFileDialog.FileName);
                }
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.png;*.jpg;*.bmp)|*.png;*.jpg;*.bmp|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bitmap = new Bitmap(openFileDialog.FileName);
                    panelCanvas.BackgroundImage = bitmap;
                }
            }
        }

        private void btnPen_Click(object sender, EventArgs e)
        {
            selectedShape = ShapeType.Pen;
        }
    }
}