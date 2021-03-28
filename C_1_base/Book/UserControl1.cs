using System;
using System.Drawing;
using System.Windows.Forms;

namespace Book
{
    public partial class UserControl1 : UserControl
    {
        public event EventHandler BookLoad;
        public event EventHandler BookDel;
        public UserControl1()
        {
            InitializeComponent();
        }

        public UserControl1(Form1 parrent)
        {
            InitializeComponent();
            button1.Click += new EventHandler(parrent.bookLoad);
        }

        public void ResizeEvent(object sender, EventArgs e)
        {
            button1.Size = new Size(Width - 70, 50);
            button2.Location = new Point(Width - 50, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookLoad.Invoke(this, new EventArgs());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BookDel.Invoke(this, new EventArgs());
        }
    }
}
