using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsurance
{
    public class Car
    {
        /// <summary>
        /// Название Машины
        /// </summary>
        public string CarName { get; set; }
        /// <summary>
        /// Тип ТС
        /// </summary>
        public CarType CarCategory { get; set; }
        /// <summary>
        /// Год выпуска Машины
        /// </summary>
        public int YearofRelease { get; set; }
        /// <summary>
        /// VIN-номер
        /// </summary>
        public string VIN { get; set; }
        /// <summary>
        /// Регистрационный номер Машины
        /// </summary>
        public string CarNumber { get; set; }
        /// <summary>
        /// Мощность двигателя
        /// </summary>
        public double PowerEngine { get; set; }
        public static bool Load { get; set; }
        public static Car ActiveCar { get; set; }
        public Car()
        { }
    }

    public class Driver
    {
        /// <summary>
        /// Имя водителя
        /// </summary>
        public Name DriverName { get; set; }
        /// <summary>
        /// Дата рождения водителя
        /// </summary>
        public DateTime BirthTime { get; set; }
        /// <summary>
        /// Номер водительского удостоверения
        /// </summary>
        public int DriversLicenceNum { get; set; }
        /// <summary>
        /// Дата начала водительского стажа
        /// </summary>
        public DateTime DateStartDriving { get; set; }
        /// <summary>
        /// Информация об авто
        /// </summary>
        public List<Car> Cars { get; set; }
        public static bool Load { get; set; }
        public static Driver ActiveDriver { get; set; }
        public Driver() 
            {}
    }

    public class InsuranceCar
    {
        /// <summary>
        /// Город пребывания
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// Срок действия страховки
        /// </summary>
        public int TimeInsurance { get; set; }
        /// <summary>
        /// Дата начала страховки
        /// </summary>
        public DateTime TimeStartInsurance { get; set; }
        /// <summary>
        /// Дополнительные водители
        /// </summary>
        public List<Driver> Drivers { get; set; }
        static public InsuranceCar ActiveInsurance { get; set; }
    }

    public class Name
    {
        public string Surname { get; set; }
        public string Firstname { get; set; }
        public string Patronymic { get; set; }
        public Name(string surname, string firstname, string patronymic)
        {
            Surname = surname;
            Firstname = firstname;
            Patronymic = patronymic;
        }
        public Name()
        { }
    }

    public enum CarType
    {
        /// <summary>
        /// Легковое авто
        /// </summary>
        B,
        /// <summary>
        /// Грузовое авто
        /// </summary>
        C,
        /// <summary>
        /// Автобус
        /// </summary>
        D,
    }
}
