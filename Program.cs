using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConASM1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SectionC1 c1 = new SectionC1();
            c1.fun1();
            c1.fun2();

            SectionC2 c2 = new SectionC2();
            c2.fun1();
            c2.fun4();
            c2.fun5();
            Console.Read();

        }
    }

    internal class SectionC1
    {
        public void fun1()
        {
            Console.WriteLine("SectionC1 Class and Function Fun1");
        }
        public void fun2()
        {
            Console.WriteLine("SectionC1 Class and Function Fun2");
        }
    }

    public class SectionC2
    {
        public void fun1()
        {
            Console.WriteLine("SectionC2 Class and Function Fun1");
        }
        private void fun2()
        {
            Console.WriteLine("SectionC2 Class and Function Fun2");
        }
        protected void fun3()
        {
            Console.WriteLine("SectionC2 Class and Function Fun3");
        }
        internal void fun4()
        {
            Console.WriteLine("SectionC2 Class and Function Fun4");
        }
        protected internal void fun5()
        {
            Console.WriteLine("SectionC2 Class and Function Fun5");
        }
        private protected void fun6()
        {
            Console.WriteLine("SectionC2 Class and Function Fun6");
        }
    }

    class DrivedClass : SectionC2
    {
        public void DCFun()
        {


        }

    }
}
