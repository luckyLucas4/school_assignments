using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Game_bax
{
    class SpelMall
    {
        public PictureBox pictureBox = new PictureBox();


        public SpelMall(Form motherForm, Image image, Rectangle rect)
        {
            pictureBox.BackColor = Color.Transparent;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Left = rect.X;
            pictureBox.Top = rect.Y;

            if(rect.Width > 0)
                pictureBox.Width = rect.Width;
            if(rect.Height > 0)
                pictureBox.Height = rect.Height;

            pictureBox.Image = image;
            motherForm.Controls.Add(pictureBox);
        }

        public void Move(int speed, char axis)
        {
            if (axis == 'y')
                pictureBox.Top += speed;
            else if (axis == 'x')
                pictureBox.Left += speed;
        }
    }
}

