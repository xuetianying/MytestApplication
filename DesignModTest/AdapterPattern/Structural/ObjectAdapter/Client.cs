using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern.Structural.ObjectAdapter
{
    /***********************************************************************
     * 对象适配器的特点
     * 1.允许一个Adapter与多个Adapteree同时工作。Adapter也可以一次给所有的Adapteree添加功能；
     * 2.使得重定义Adaptee的行为比较困难。需要生成一个Adaptee的子类，
     *   然后使Adapter引入这个子类而不是引用Adaptee本身。
     * *********************************************************************/

    public class Client
    {
        //对象适配器结构实现
        /*Client需要调用Request方法，而Adaptee并没有该方法，
         * 为了使Client能够使用Adaptee类，需要提供一个类Adapter。
         * 这个类包含了一个Adaptee的实例，将Client与Adaptee衔接起来。
         */
       static void Main(string[] args)
       {
           //客户只看到目标接口t
           ITarget t = new Adapter();
           t.Request();
       }
    }
}
