using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoringSystem
{
    enum Service { Sensors, Cameras, Intercoms}
    class Client
    {
        public const int SENSOR_PRICE = 5;
        public const int CAMERA_PRICE = 3;
        public const int INTERCOM_PRICE = 10;

        private string address;
        private bool isActive;
        private string name;
        private string phone;
        private int quantity;
        private Service service;

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        public bool IsActive
        {
            get
            {
                return isActive;
            }
            set
            {
                isActive = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        }
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }
        public Service Service
        {
            get
            {
                return service;
            }
            set
            {
                service = value;
            }
        }

        public virtual double CalculatePrice()
        {
            int price = 0;
            switch (Service)
            {
                case Service.Sensors:
                    price = SENSOR_PRICE;
                    break;
                case Service.Cameras:
                    price = CAMERA_PRICE;
                    break;
                case Service.Intercoms:
                    price = INTERCOM_PRICE;
                    break;
            }
            return Quantity * price;
        }
        public virtual double CalculatePrice(double discount)
        {
            return CalculatePrice() * ((100.00 - discount) / 100);
        }
        public Client(Service service, int quantity)
        {
            IsActive = true;
            Service = service;
            Quantity = quantity;
        }
        public override string ToString()
        {
            return $"- {Name} located at {Address} is paying {CalculatePrice():c} per month";
        }
        public void SaveData(string fileName)
        {
            FileStream outFile = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(outFile);
            streamWriter.WriteLine(JsonConvert.SerializeObject(this));
            streamWriter.Close();
            outFile.Close();
        }
    }
}
