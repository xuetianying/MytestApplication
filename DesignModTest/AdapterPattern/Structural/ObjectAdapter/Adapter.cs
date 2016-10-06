using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern.Structural.ObjectAdapter
{
   /// <summary>
   /// 对象适配器，适配器与被适配者结合associate
   /// </summary>
    public class Adapter:Target
    {
        private Adapteree _adaptee = new Adapteree();
        //public Target _target;
       // public Adapter(Target target)
        //{
          //  this._target = target;
        //}
        public override void Request()
        {
            _adaptee.SpecificRequest();
        }
    }
}
