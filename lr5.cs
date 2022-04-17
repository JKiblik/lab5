using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                Button btn = new Button();
                btn.Text = "btn" + i;
                btn.Location = new Point(i * 25, i * 25);
                label2.Controls.Add(btn);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                TextBox txtBox = new TextBox();
                txtBox.Text = "txtBox" + i;
                txtBox.Location = new Point(i * 25, i * 25);
                label3.Controls.Add(txtBox);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                Label lbl = new Label();
                lbl.Text = "lbl" + i;
                lbl.Location = new Point(i * 25, i * 25);
                label1.Controls.Add(lbl);
            }
        }
    }
}
