﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assin4
{
    internal class Employee
    {

        public virtual void Work()
        {
            Console.WriteLine("Employee is working");
        }
    }

    class Manager : Employee
    {
      
        public override void Work()
        {
           
            base.Work();
            Console.WriteLine("Manager is managing");
        }





















    }
}
