using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern.Structural.ObjectAdapter
{
    /// <summary>
    /// 所有的请求都委托给被适配器
    /// </summary>
    public class Adapteree
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Called SpecificRequest()");
        }
    }
}
