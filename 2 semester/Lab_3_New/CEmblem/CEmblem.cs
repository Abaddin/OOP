using System.Drawing;
using System.Windows.Forms;

namespace CEmblem
{
    class CEmblem
    {
        Color color { get; set; }
        public Color currentColor { get; set; }
        public int size { get; set; }
        int x { get; set; }
        int y { get; set; }
        string name { get; set; }
        Pen pen = new Pen(Color.Red, 1f);

        public CEmblem(int x, int y, int size, string name, Color color)
        {
            this.x = x;
            this.y = y;
            this.size = size;
            this.name = name;
            this.color = color;
            currentColor = color;
        }

        public override string ToString()
        {
            return name;
        }

        public void Draw(PictureBox pictureBox)
        {
            pen.Color = currentColor;
            using (var g = Graphics.FromImage(pictureBox.Image))
            {
                g.DrawEllipse(pen, x, y, size, size);
                g.DrawEllipse(pen, x + size / 4, y + size / 4, size / 2, size / 2);
                Point[] points = new Point[3];
                points[0].X = x + size / 2;
                points[0].Y = y + size;
                points[1].X = x + size / 15;
                points[1].Y = y + size / 4;
                points[2].X = x + size - (size / 15);
                points[2].Y = y + size / 4;
                g.DrawPolygon(pen, points);
                g.RotateTransform(45);
                pictureBox.Refresh();
            }
        }

        public void Rotate()
        {
        }

        public void MoveRight()
        {
            if (x != 737 - size)
            {
                x++;
            }
        }

        public void MoveLeft()
        {
            if (x != 0)
            {
                x--;
            }
        }

        public void MoveUp()
        {
            if (y != 0)
            {
                y--;
            }
        }

        public void MoveDown()
        {
            if (y != 560 - size)
            {
                y++;
            }
        }

        public void EndUp()
        {
            y = 0;
        }

        public void EndDown()
        {
            y = 560 - size;
        }

        public void EndLeft()
        {
            x = 0;
        }

        public void EndRight()
        {
            x = 737 - size;
        }

        public void Enlarge()
        {
            size++;
        }

        public void Reduce()
        {
            if (size > 0)
            {
                size--;
            }
        }

        public void Hide()
        {
            currentColor = Color.White;
        }

        public void Show()
        {
            currentColor = color;
        }
    }
}