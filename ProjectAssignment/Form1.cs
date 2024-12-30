using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAssignment
{
    public partial class Form1 : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public Form1()
        {
            InitializeComponent();
            container(new CreateGifForm());
        }

        private void guna2Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void guna2Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point newCursorPoint = Cursor.Position;
                int deltaX = newCursorPoint.X - dragCursorPoint.X;
                int deltaY = newCursorPoint.Y - dragCursorPoint.Y;
                this.Location = new Point(dragFormPoint.X + deltaX, dragFormPoint.Y + deltaY);
            }
        }

        private void guna2Panel2_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CreateGifbtn_Click(object sender, EventArgs e)
        {
            container(new CreateGifForm());
        }
        private void container(object _form)
        {
            if (guna2Panel_container.Controls.Count > 0)
            {
                guna2Panel_container.Controls.Clear();
            }

            Form fm = _form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            guna2Panel_container.Controls.Add(fm);
            fm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
