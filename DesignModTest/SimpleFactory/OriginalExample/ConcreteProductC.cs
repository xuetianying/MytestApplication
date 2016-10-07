using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory.OriginalExample
{
   public class ConcreteProductC
    {
       public static void Method()
       {
       
       }
       public static ConcreteProductC CreateC()
       { 
       return new ConcreteProductC();
       }
    }
}
