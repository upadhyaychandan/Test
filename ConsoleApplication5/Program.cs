using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            a obj = new ConsoleApplication5.a();
            obj.print();
            b obj1 = new b();
            obj1.print();
            a obj3 = new b();
            obj3.print();
            obj3.print();

          //  b obj4 = new a();
        }
    }
    public class a
    {
      public virtual void print  ()
        {

        }
    }
    public class b  :a
    {
      public  override void print()
        {

        }
    }
}
