using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory.OriginalExample
{
     public class Client
    {
        static void Main(string[] args)
        {
            //测试选择ProductA
            string ChooseProduct="ProductB";
            Product product = Factory.CreateProduct(ChooseProduct);
            Console.WriteLine("Created {0}", product.GetType().Name);
        }
    }
}
