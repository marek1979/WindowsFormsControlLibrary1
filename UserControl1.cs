using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary1
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
             Button b = sender as Button;             
             Point p = new Point(b.Top, b.Left);
             MessageBox.Show(b.Text + "pozycja -x:" + b.Top + " y:" + b.Left);
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Enter(object sender, EventArgs e)
        {
            Button Przycisk = sender as Button;
            MessageBox.Show("jestem" + Przycisk.Text);
        }

        private void Button1_MouseDown(object sender, MouseEventArgs e)
        {
          //  Button b = sender as Button;
          //  Point p = new Point(b.Top, b.Left);
        }

        private void Button1_MouseUp(object sender, MouseEventArgs e)
        {
           Button b = sender as Button;
            Point nowy_point = PointToClient(Cursor.Position);
          //  Point p = new Point(b.Top, b.Left);
            b.Left = nowy_point.X;
            b.Top = nowy_point.Y;

        }

        private void UserControl1_Load_1(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            Button b = sender as Button;
          
        }

        bool mouseDown = false;

        private void volumeGrabBT_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDown = true;
            }
        }

        private void volumeGrabBT_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDown = false;
            }
        }

        private void volumeGrabBT_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Button b = sender as Button;
                Point volumeBTPoint = new Point();
                volumeBTPoint.X = Cursor.Position.X;
                volumeBTPoint.Y = b.Location.Y;
                b.Location = volumeBTPoint;
            }
        }
    }
}
