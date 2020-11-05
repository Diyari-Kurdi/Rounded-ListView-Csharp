//Source : https://github.com/Diyari-Kurdi
//OSA
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Rounded_ListView
{
    public partial class RoundedListView : UserControl
    {
        private Color LColor = Color.Black;
        private Color PColor = Color.White;
        public Color LineColor 
        {
            get { return LColor; }
            set { LColor = value; }
        }
        public Color PanelColor
        {
            get { return PColor; }
            set { PColor = value; }
        }
        public Color CategoryForeColor
        {
            get { return lblCategory.ForeColor; }
            set { lblCategory.ForeColor = value; }
        }
        public Color NameForeColor
        {
            get { return lblName.ForeColor; }
            set { lblName.ForeColor = value; }
        }
        public string ItemCategory
        {
            get { return lblCategory.Text; }
            set { lblCategory.Text = value; }
        }
        public string ItemName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        public Image ItemImage 
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }
        public PictureBoxSizeMode ItemSizeMode
        {
            get { return pictureBox1.SizeMode; }
            set { pictureBox1.SizeMode = value; }
        }
        public RoundedListView()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;//243, 156, 18
            g.FillRoundedRectangle(new SolidBrush(LColor), 0, 0, 280, 100, 20);
            SolidBrush brush = new SolidBrush(PColor);
            g.FillRoundedRectangle(brush, 2, 2, 280, 100, 20);
        }
    }
}
