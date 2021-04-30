using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketBravo
{
    public partial class Form2 : Form
    {
        Form3 Frm3 = new Form3();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnentrar_Click(object sender, EventArgs e)
        {

            this.Hide();
            Frm3.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
