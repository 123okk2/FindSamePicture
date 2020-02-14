using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindSamePicture
{
    public partial class Ranking : Form
    {
        public Ranking(double[] ranks)
        {
            InitializeComponent();
            textBox1.Text = ranks[0].ToString();
            textBox2.Text = ranks[1].ToString();
            textBox3.Text = ranks[2].ToString();
            textBox4.Text = ranks[3].ToString();
            textBox5.Text = ranks[4].ToString();
        }
    }
}
