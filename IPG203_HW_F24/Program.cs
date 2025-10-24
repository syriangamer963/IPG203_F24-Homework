using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPG203_HW_F24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program(); // إنشاء كائن من الكلاس
            program.StartProgram();

        }


        ClassLogin_Application classLogin_Application = new ClassLogin_Application();
        ClassMenu_Manager classMenu_Manager = new ClassMenu_Manager();
        public  void StartProgram ()
        {
            Console.WriteLine(" ~~~~~~~~~ ~~~~~~~~~~ ~~~~~~~~~~ ~~~~~~~ \n ");
            Console.WriteLine("Welcome to the phone store");

            Console.WriteLine("1) Manager");
            Console.WriteLine("2) Employee");
            Console.WriteLine("3) Exite");

            string Choice = Console.ReadLine();
            switch (Choice)
            {
                case "1":
                    if (classLogin_Application.Login_Manager()) classMenu_Manager.Menu_Manager(); //  عرض صلاحيات المدير
                    break;

                case "2":
                    if (classLogin_Application.Login_Employee()) ClassMenu_Employee.Menu_Employee();   // عرض صلاحيات الموظف
                        break;

                case "3":
                    
                    break;

               default:
                    Console.WriteLine("Your ُntry is incorrect _ Try Again \n");
                    StartProgram();
                    break;

            }



        }


    }
}
