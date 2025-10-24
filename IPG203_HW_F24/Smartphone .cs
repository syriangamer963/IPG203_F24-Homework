using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IPG203_HW_F24
{
    internal class Smartphone : MobileDevice
    {
        public override void DisplayDetails()
        {
            Console.WriteLine($" phone: {Name} - Price: {Price} $");
        }

        /// <summary>
        ///  إضافة جهاز محمول
        /// </summary>
        public override void AddDevuce()
        {
            Console.WriteLine("\n ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~  \n");

            Console.WriteLine(" Add New Smartphone");

            Console.Write("Enter Device ID: ");
            string id = Console.ReadLine().Trim();

            Console.Write("Enter Device Name: ");
            string name = Console.ReadLine().Trim();
       
            Console.Write("Enter Price: ");
            int Price = int.Parse(Console.ReadLine().Trim());

            Console.Write("Enter Device Info: ");
            string info = Console.ReadLine().Trim();

            // إضافة البيانات إلى القوائم
            ID_Smartphone.Add(id);
            Smartphone.Add(name);
             Info_Smartphone.Add(info);
            Price_Smartphone.Add(Price);

            Console.WriteLine($" Smartphone '{name}' added successfully with ID {id}.");
            Console.WriteLine( "\n ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~  \n");

        }

        /// <summary>
        ///  حذف جهاز
        /// </summary>
        public void DeleteSmartphone()
        {
            Console.WriteLine("\n ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~  \n");
            Console.Write(" Enter the Smartphone ID to Delete: ");
            string idToDelete = Console.ReadLine().Trim();

            // البحث عن الفهرس المطابق للـ ID
            int index = ID_Smartphone.IndexOf(idToDelete);

            if (index == -1)
            {
                Console.WriteLine("Error : Device ID not found.");
                return;
            }

            // حذف البيانات من كل القوائم بنفس الفهرس
            ID_Smartphone.RemoveAt(index);
            Smartphone.RemoveAt(index);
            Price_Smartphone.RemoveAt(index);
            Info_Smartphone.RemoveAt(index);

            Console.WriteLine($" Smartphone with ID '{idToDelete}' has been deleted successfully.");
            Console.WriteLine("\n ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~  \n");

        }

        /// <summary>
        ///  للبحث عن جهاز
        /// </summary>
        public void SearchSmartphoneByName()
        {
            Console.WriteLine("\n ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~  \n");
            Console.Write(" Enter Smartphone Name to search: ");
            string search = Console.ReadLine().Trim();

            // البحث عن الفهرس المطابق للـ ID
            int index = Smartphone.IndexOf(search);

            if (index == -1)
            {
                Console.WriteLine("Error Device not found.");
                return;
            }
            // عرض معلومات الجهاز
            Console.WriteLine("\n Smartphone Found:");
            Console.WriteLine($"ID       : {ID_Smartphone[index]}");
            Console.WriteLine($"Name     : {Smartphone[index]}");
             Console.WriteLine($"Price    : {Price_Smartphone[index]} $");
            Console.WriteLine($"Info     : {Info_Smartphone[index]}");

            Console.WriteLine("\n ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~  \n");
        }

        /// <summary>
        ///  لعرض جميع الاجهزة
        /// </summary>
        public void ShowAllSmartphones()
        {
            Console.WriteLine("Smartphones in Store:");
            Console.WriteLine("\n ---------------------- \n");

            for (int i = 0; i < Smartphone.Count; i++)
            {
                Console.WriteLine($"Device {i + 1}");
                Console.WriteLine($"ID       : {ID_Smartphone[i]}");
                Console.WriteLine($"Name     : {Smartphone[i]}");
                 Console.WriteLine($"Price    : {Price_Smartphone[i]} USD");
                Console.WriteLine($"Info     : {Info_Smartphone[i]}");
                Console.WriteLine("\n ---------------------- \n");
            }
        }


    }
}
