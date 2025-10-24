using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPG203_HW_F24
{
    abstract class MobileDevice
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public abstract void DisplayDetails(); // يجب تنفيذها في الفئات الفرعية
        public abstract void AddDevuce(); // يجب تنفيذها في الفئات الفرعية



        public delegate void DeviceAddedHandler(string deviceName);




        public event DeviceAddedHandler OnDeviceAdded;



        //  اجهزة الهاتف المحمول
        protected List<string> ID_Smartphone = new List<string> { "SP001", "SP002", "SP003" };
        protected List<string> Smartphone = new List<string> { "Galaxy S24", "iPhone 15", "Xiaomi 13" };
         protected List<int> Price_Smartphone = new List<int> { 100, 120, 150 };
        protected List<string> Info_Smartphone = new List<string>
                                        {
                                         "6.1-inch display, Snapdragon 8 Gen 2 processor",
                                         "Super Retina display, 48MP camera",
                                         "AMOLED screen, 5000mAh battery"
                                         };



        //  اجهزة الساعات الذكية
        protected List<string> ID_Smartwatch = new List<string> { "SW001", "SW002" };
        protected List<string> Smartwatch = new List<string> { "Apple Watch Series 9", "Galaxy Watch 6" };
         protected List<int> Price_Smartwatch = new List<int> { 75, 55};
        protected List<string> Info_Smartwatch = new List<string>
                                        {
                                             "Heart rate sensor, water resistant",
                                             "Round display, GPS and sleep tracking"
                                        };


        // الاجهزة اللوحية
        protected List<string> ID_Tablet = new List<string> { "TB001", "TB002" };
        protected List<string> Tablet = new List<string> { "iPad Pro", "Galaxy Tab S9" };
         protected List<int> Price_Tablet = new List<int> { 170, 220 };
        protected List<string> Info_Tablet = new List<string>
                                {
                                      "Liquid Retina display, Apple Pencil support",
                                     "AMOLED screen, Snapdragon 8 Gen 2 processor"
                                };



    }
}
