using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public void Borderedondoboton(Button b)
        {

            Rectangle r = new Rectangle(0, 0, b.Width, b.Height);

            GraphicsPath button = new GraphicsPath();
            int f = 10;
            button.AddArc(r.X, r.Y, f, f, 180, 80);
            button.AddArc(r.X + r.Width - f, r.Y, f, f, 270, 90);
            button.AddArc(r.X + r.Width - f, r.Y + r.Height - f, f, f, 0, 90);
            button.AddArc(r.X, r.Y + r.Height - f, f, f, 100, 90);
            b.Region = new Region(button);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            
            if (index >=0 && index<=2)
            {
                this.Hide();
                Form1 fr = new Form1();
                fr.cat = index;
                fr.Show();
            }
            else
            {
                MessageBox.Show(this, "selecione\n una categoria");
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Borderedondoboton(button1);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
    }
}
