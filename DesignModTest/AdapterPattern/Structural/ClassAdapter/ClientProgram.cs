using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdapterPattern.Structural.ClassAdapter;

namespace AdapterPattern.Structural.ClassAdapter
{
    /****************************************************************************
     * 类适配器的特点
     * 1.使得Adapter可以重定义Adapteree的部分行为。因为Adapter是Adapteree的一个子类；
     * 2. 仅仅引入了一个对象，并不需要额外的指针间接得到Adapteree
     ******************************************************************************/
    public  class ClientProgram
    {
        //类适配器结构实现
       static void Main(string[] args)
       {
           ITarget t = new Adapter();
           t.Request();
       }
    }
}
