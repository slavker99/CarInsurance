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
            label12.Text = Driver.ActiveDriver.DriverName.Surname + " " + Driver.ActiveDriver.DriverName.Firstname + " " + Driver.ActiveDriver.DriverName.Patronymic;
            label4.Text = Car.ActiveCar.CarName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormCar bf = new FormCar();
            bf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InsuranceCar ins = new InsuranceCar();
            ins.City = comboBox2.Text;
            ins.TimeStartInsurance = dateTimePicker1.Value;
            switch (comboBox1.Text)
            {
                case "3 месяца":
                    ins.TimeInsurance = 3;
                    break;
                case "6 месяцев":
                    ins.TimeInsurance = 6;
                    break;
                case "9 месяцев":
                    ins.TimeInsurance = 9;
                    break;
                case "12 месяцев":
                    ins.TimeInsurance = 12;
                    break;
                default:
                    break;
            }
            ins.Drivers = new List<Driver>();
            for (int i=0;i<dataGridView1.RowCount; i++)
            {
                Driver driver = new Driver();
                driver.DriverName = new Name(dataGridView1.Rows[i].Cells[0].Value.ToString(), dataGridView1.Rows[i].Cells[1].Value.ToString(), dataGridView1.Rows[i].Cells[2].Value.ToString());
                if (dataGridView1.Rows[i].Cells[3].Value.ToString() != "")
                    driver.DriversLicenceNum = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                ins.Drivers.Add(driver);
            }
        }

        private void FormInsurance_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
