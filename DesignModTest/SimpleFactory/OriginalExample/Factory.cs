using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace SimpleFactory.OriginalExample
{
    /*1.通过抽象类来创建具体类
     *2.通过接口来创建 
     **/
    public class Factory
    {
        /// <summary>
        /// 静态方法创建产品实例
        /// </summary>
        /// <param name="o">选择产品参数</param>
        /// <returns>返回选择的具体产品的实例</returns>
        public static Product CreateProduct(string o)
        {
            Product specialproduct = null;
            switch(o)
            {
                case "ProductA":
                    specialproduct = new ConcreteProductA();
                    break;
                case "ProductB":
                    specialproduct = new ConcreteProductB();
                    break;
            }
            return specialproduct;
        }
        public static Iproduct Create(string choose)
        {
            Iproduct special = null;
            switch(choose)
            {
                case "ProductA":
                    //special = new ConcreteProductA();
                    //通过映射创建接口的具体类
                    return (Iproduct)Assembly.Load("SimpleFactory").CreateInstance("SimpleFactory.OriginalExample.ConcreteProductA");
                    
                case "ProductB":
                    special = new ConcreteProductB();
                    break;
            }
            return special;
        }
    }
}
