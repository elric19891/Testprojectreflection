using System;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var far = new Far(12, "12", 12);
            var far2 = new Far22(12, "faf", far);

            TakeNesterProperty(far2);
        }

        public  string FindPathByName(string Name)
        {
            
        }

        public static void TakeNesterProperty(Far22 far22)
        { 
            var xa = nameof(Far.x);
           var skta = far22.GetType().GetProperty(nameof(Far.x));
           Console.WriteLine(skta);
        }
        public class Base
        {
            public int MyProperty  { get; set; }

            public string Face { get; set; }

            public Base(int myProperty, string face)
            {
                MyProperty = myProperty;
                Face = face;
            }
        }
        public class Far:Base
        {
            public Far(int myProperty, string face, int x) : base(myProperty, face)
            {
                this.x = x;
            }
            
            public int x { get; set; }
        }
        public class Far22 : Base
        {
            public Far22(int myProperty, string face, Far far) : base(myProperty, face)
            {
                this.far = far;
            }
            public Far far { get; set; }
            
        }
    }
}