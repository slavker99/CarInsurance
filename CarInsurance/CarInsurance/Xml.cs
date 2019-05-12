using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace CarInsurance
{
    class Xml
    {
        public static void SaveUser()
        {
            FileStream stream = new FileStream("driver"+Driver.ActiveDriver.DriversLicenceNum.ToString()+".xml", FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(Driver));
            serializer.Serialize(stream, Driver.ActiveDriver);
            stream.Close();
        }

        public static void LoadUser(string fileName)
        {
            FileStream stream = new FileStream(fileName, FileMode.Open);
            XmlSerializer serializer = new XmlSerializer(typeof(Driver));
            Driver.ActiveDriver = (Driver)serializer.Deserialize(stream);
            stream.Close();
        }

        public static void SaveCar(Car car)
        {
            if (Driver.ActiveDriver.Cars == null)
            {
                Driver.ActiveDriver.Cars = new List<Car>() {};
                Driver.ActiveDriver.Cars.Add(car);
            }
            else
                Driver.ActiveDriver.Cars.Add(car);
            Xml.SaveUser();
        }
    }
}
