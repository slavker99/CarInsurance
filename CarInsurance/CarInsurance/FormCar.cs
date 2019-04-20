using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarInsurance
{
    public partial class FormCar : Form
    {
        public FormCar()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 bf = new Form1();
            bf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormInsurance nf = new FormInsurance();
            nf.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
