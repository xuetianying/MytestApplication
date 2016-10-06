using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLearnNote
{
    /// <summary>
    /// 猫打盹睡觉委托声明，也可以在其他地方进行（比如初始化的时候）
    /// </summary>
    public delegate void SleepEventHandler();
    interface Icat : InterfaceForTest
    {
        /// <summary>
        /// 猫叫行为,注意接口中方法的定义
        /// </summary>
        void OnCry();
        /// <summary>
        /// 声明猫的颜色属性
        /// </summary>
        string Color { get; set; }
        //定义一个猫打盹的事件，老鼠见到猫打盹就出来偷东西吃，人就骂懒猫
        
        event SleepEventHandler Sleep;
    }
}
