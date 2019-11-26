using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Retangulo r = new Retangulo();

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            r.Altura = textBox2.Text;
            r.Largura = textBox1.Text;
            if (radioButton1.Checked) label1.Text = r.Area;
            else if (radioButton2.Checked) label1.Text = r.Perimetro;
            else if (radioButton3.Checked) label1.Text = r.Diagonal;

        }
    }
}
