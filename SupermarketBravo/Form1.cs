﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if (panel2.Width >= 1160)
                timer1.Stop();
            Form2 frm2 = new Form2();
         
            this.Hide();

        }
        
            
           //Form2 frm2 = new Form2();
            //frm2.Show();//
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
