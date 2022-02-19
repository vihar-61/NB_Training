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
        int e;
    }

    public class MyDerivedClass : MyBaseClass
    {

    }

    public class MyOtherClass
    {

    }
}
