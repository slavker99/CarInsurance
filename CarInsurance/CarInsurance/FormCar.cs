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
            button2.Enabled = false;
            label12.Text = Driver.ActiveDriver.DriverName.Surname + " " + Driver.ActiveDriver.DriverName.Firstname + " " + Driver.ActiveDriver.DriverName.Patronymic;
            if (Driver.ActiveDriver.Cars != null)
            {
                for (int i = 0; i < Driver.ActiveDriver.Cars.Count; i++)
                    comboBox1.Items.Add(Driver.ActiveDriver.Cars[i].CarName);
                button2.Enabled = true;
            }
            Car.Load = false;

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
            if (!Car.Load)
            {
                Car car = new Car();
                if (radioButton1.Enabled)
                    car.CarCategory = CarType.B;
                else if (radioButton2.Enabled)
                    car.CarCategory = CarType.C;
                else car.CarCategory = CarType.D;
                car.CarName = textBox2.Text;
                car.VIN = maskedTextBox2.Text;
                car.CarNumber = maskedTextBox1.Text;
                if (maskedTextBox3.Text != "")
                    car.YearofRelease = Convert.ToInt32(maskedTextBox3.Text);
                if (maskedTextBox4.Text != "")
                    car.PowerEngine = Convert.ToDouble(maskedTextBox4.Text);
                Car.ActiveCar = car;
            }
            this.Visible = false;
            FormInsurance nf = new FormInsurance();
            nf.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Car.Load = true;
            for (int i = 0; i < Driver.ActiveDriver.Cars.Count; i++)
                if (Driver.ActiveDriver.Cars[i].CarName == comboBox1.Text)
                    Car.ActiveCar = Driver.ActiveDriver.Cars[i];
            if (Car.ActiveCar.CarCategory == CarType.B)
                radioButton1.Enabled = true;
            else if (Car.ActiveCar.CarCategory == CarType.C)
                radioButton2.Enabled = true;
            else radioButton3.Enabled = true;
            textBox2.Text = Car.ActiveCar.CarName;
            maskedTextBox2.Text = Car.ActiveCar.VIN;
            maskedTextBox1.Text = Car.ActiveCar.CarNumber;
            maskedTextBox3.Text = Car.ActiveCar.YearofRelease.ToString();
            maskedTextBox4.Text = Car.ActiveCar.PowerEngine.ToString();
        }
    }
}
