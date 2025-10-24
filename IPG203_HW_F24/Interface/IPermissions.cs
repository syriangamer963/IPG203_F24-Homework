using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPG203_HW_F24
{
    // interface  كلاس من نوع 
    // كلاس الصلاحيات الاساسية
    internal interface IPermissions
    {
        void showAll_Devices();   //  إظهار كل الاجهزة بالمتجر


        void Search_Device();    //  البحث عن جهاز بالمتجر

        void Add_Device();         //  إضافة جهاز للمتجر

      


    }
}
