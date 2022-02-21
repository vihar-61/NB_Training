using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VD_Library
{
    public class MyBaseClass
    {
        public int a;
        private int b;
        protected int c;
        internal int d;
        protected internal int e;

        public void MyBaseClassMethod()
        {
            a = 3;
            b = 6;
            c = 9;
            d = 12;
            e = 15;
        }
    }
    public class MyDerivedClass : MyBaseClass
    {
        public void MyDerivedClassMethod()
        {
            a = 5;
            //b = 10;           //cannot access 
            c = 15;
            d = 20;
           //e = 25;           //cannot access
        }
    }
    public class MyOtherClass
    {
        public void MyOtherClassMethod()
        {
            MyBaseClass mbc = new MyBaseClass();
            mbc.a = 4;
            //mbc.b = 8;           //cannot access
            //mbc.c = 12;          //cannot access
            mbc.d = 16;
            //mbc.e = 20;          //cannot access

        }
    }
}
