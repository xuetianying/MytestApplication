using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory.OriginalExample
{
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
    }
}
