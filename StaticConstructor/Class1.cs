using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructor
{
    public class Class1
    {
        private static Class1 myVar;

        private Class1()
        {
            
        }
        public static Class1 MyProperty
        {
            get
            {
                if (myVar == null)
                {
                    myVar = new Class1();
                   
                }
                return myVar;
            }
            
        }
        public void Say()
        {
            Console.WriteLine(  "");
        }


    }
}
