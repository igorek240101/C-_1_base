using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Book
{
    public partial class Form1 : Form
    {
        string now;

        bool isRead = true;

        List<UserControl1> booksbutton = new List<UserControl1>();
        public Form1()
        {
            InitializeComponent();
            RefreshBook();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isRead)
            {
                textBox1.Text = label1.Text;
                label1.Visible = false;
                textBox1.Visible = true;
            }
            else
            {
                FileStream file = new FileStream(now + ".txt", FileMode.Open);
                StreamWriter writer = new StreamWriter(file);
                writer.Write(textBox1.Text);
                writer.Close();
                file.Close();
                label1.Text = textBox1.Text;
                label1.Visible = true;
                textBox1.Visible = false;
            }
            isRead = !isRead;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
        }

        private void splitContainer1_Panel2_Resize(object sender, EventArgs e)
        {
            textBox1.Size = new Size(splitContainer1.Panel2.Width - 100, splitContainer1.Panel2.Height - 100);
        }

        private void splitContainer1_Panel1_Resize(object sender, EventArgs e)
        {
            splitContainer1.Panel1.AutoScroll = false;
            for (int i = 0; i < booksbutton.Count; i++)
            {
                booksbutton[i].Size = new Size(splitContainer1.Panel1.Width - 20, 50);
            }
            splitContainer1.Panel1.AutoScroll = true;
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CreateForm(this).Show();
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshBook();
        }

        public void RefreshBook()
        {
            splitContainer1.Panel1.Controls.Clear();
            booksbutton.Clear();
            List<string> books = Directory.GetFiles(Directory.GetCurrentDirectory()).ToList();
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].IndexOf(".txt") == books[i].Length - 4)
                {
                    string[] s = books[i].Split('\\');
                    books[i] = s[s.Length - 1];
                    books[i] = books[i].Remove(books[i].Length - 4, 4);
                    booksbutton.Add(new UserControl1());
                    splitContainer1.Panel1.Controls.Add(booksbutton[booksbutton.Count - 1]);
                    booksbutton[booksbutton.Count - 1].Size = new Size(splitContainer1.Panel1.Width - 20, 50);
                    booksbutton[booksbutton.Count - 1].Location = new Point(0, (booksbutton.Count - 1) * 60);
                    booksbutton[booksbutton.Count - 1].button1.Text = books[i];
                    booksbutton[booksbutton.Count - 1].BookLoad += new EventHandler(bookLoad);
                    booksbutton[booksbutton.Count - 1].BookDel += new EventHandler(bookDelete);
                }
            }
        }

        public void bookLoad(object sender, EventArgs e)
        {
            UserControl1 button = sender as UserControl1;
            FileStream file = new FileStream(button.button1.Text + ".txt", FileMode.Open);
            StreamReader reader = new StreamReader(file);
            label1.Text = reader.ReadToEnd();
            reader.Close();
            file.Close();
            label1.Visible = true;
            button1.Visible = true;
            textBox1.Visible = false;
            now = button.button1.Text;
        }

        public void bookDelete(object sender, EventArgs e)
        {
            UserControl1 button = sender as UserControl1;
            File.Delete(button.button1.Text + ".txt");
            booksbutton.Remove(button);
            label1.Visible = false;
            button1.Visible = false;
            textBox1.Visible = false;
            now = null;
            RefreshBook();
        }
    }
}
