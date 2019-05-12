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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Driver.Load = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!Driver.Load)
            {
                Driver driver = new Driver();
                driver.DriverName = new Name(textBox1.Text, textBox2.Text, textBox3.Text);
                driver.BirthTime = dateTimePicker1.Value;
                driver.DateStartDriving = dateTimePicker2.Value;
                if (textBox5.Text != "")
                    driver.DriversLicenceNum = Convert.ToInt32(textBox5.Text);
                Driver.ActiveDriver = driver;
                Xml.SaveUser();
            }
             this.Visible = false;
             FormCar nf = new FormCar();
             nf.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPF = new OpenFileDialog();
            OPF.Filter = "XML files(*.xml)|*.xml";
            OPF.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                Xml.LoadUser(OPF.FileName);
                textBox1.Text = Driver.ActiveDriver.DriverName.Surname;
                textBox2.Text = Driver.ActiveDriver.DriverName.Firstname;
                textBox3.Text = Driver.ActiveDriver.DriverName.Patronymic;
                dateTimePicker1.Value = Driver.ActiveDriver.BirthTime;
                textBox5.Text = Driver.ActiveDriver.DriversLicenceNum.ToString();
                Driver.Load = true;
            }
        }
    }
}
