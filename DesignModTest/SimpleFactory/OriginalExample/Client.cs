using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

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
        //看来无法用委托来代替简单工厂类哦
        delegate ConcreteProductC Mydel();
        //delegate void Mydel();
        private static readonly string ChooseProduct = ConfigurationManager.AppSettings["CreateProduct"];
        static void Main(string[] args)
        {
            //测试选择ProductA，由于要在程序中更改ChooseProduct不方便，所以可以利用配置文件实现
            //string ChooseProduct="ProductA";
            
            Product product = Factory.CreateProduct(ChooseProduct);
            Console.WriteLine("Created {0} by abstact class", product.GetType().Name);
            //测试方案二
            Iproduct iproduct = Factory.Create(ChooseProduct);
            iproduct.Display();
            Console.WriteLine("Created {0} by Interface", iproduct.GetType().Name);
            //方案三，有问题，返回类型不对
            Mydel createProduct ;
            createProduct = new Mydel(ConcreteProductC.CreateC);
            Console.WriteLine("Created {0} by delegate", createProduct.GetType().Name);
        }
    }
}
