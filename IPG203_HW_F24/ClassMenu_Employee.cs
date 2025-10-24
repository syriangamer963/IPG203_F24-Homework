using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPG203_HW_F24
{
    static class ClassMenu_Employee  
    {
 private static    ClassPermissions_Manager classPermissions_ = new ClassPermissions_Manager();

        public static void Menu_Employee ()
        {
            Console.WriteLine("\n ~~~~~~~~~ ~~~~~~~~~~ ~~~~~~~~~~ ~~~~~~~ \n ");
            Console.WriteLine("Welcome Employee ");
            Console.WriteLine("Choose one of the options ");
            Console.WriteLine("1) Show all store Devices");
            Console.WriteLine("2) Search for a Device in the Store");
            Console.WriteLine("3) Exite");

            string Choice = Console.ReadLine();
            switch (Choice)
            {
                case "1":
                    classPermissions_.showAll_Devices();  //  عرض الاجهزة
                    Menu_Employee();
                    break;

                case "2":
                    classPermissions_.Search_Device();      //  البحث عن جهاز
                    Menu_Employee();
                    break;

                case "3":
                    Console.WriteLine(" \n  ~~~~~~~~~~   Exit   ~~~~~~~~~~ \n\n");
                    break;

                default:
                    Console.WriteLine("Your Entry is incorrect _ Try Again \n");
                    Menu_Employee();
                    break;
            }
        }
    


    }
}
