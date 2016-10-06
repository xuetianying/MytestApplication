using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory.OriginalExample
{
    /*如果客户不知道Product抽象类，只有IProduct接口暴露给客户，就应选择方案二
     *Iproduct接口中应该声明除方法以外的内容，比如属性，事件，索引器。否则可以选择委托来代替接口 
     */
     /// <summary>
     /// 客户端只需要特定的产品，他不用管是谁给给他创建的，这里给客户端提供了Product抽象类
     /// </summary>
    public class Client
    {
        static void Main(string[] args)
        {
            //测试选择ProductA
            string ChooseProduct="ProductA";
            Product product = Factory.CreateProduct(ChooseProduct);
            Console.WriteLine("Created {0} by abstact class", product.GetType().Name);
            //测试方案二
            Iproduct iproduct = Factory.Create(ChooseProduct);
            iproduct.Display();
            Console.WriteLine("Created {0} by Interface", iproduct.GetType().Name);

        }
    }
}
