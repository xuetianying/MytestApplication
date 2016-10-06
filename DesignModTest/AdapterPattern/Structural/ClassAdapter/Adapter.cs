using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern.Structural.ClassAdapter
{
    //类适配器，通过继承来适配，虽然C#中类不能多继承，但接口可以
    public class Adapter:Adapteree,ITarget
    {
        public void Request()
        {
            this.SpecificRequest();
        }
    }
}
