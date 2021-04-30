using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SupermarketBravo
{
    
    public partial class Form3 : Form
    {
        public Form3()
        {
            
            InitializeComponent();
        }


  

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ptbLaptop2_Click(object sender, EventArgs e)
        {

        }

        private void ptbAudifono_Click(object sender, EventArgs e)
        {

        }

        private void ptbLaptop1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
                    }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
        }


     

            private void cbxmenu_SelectedIndexChanged(object sender, EventArgs e)
        {
             


            int precio;
            switch(this.cbxmenu.SelectedIndex)
            {
                case 0:
                    precio = 100;
                    this.txtprecio.Text = precio.ToString();
                    break;

                case 1:
                    precio = 50;
                    this.txtprecio.Text = precio.ToString();
                    break;

                case 2:
                    precio = 200;
                    this.txtprecio.Text = precio.ToString();
                    break;

                default:
                    precio = 0;
                    this.txtprecio.Text = precio.ToString();
                    break;
                     


            }




        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            double subt, desc, tot, prec;
            int cant;

            cant = int.Parse(this.txtcantidad.Text);
            prec = double.Parse(this.txtprecio.Text);

            subt = cant * prec;

            switch (this.cbxmenu.SelectedIndex)
            {
                case 0:
                    desc = subt * 0.10;
                    break;

                default:
                    desc = subt * 0;
                    break;
            }

            tot = cant * prec;

            this.txtResultado.Text = tot.ToString();

     




        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
