using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAndClass
{
    class Program
    {
        static void Main(string[] args)
        {

            // *******************改变类的值******************
            ClassTest ct = new ClassTest();
            ct.a = 10;
            ct.b = 20;
            ct.ShowAB();
            ChangeClassAB(ct);
            ct.ShowAB();
            //************************************************

            // *******************改变结构的值****************
            StructTest st = new StructTest();
            st.a = 10;
            st.b = 20;
            st.ShowAB();
            ChangeStructAB(st);
            st.ShowAB();
            //************************************************
        }


        //
        static void ChangeClassAB(ClassTest t)
        {
            t.a = 100;
            t.b = 200;
        }

        static void ChangeStructAB(StructTest t)
        {
            t.a = 100;
            t.b = 200;
        }
    }
}
