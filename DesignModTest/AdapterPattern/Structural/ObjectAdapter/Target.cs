using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern.Structural.ObjectAdapter
{
  /// <summary>
  /// 在适配器中可以重写Target类的Request方法
  /// </summary>
    public class Target:ITarget
    {
       public virtual void Request()
       {
           Console.WriteLine("Called Target Request()");
       }
    }
}
