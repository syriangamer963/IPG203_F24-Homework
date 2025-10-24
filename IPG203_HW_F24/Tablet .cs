using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPG203_HW_F24
{
    internal class Tablet : MobileDevice
    {
        public override void DisplayDetails()
        {
            Console.WriteLine($" Tablet: {Name} - Price: {Price} $");
        }

        /// <summary>
        ///  اضافة جهاز لوحي
        /// </summary>
        public override void AddDevuce()
        {
            Console.WriteLine("\n ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~  \n");
            Console.WriteLine(" Add New Tablet");

            Console.Write("Enter Device ID: ");
            string id = Console.ReadLine().Trim();

            // التحقق من عدم تكرار ID
            if (ID_Tablet.Contains(id))
            {
                Console.WriteLine("Error : This ID already exists.");
                return;
            }

            Console.Write("Enter Device Name: ");
            string name = Console.ReadLine().Trim();         

            Console.Write("Enter Price: ");
            int Price = int.Parse(Console.ReadLine().Trim());

            Console.Write("Enter Device Info: ");
            string info = Console.ReadLine().Trim();

            // إضافة البيانات إلى القوائم
            ID_Tablet.Add(id);
            Tablet.Add(name);
             Info_Tablet.Add(info);
            Price_Tablet.Add(Price);

            Console.WriteLine($" Tablet '{name}' added successfully with ID {id}.");
            Console.WriteLine("\n ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~  \n");

        }


        /// <summary>
        ///  حذف جهاز لوحي
        /// </summary>
        public void DeleteTablet()
        {
            Console.WriteLine("\n ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~  \n");
            Console.Write(" Enter Tablet name to delete: ");
            string nameToDelete = Console.ReadLine().Trim();

            int index = Tablet.IndexOf(nameToDelete);

            if (index == -1)
            {
                Console.WriteLine("Error Tablet not found.");
                return;
            }
            // حذف من جميع القوائم بنفس الفهرس
            ID_Tablet.RemoveAt(index);
            Tablet.RemoveAt(index);
             Price_Tablet.RemoveAt(index);
            Info_Tablet.RemoveAt(index);

            Console.WriteLine($" Tablet '{nameToDelete}' has been deleted.");
            Console.WriteLine("\n ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~  \n");
        }



        public void SearchTabletByName()
        {
            Console.Write(" Enter Tablet name to search: ");
            string searchName = Console.ReadLine().Trim();

            int index = Tablet.IndexOf(searchName);

            if (index == -1)
            {
                Console.WriteLine("Error Tablet not found.");
                return;
            }

            // عرض معلومات الجهاز
            Console.WriteLine(" Tablet Found:");
            Console.WriteLine($"ID       : {ID_Tablet[index]}");
            Console.WriteLine($"Name     : {Tablet[index]}");
             Console.WriteLine($"Price    : {Price_Tablet[index]} $");
            Console.WriteLine($"Info     : {Info_Tablet[index]}");
        }

        /// <summary>
        ///  لعرض جميع الاجهزة
        /// </summary>
        public void ShowAllTablets()
        {
            Console.WriteLine("Tablets in Store:");
            Console.WriteLine("------------------");

            for (int i = 0; i < Tablet.Count; i++)
            {
                Console.WriteLine($"Device {i + 1}");
                Console.WriteLine($"ID       : {ID_Tablet[i]}");
                Console.WriteLine($"Name     : {Tablet[i]}");
                 Console.WriteLine($"Price    : {Price_Tablet[i]} USD");
                Console.WriteLine($"Info     : {Info_Tablet[i]}");
                Console.WriteLine(); // سطر فارغ للفصل بين الأجهزة
            }
        }


    }
}
