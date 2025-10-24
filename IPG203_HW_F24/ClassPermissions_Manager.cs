using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPG203_HW_F24
{
    internal class ClassPermissions_Manager : ClassUsers , IPermissions
    {
        Smartphone smartphone = new Smartphone();
        Smartwatch smartwatch = new Smartwatch();
        Tablet tablet = new Tablet();

        /// <summary>
        ///  إظهار كل الاجهزة بالمتجر
        /// </summary>
        public void showAll_Devices()
        {
            Console.WriteLine("\n ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~  \n");
            Console.WriteLine("1) Show All Smartphone ");
            Console.WriteLine("2) Show All SmartWatch ");
            Console.WriteLine("3) Show All Tablet ");
            Console.WriteLine("4) Exite ");

            string choose = Console.ReadLine().Trim();
            switch (choose)
            {
                case "1":
                    smartphone.ShowAllSmartphones();  //  عرض اجهزة المحمول
                    break;

                case "2":
                    smartwatch.ShowAllSmartwatches();  //  عرض اجهزة الساعة الذكية
                    break;

                case "3":
                    tablet.ShowAllTablets();          //  عرض اجهزة اللوحية
                    break;

                case "4":

                    break;

                default:
                    Console.WriteLine(" Your input is incorrect");
                    break;
            }
        }


        /// <summary>
        ///  البحث عن جهاز بالمتجر
        /// </summary>
        public  void  Search_Device() 
        {
            Console.WriteLine("\n ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~  \n");
            Console.WriteLine("1) Search Smartphone ");
            Console.WriteLine("2) Search SmartWatch ");
            Console.WriteLine("3) Search Tablet ");
            Console.WriteLine("4) Exite ");

            string choose = Console.ReadLine().Trim();
            switch (choose)
            {
                case "1":
                    smartphone.SearchSmartphoneByName(); //  البحث عن الاجهزة المحمولة
                    break;

                case "2":
                    smartwatch.SearchSmartwatchByName();  // البحق عن ساعة ذكية
                    break;

                case "3":
                    tablet.SearchTabletByName();         // البحق عن جهاز لوحي
                    break;

                case "4":
                    Console.WriteLine(" \n  ~~~~~~~~~~   Exit   ~~~~~~~~~~ \n\n");
                    break;

                default:
                    Console.WriteLine(" Your input is incorrect");
                    break;


            }
        }


        /// <summary>
        ///  إضافة جهاز للمتجر
        /// </summary>
        public   void Add_Device()
        {
            Console.WriteLine("\n ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~  \n");
            Console.WriteLine("1) Add Smartphone ");
            Console.WriteLine("2) Add SmartWatch ");
            Console.WriteLine("3) Add Tablet ");
            Console.WriteLine("4) Exite ");

            string choose = Console.ReadLine().Trim();
            switch (choose)
            {
                case "1":
                    smartphone.AddDevuce();    //  اضافة جهاز محمول
                    break;

                case "2":
                    smartwatch.AddDevuce();    //  اضافة ساعة ذكية
                    break;

                case "3":
                    tablet.AddDevuce();         // اضافة جهاز لوحي
                    break;

                case "4":
                    Console.WriteLine(" \n  ~~~~~~~~~~   Exit   ~~~~~~~~~~ \n\n");
                    break;

                default:
                    Console.WriteLine(" Your input is incorrect");
                    break;
            }
        }

        /// <summary>
        /// حذف جهاز من المتجر
        /// </summary>
        public void Delete_Device()
        {
            Console.WriteLine("\n ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~  \n");
            Console.WriteLine("1) Delete Smartphone ");
            Console.WriteLine("2) Delete SmartWatch ");
            Console.WriteLine("3) Delete Tablet ");
            Console.WriteLine("4) Exite ");

            string choose = Console.ReadLine().Trim();
            switch (choose)
            {
                case "1":
                    smartphone.DeleteSmartphone();   // حذف جهاز محمول
                    break;

                case "2":
                    smartwatch.DeleteSmartwatch();   // حذف ساعة ذكية  
                    break;

                case "3":
                    tablet.DeleteTablet();           // حذف جهاز لوحي
                    break; 

                case "4":
                    Console.WriteLine(" \n  ~~~~~~~~~~   Exit   ~~~~~~~~~~ \n\n");
                    break;

                default:
                    Console.WriteLine(" Your input is incorrect");
                    break;
            }
        }



        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///

        public string Name_Em  //  لاضافة اسم الموظف
        {
            get { return Name_Em; }
            set
            {
                if (value != null) Name_Employee.Add(value);
                else
                {
                    Console.WriteLine("Your Name is instance ");
                    Add_Employee();
                }
                ;
            }
        }

        public string Password_Em  //  لاضافة كلمة السر للموظف
        {
            get { return Password_Em; }
            set
            {
                if (value != null) Password_Employee.Add(value);
                else
                {
                    Console.WriteLine("Your Password is instance try Again ");
                    Add_Employee();
                }
                ;
            }
        }

        /// <summary>
        /// إضافة موظف
        /// </summary>
        protected void Add_Employee()
        {
            Console.Write("Enter Name Employee : ");
            Name_Em = Console.ReadLine().Trim();

            Console.Write("Enter Password Employee : ");
            Password_Em = Console.ReadLine().Trim();

            int ID_Em = ID_Employee[ID_Employee.Count - 1] + 1; //  تلقائيا مع إاضافة عدد ليصبح مختلف ID   معرفة اخر 

            ID_Employee.Add(ID_Em);
            Console.Write("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ ");
            Console.WriteLine(" Adderd \n");
            Console.Write($" Name Employee : {ID_Employee[ID_Employee.Count - 1]} \n");
            Console.Write($" Name Employee : {Name_Employee[ID_Employee.Count - 1]} \n");
            Console.Write($" Name Employee : {Password_Employee[ID_Employee.Count - 1]} \n");

            Console.Write("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ \n");
        }

        /// <summary>
        /// عرض كل الموظفين
        /// </summary>
        protected void showAll_Employee()
        {
            Console.WriteLine("Employees in System:");
            Console.WriteLine(" \n --------------------- \n");

            for (int i = 0; i < ID_Employee.Count; i++)
            {
                Console.WriteLine($"Employee {i + 1}");
                Console.WriteLine($"ID       : {ID_Employee[i]}");
                Console.WriteLine($"Name     : {Name_Employee[i]}");
                Console.WriteLine($"Password : {Password_Employee[i]}");
                Console.WriteLine(" \n~~~~~~ ~~~~~~~ ~~~~~~~ ~~~~~~ ~~~~~~ ~~~~~ ~~~~~~ ~~~~~ \n");
            }
        }
       

        /// <summary>
        /// حذف موظف
        /// </summary>
        protected void Delete_Employee()
        {
            Console.Write("Enter Employee ID to delete: ");
            string input = Console.ReadLine().Trim();

            // محاولة تحويل الإدخال إلى رقم صحيح
            if (!int.TryParse(input, out int idToDelete))
            {
                Console.WriteLine("Invalid ID format.");
                return;
            }

            // البحث عن الفهرس المطابق للـ ID
            int index = ID_Employee.IndexOf(idToDelete);

            if (index == -1)
            {
                Console.WriteLine("Employee ID not found.");
                return;
            }

            // حذف البيانات من جميع القوائم بنفس الفهرس
            ID_Employee.RemoveAt(index);
            Name_Employee.RemoveAt(index);
            Password_Employee.RemoveAt(index);

            Console.WriteLine($"Employee with ID {idToDelete} has been deleted successfully.");
        }

       

    }
}
