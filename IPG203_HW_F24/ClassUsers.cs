using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPG203_HW_F24
{
    internal class ClassUsers 
    {

        protected   List<int> ID_Manager = new List<int> { 111 };
        protected List<string> Name_Manager = new List<string> { "Manager" };
        protected List<string> Password_Manager = new List<string> { "Manager*" };


        protected List<int> ID_Employee = new List<int> { 203 };
        protected List<string> Name_Employee = new List<string> { "Employee" };
        protected List<string> Password_Employee = new List<string> { "Employee*" };
    }
}
