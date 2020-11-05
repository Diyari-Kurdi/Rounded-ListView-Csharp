using Rounded_ListView;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace winform
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private void btnChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\Users\" + Environment.UserName + @"\Pictures\";
            ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            ofd.Title = "Image";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox.ImageLocation = ofd.FileName;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            RoundedListView roundedListView = new RoundedListView();
            roundedListView.BackColor = Color.Transparent;
            roundedListView.LineColor = lColor.BackColor;
            roundedListView.PanelColor = pColor.BackColor;
            roundedListView.ItemImage = pictureBox.Image;
            roundedListView.ItemCategory = txtCategory.Text;
            roundedListView.ItemName = txtName.Text;
            fLPanel.Controls.Add(roundedListView);
            fLPanel.AutoScroll = false;
            fLPanel.HorizontalScroll.Enabled = false;
            fLPanel.AutoScroll = true;
        }

        private void btnLColor_Click(object sender, EventArgs e)
        {
            if (CD.ShowDialog() == DialogResult.OK)
            {
                lColor.BackColor = CD.Color;
            }
        }

        private void btnPColor_Click(object sender, EventArgs e)
        {
            if (CD.ShowDialog() == DialogResult.OK)
            {
                pColor.BackColor = CD.Color;
            }
        }
    }
}
