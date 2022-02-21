using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using VD_Library;

namespace Public_Library
{
    public class MyPublicLibraryDerivedClass : MyBaseClass
    {
        public void MyPublicLibraryDerviedClassMethod()
        {
            a = 2;
            //b = 4;         //cannot access
            c = 6;
            //d = 8;         //cannot access
            e = 10;
        }
    }
    public class MyPublicLibraryOtherClass
    {
        public void MyPublicLibraryOtherClassMethod()
        {
            MyBaseClass mbc = new MyBaseClass();

            mbc.a = 6;
            //mbc.b = 12;          //cannot access
            //mbc.c = 18;          //cannot access
            //mbc.d = 24;          //cannot access
            //mbc.e = 30;          //cannot access


        }
    }
}
