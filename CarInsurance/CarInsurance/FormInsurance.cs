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
    public partial class FormInsurance : Form
    {
        public FormInsurance()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormCar bf = new FormCar();
            bf.Show();
        }
    }
}
