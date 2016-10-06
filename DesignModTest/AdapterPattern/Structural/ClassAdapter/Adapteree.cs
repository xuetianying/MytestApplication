using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern.Structural.ClassAdapter
{
   public  class Adapteree
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Called SpecificRequest()");
        }
    }
}
