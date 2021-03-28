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
    public partial class CreateForm : Form
    {
        Form1 parrent;

        public CreateForm()
        {
            InitializeComponent();
        }

        public CreateForm(Form1 parrent)
        {
            InitializeComponent();
            this.parrent = parrent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream file = new FileStream(textBox1.Text + ".txt", FileMode.CreateNew);
            file.Close();
            parrent.RefreshBook();
            Close();
        }
    }
}
