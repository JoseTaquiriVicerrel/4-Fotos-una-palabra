using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string  mensaje;
        public int lev;

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            if (lev == 9)
            {
                Application.Exit();
            }
        }
        public void mostrar(char[] arreglo)
        {
            label1.Text = "" + arreglo[0];
            label2.Text = "" + arreglo[1];
            label3.Text = "" + arreglo[2];
            label4.Text = "" + arreglo[3];
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            char[] arreglo = mensaje.ToCharArray();
            mostrar(arreglo);
            if (mensaje.Length==5)
            {
                label5.Visible = true;
                label1.Location = new Point(label1.Location.X - 20, label1.Location.Y);
                label2.Location = new Point(label2.Location.X - 20, label2.Location.Y);
                label3.Location = new Point(label3.Location.X - 20, label3.Location.Y);
                label4.Location = new Point(label4.Location.X - 20, label4.Location.Y);
                label5.Text = "" + arreglo[4];
            }
            if (mensaje.Length == 6)
            {
                label6.Visible = true;
                label5.Visible = true;
                label1.Location = new Point(label1.Location.X - 40, label1.Location.Y);
                label2.Location = new Point(label2.Location.X - 40, label2.Location.Y);
                label3.Location = new Point(label3.Location.X - 40, label3.Location.Y);
                label4.Location = new Point(label4.Location.X - 40, label4.Location.Y);
                label5.Location = new Point(label5.Location.X - 20, label5.Location.Y);
                label5.Text = "" + arreglo[4];
                label6.Text = "" + arreglo[5];
            }
            if (lev == 9)
            {
                label7.Visible = true;
                button1.Text = "Aceptar";
            }
            

        }
    }
}
