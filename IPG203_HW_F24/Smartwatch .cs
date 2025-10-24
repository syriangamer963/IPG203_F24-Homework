using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IPG203_HW_F24
{
    internal class Smartwatch : MobileDevice
    {
        public override void DisplayDetails()
        {
            Console.WriteLine($" Smartwatch: {Name} - Price: {Price} $");
        }



        /// <summary>
        ///  إضافة ساعة ذكية
        /// </summary>
        public override void AddDevuce()
        {
            Console.WriteLine("\n ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~  \n");
            Console.WriteLine(" Add New Smartwatch");

            Console.Write("Enter Device ID: ");
            string id = Console.ReadLine().Trim();

            // التحقق من عدم تكرار ID
            if (ID_Smartwatch.Contains(id))
            {
                Console.WriteLine(" Error :  This ID already exists.");
                return;
            }

            Console.Write("Enter Device Name: ");
            string name = Console.ReadLine().Trim();
          
            Console.Write("Enter price: ");
            int Price = int.Parse(Console.ReadLine().Trim());

            Console.Write("Enter Device Info: ");
            string info = Console.ReadLine().Trim();

            // إضافة البيانات إلى القوائم
            ID_Smartwatch.Add(id);
            Smartwatch.Add(name);    
            Info_Smartwatch.Add(info);
            Price_Smartwatch.Add(Price);

            Console.WriteLine($" Smartwatch '{name}' added successfully with ID {id}.");
            Console.WriteLine("\n ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~  \n");

        }

        /// <summary>
        ///  حذف ساعة ذكية
        /// </summary>
        public void DeleteSmartwatch()
        {
            Console.WriteLine("\n ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~  \n");
            Console.Write(" Enter Smartwatch ID to delete: ");
            string idToDelete = Console.ReadLine().Trim();

            int index = ID_Smartwatch.IndexOf(idToDelete);

            if (index == -1)
            {
                Console.WriteLine("Error Device ID not found.");
                return;
            }
            // حذف من جميع القوائم بنفس الفهرس
            ID_Smartwatch.RemoveAt(index);
            Smartwatch.RemoveAt(index);        
            Price_Smartwatch.RemoveAt(index);
            Info_Smartwatch.RemoveAt(index);

            Console.WriteLine($" Smartwatch with ID '{idToDelete}' has been deleted.");
            Console.WriteLine("\n ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~  \n");
        }

        /// <summary>
        /// البحث عن ساعة ذكية
        /// </summary>
        public void SearchSmartwatchByName()
        {
            Console.WriteLine("\n ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~  \n");
            Console.Write(" Enter Smartwatch Name to search: ");
            string searchI = Console.ReadLine().Trim();

            int index = Smartwatch.IndexOf(searchI);

            if (index == -1)
            {
                Console.WriteLine("Error Device not found.");
                return;
            }
            // عرض معلومات الجهاز
            Console.WriteLine(" Smartwatch Found:");
            Console.WriteLine($"ID       : {ID_Smartwatch[index]}");
            Console.WriteLine($"Name     : {Smartwatch[index]}");
             Console.WriteLine($"Price    : {Price_Smartwatch[index]} $");
            Console.WriteLine($"Info     : {Info_Smartwatch[index]}");
            Console.WriteLine("\n ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~  \n");
        }


        /// <summary>
        ///  لعرض جميع الاجهزة
        /// </summary>
        public void ShowAllSmartwatches()
        {
            Console.WriteLine("Smartwatches in Store:");
            Console.WriteLine("-----------------------");

            for (int i = 0; i < Smartwatch.Count; i++)
            {
                Console.WriteLine($"Device {i + 1}");
                Console.WriteLine($"ID       : {ID_Smartwatch[i]}");
                Console.WriteLine($"Name     : {Smartwatch[i]}");
                 Console.WriteLine($"Price    : {Price_Smartwatch[i]} USD");
                Console.WriteLine($"Info     : {Info_Smartwatch[i]}");
                Console.WriteLine(); // سطر فارغ للفصل بين الأجهزة
            }
        }



    }
}
