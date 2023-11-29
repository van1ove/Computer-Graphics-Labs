using System;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace Last
{
    public partial class Form1 : Form
    {

        private Image<Bgr, byte> image; // Пустая картинка
        private int gridSize = 20; // Размер одной ячейки сетки
        private float scale = 1.0f; // Масштаб
        private Stopwatch stopwatch ;
        private Graphics g;
        private bool clearClicked;
        private bool drawBres, drawStep;

        private int _brX1, _brX2, _brY1, _brY2;
        private int _stX1, _stX2, _stY1, _stY2;
        public Form1()
        {
            InitializeComponent();
            image = new Image<Bgr, byte>(pictureBox.Width, pictureBox.Height);
            stopwatch = new Stopwatch();
            clearClicked = true;
            drawBres = false;
            drawStep = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            pictureBox.Paint += pictureBox_Paint;
            pictureBox.Resize += pictureBox_Resize;
            pictureBox.MouseWheel += pictureBox_MouseWheel;
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;

            int pictureBoxWidth = pictureBox.Width;
            int pictureBoxHeight = pictureBox.Height;

            DrawAxies(pictureBoxWidth, pictureBoxHeight, g);

            if (clearClicked) return;
            
            if (drawBres)
            {
                BresWithTime(pictureBoxWidth, pictureBoxHeight, g);
                drawBres = false;
            }
            else
            {
                Bres(pictureBoxWidth, pictureBoxHeight, g);
            }

            if (drawStep)
            {
                StepWithTime(pictureBoxWidth, pictureBoxHeight, g);
                drawStep = false;
            }
            else
            {
                Step(pictureBoxWidth, pictureBoxHeight, g);
            }
            
        }

        private void pictureBox_Resize(object sender, EventArgs e)
        {
            // Обновление размеров пустой картинки при изменении размеров PictureBox
            image = new Image<Bgr, byte>(pictureBox.Width, pictureBox.Height);

            pictureBox.Invalidate();
        }

        private void pictureBox_MouseWheel(object sender, MouseEventArgs e)
        {
            // Изменение масштаба при прокрутке колеса мыши
            const float scaleStep = 0.2f;
            const float minScale = 0.4f;
            const float maxScale = 10f;

            if (e.Delta > 0 && scale <= maxScale)
            {
                scale += scaleStep;
            }
            else if (e.Delta < 0 && scale >= minScale)
            {
                scale -= scaleStep;
            }

            pictureBox.Invalidate();
        }

        private void DrawAxies(int pictureBoxWidth, int pictureBoxHeight, Graphics g)
        {
            // Рисование сетки
            for (int x = pictureBoxWidth / 2; x <= pictureBoxWidth; x += (int)(gridSize * scale))
            {
                g.DrawLine(Pens.LightGray, x, 0, x, pictureBoxHeight);
            }

            for (int x = pictureBoxWidth / 2; x >= 0; x -= (int)(gridSize * scale))
            {
                g.DrawLine(Pens.LightGray, x, 0, x, pictureBoxHeight);
            }

            for (int y = pictureBoxHeight / 2; y <= pictureBoxHeight; y += (int)(gridSize * scale))
            {
                g.DrawLine(Pens.LightGray, 0, y, pictureBoxWidth, y);
            }

            for (int y = pictureBoxHeight / 2; y >= 0; y -= (int)(gridSize * scale))
            {
                g.DrawLine(Pens.LightGray, 0, y, pictureBoxWidth, y);
            }

            // Рисование координатных осей
            g.DrawLine(Pens.Black, pictureBoxWidth / 2, 0, pictureBoxWidth / 2, pictureBoxHeight); // Вертикальная ось
            g.DrawLine(Pens.Black, 0, pictureBoxHeight / 2, pictureBoxWidth, pictureBoxHeight / 2); // Горизонтальная ось

            // Draw X and Y axis labels
            Font labelFont = new Font("Arial", 10);
            Brush labelBrush = Brushes.Black;
            g.DrawString("X", labelFont, labelBrush, pictureBoxWidth - 20, pictureBoxHeight / 2 - 20);
            g.DrawString("Y", labelFont, labelBrush, pictureBoxWidth / 2 + 10, 10);
        }

        private void Bres(int pictureBoxWidth, int pictureBoxHeight, Graphics g)
        {
            // Масштабирование координат линии
            int scaledX1 = (int)(_brX1 * gridSize * scale) + pictureBoxWidth / 2;
            int scaledY1 = pictureBoxHeight / 2 - (int)(_brY1 * gridSize * scale);
            int scaledX2 = (int)(_brX2 * gridSize * scale) + pictureBoxWidth / 2;
            int scaledY2 = pictureBoxHeight / 2 - (int)(_brY2 * gridSize * scale);

            // Вычисление разницы между координатами
            int dx = Math.Abs(scaledX2 - scaledX1);
            int dy = Math.Abs(scaledY2 - scaledY1);

            // Определение направления изменения координат
            int sx = scaledX1 < scaledX2 ? 1 : -1;
            int sy = scaledY1 < scaledY2 ? 1 : -1;

            // Определение приращений инициализирующих ошибку
            int err = dx - dy;

            // Заполнение клеток сетки на линии
            SolidBrush fillBrush = new SolidBrush(Color.CornflowerBlue);
            int cellSize = (int)(gridSize * scale);
            int currentX = scaledX1;
            int currentY = scaledY1;

            // Предварительные вычисления
            int halfPictureBoxWidth = pictureBoxWidth >> 1; // Деление на 2 с помощью битового сдвига
            int halfPictureBoxHeight = pictureBoxHeight >> 1; // Деление на 2 с помощью битового сдвига
            while (true)
            {
                // Вычисление индексов клеток
                int cellX = (currentX - halfPictureBoxWidth) / cellSize;
                int cellY = (halfPictureBoxHeight - currentY) / cellSize;

                // Закрашивание клетки
                int cellLeft = halfPictureBoxWidth + cellX * cellSize;
                int cellTop = halfPictureBoxHeight - cellY * cellSize;
                g.FillRectangle(fillBrush, cellLeft, cellTop, cellSize, cellSize);

                if (currentX == scaledX2 && currentY == scaledY2)
                    break;

                int err2 = err << 1; // Умножение на 2 с помощью битового сдвига

                if (err2 > -dy)
                {
                    err -= dy;
                    currentX += sx;
                }

                if (err2 < dx)
                {
                    err += dx;
                    currentY += sy;
                }
            }
        }

        private void Step(int pictureBoxWidth, int pictureBoxHeight, Graphics g)
        {
            // Масштабирование координат линии
            float scaledX1 = _stX1 * gridSize * scale + pictureBoxWidth / 2;
            float scaledY1 = pictureBoxHeight / 2 - _stY1 * gridSize * scale;
            float scaledX2 = _stX2 * gridSize * scale + pictureBoxWidth / 2;
            float scaledY2 = pictureBoxHeight / 2 - _stY2 * gridSize * scale;

            // Определение шага изменения координат
            float dx = scaledX2 - scaledX1;
            float dy = scaledY2 - scaledY1;
            float step = Math.Max(Math.Abs(dx), Math.Abs(dy));

            // Определение приращений координат
            float xIncrement = dx / step;
            float yIncrement = dy / step;

            // Заполнение клеток сетки на линии
            SolidBrush fillBrush = new SolidBrush(Color.DarkMagenta);
            for (float i = 0; i <= step; i++)
            {
                // Вычисление индексов клеток
                int cellX = (int)Math.Round((scaledX1 + i * xIncrement - pictureBoxWidth / 2) / (gridSize * scale));
                int cellY = (int)Math.Round((pictureBoxHeight / 2 - (scaledY1 + i * yIncrement)) / (gridSize * scale));

                // Закрашивание клетки
                float cellLeft = pictureBoxWidth / 2 + cellX * gridSize * scale;
                float cellTop = pictureBoxHeight / 2 - cellY * gridSize * scale;
                g.FillRectangle(fillBrush, cellLeft, cellTop, gridSize * scale, gridSize * scale);
            }
        }

        private void BresWithTime(int pictureBoxWidth, int pictureBoxHeight, Graphics g)
        {
            // Масштабирование координат линии
            int scaledX1 = (int)(_brX1 * gridSize * scale) + pictureBoxWidth / 2;
            int scaledY1 = pictureBoxHeight / 2 - (int)(_brY1 * gridSize * scale);
            int scaledX2 = (int)(_brX2 * gridSize * scale) + pictureBoxWidth / 2;
            int scaledY2 = pictureBoxHeight / 2 - (int)(_brY2 * gridSize * scale);

            // Вычисление разницы между координатами
            int dx = Math.Abs(scaledX2 - scaledX1);
            int dy = Math.Abs(scaledY2 - scaledY1);

            // Определение направления изменения координат
            int sx = scaledX1 < scaledX2 ? 1 : -1;
            int sy = scaledY1 < scaledY2 ? 1 : -1;

            // Определение приращений инициализирующих ошибку
            int err = dx - dy;

            // Заполнение клеток сетки на линии
            SolidBrush fillBrush = new SolidBrush(Color.CornflowerBlue);
            int cellSize = (int)(gridSize * scale);
            int currentX = scaledX1;
            int currentY = scaledY1;

            // Предварительные вычисления
            int halfPictureBoxWidth = pictureBoxWidth >> 1; // Деление на 2 с помощью битового сдвига
            int halfPictureBoxHeight = pictureBoxHeight >> 1; // Деление на 2 с помощью битового сдвига

            stopwatch.Reset();
            stopwatch.Start();
            while (true)
            {
                // Вычисление индексов клеток
                int cellX = (currentX - halfPictureBoxWidth) / cellSize;
                int cellY = (halfPictureBoxHeight - currentY) / cellSize;

                // Закрашивание клетки
                int cellLeft = halfPictureBoxWidth + cellX * cellSize;
                int cellTop = halfPictureBoxHeight - cellY * cellSize;
                g.FillRectangle(fillBrush, cellLeft, cellTop, cellSize, cellSize);

                if (currentX == scaledX2 && currentY == scaledY2)
                    break;

                int err2 = err << 1; // Умножение на 2 с помощью битового сдвига

                if (err2 > -dy)
                {
                    err -= dy;
                    currentX += sx;
                }

                if (err2 < dx)
                {
                    err += dx;
                    currentY += sy;
                }
            }
            stopwatch.Stop();
            bresTime.Text = stopwatch.Elapsed.ToString();
        }

        private void StepWithTime(int pictureBoxWidth, int pictureBoxHeight, Graphics g)
        {
            stopwatch.Reset();
            stopwatch.Start();
            // Масштабирование координат линии
            float scaledX1 = _stX1 * gridSize * scale + pictureBoxWidth / 2;
            float scaledY1 = pictureBoxHeight / 2 - _stY1 * gridSize * scale;
            float scaledX2 = _stX2 * gridSize * scale + pictureBoxWidth / 2;
            float scaledY2 = pictureBoxHeight / 2 - _stY2 * gridSize * scale;
            
            // Определение шага изменения координат
            float dx = scaledX2 - scaledX1;
            float dy = scaledY2 - scaledY1;
            float step = Math.Max(Math.Abs(dx), Math.Abs(dy));

            // Определение приращений координат
            float xIncrement = dx / step;
            float yIncrement = dy / step;

            // Заполнение клеток сетки на линии
            SolidBrush fillBrush = new SolidBrush(Color.DarkMagenta);
            for (float i = 0; i <= step; i++)
            {
                // Вычисление индексов клеток
                int cellX = (int)Math.Round((scaledX1 + i * xIncrement - pictureBoxWidth / 2) / (gridSize * scale));
                int cellY = (int)Math.Round((pictureBoxHeight / 2 - (scaledY1 + i * yIncrement)) / (gridSize * scale));

                // Закрашивание клетки
                float cellLeft = pictureBoxWidth / 2 + cellX * gridSize * scale;
                float cellTop = pictureBoxHeight / 2 - cellY * gridSize * scale;
                g.FillRectangle(fillBrush, cellLeft, cellTop, gridSize * scale, gridSize * scale);
            }

            stopwatch.Stop();
            stepTime.Text = stopwatch.Elapsed.ToString();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            clearClicked = true;
            pictureBox.Invalidate();
        }

        private void Draw_Click(object sender, EventArgs e)
        {
            if (int.TryParse(brX1.Text, out _brX1) && int.TryParse(brX2.Text, out _brX2) &&
                int.TryParse(brY1.Text, out _brY1) && int.TryParse(brY2.Text, out _brY2))
            {
                drawBres = true;
            }

            if (int.TryParse(stX1.Text, out _stX1) && int.TryParse(stX2.Text, out _stX2) &&
                int.TryParse(stY1.Text, out _stY1) && int.TryParse(stY2.Text, out _stY2))
            {
                drawStep = true;
            }

            clearClicked = false;
            scale = 1;
            pictureBox.Invalidate();
        }
    }
}