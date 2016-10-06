using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory.OriginalExample
{
    public abstract class Product:Iproduct
    {
        public void Display()
        {
            Console.WriteLine("这是来自接口的实现");
        }
    }
}
