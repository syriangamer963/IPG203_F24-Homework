using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPG203_HW_F24
{
    internal class ClassMenu_Manager : ClassPermissions_Manager
    {
        public   void Menu_Manager ()
        {
            Console.WriteLine("\n ~~~~~~~~~ ~~~~~~~~~~ ~~~~~~~~~~ ~~~~~~~ \n ");
            Console.WriteLine("Welcome Manager ");
            Console.WriteLine("Choose one of the options ");

            Console.WriteLine("1) Show all store Devices");
            Console.WriteLine("2) Search for a Device in the Store");
            Console.WriteLine("3) Add a Device in the Store");             
            Console.WriteLine("4) Delete a Device in the Store");
            Console.WriteLine("5) Add Employee");
            Console.WriteLine("6) Delete Employee");
            Console.WriteLine("7) show All Employee");
            Console.WriteLine("8) Exite");

            string Choice = Console.ReadLine();
            switch (Choice)
            {
                case "1":
                    showAll_Devices();    //  عرض الاجهزة
                    Menu_Manager();
                    break;

                case "2":
                    Search_Device();      //  البحث عن جهاز
                    Menu_Manager();
                    break;

                case "3":
                    Add_Device();        //إضافة جهاز
                    Menu_Manager();
                    break;

                case "4":
                    Delete_Device();       // حذف جهاز
                    Menu_Manager();
                    break;

                case "5":
                    Add_Employee();        //  إضافة موظف
                    Menu_Manager();
                    break;

                case "6": 
                    Delete_Employee();      //   حذف موظف
                    Menu_Manager();
                    break;

                case "7":
                    showAll_Employee();      //   عرض كل الموظفين
                    Menu_Manager();
                    break;

                case "8":
                    Console.WriteLine(" \n  ~~~~~~~~~~   Exit   ~~~~~~~~~~ \n\n");
                    break;
             
                default:
                    Console.WriteLine("Your ُntry is incorrect _ Try Again \n");
                    Menu_Manager();
                    break;
            }
        }




    }
}
