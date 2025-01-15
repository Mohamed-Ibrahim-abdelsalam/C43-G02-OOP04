using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assin4
{
    internal class BaseClass
    {

        public virtual void DisplayMessage()
        {
            Console.WriteLine("Message from BaseClass");
        }
    }

    class DerivedClass1 : BaseClass
    {
        
        public override void DisplayMessage()
        {
            Console.WriteLine("Message from DerivedClass1");
        }
    }

    class DerivedClass2 : BaseClass
    {
       
        public new void DisplayMessage()
        {
            Console.WriteLine("Message from DerivedClass2");
        }















    }
}
