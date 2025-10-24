using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPG203_HW_F24
{
    internal class ClassLogin_Application : ClassUsers
    {

      


        /// <summary>
        ///  تسجيل دخول المدير
        /// </summary>
        /// <returns></returns>
        public bool Login_Manager ()
        {
            Console.Write("Enter Name Manager : ");
            string Name = Console.ReadLine().Trim();

            Console.Write("Enter Password Manager : ");
            string Password = Console.ReadLine().Trim();
            bool result = false;

            for (int index = 0; index < ID_Manager.Count; index++)
            {
                if (Name == Name_Manager[index] && Password == Password_Manager[index])
                {
                    return result = true;
                }
            }
            if(!result)
            {
                Console.WriteLine(" Your Password Or Name is incorrect ,,, Try Again ");
            }
            return result;
        }

        /// <summary>
        /// تسجيل دخول الموظف
        /// </summary>
        /// <returns></returns>
        public bool Login_Employee ()
        {
            Console.Write("Enter Name Employee : ");
            string Name = Console.ReadLine().Trim();

            Console.Write("Enter Password Employee : ");
            string Password = Console.ReadLine().Trim();
            bool result = false;

            for (int index = 0; index < ID_Employee.Count; index++)
            {
                if(Name == Name_Employee[index] && Password == Password_Employee[index])
                {
                    return result = true;         
                }
            }
            if (!result)
            {
                Console.WriteLine(" Your Password Or Name is incorrect ,,, Try Again ");
            }
            return result;
        }

      

    }
}
