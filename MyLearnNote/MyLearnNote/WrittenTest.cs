using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLearnNote
{
    class WrittenTest
    {
        public WrittenTest()
        {
            Console.WriteLine("This is the base class for test");

        }
    }
    //设计类满足要求：包含多个构造函数。比如周长类包括圆周长、三角形周长、矩形周长等等
    class Test1_perimeter: WrittenTest  
    { 
    //其实就是签名不同
        public double Myperimeter = 0;
        public void calculate()
        {
            Console.WriteLine("{0}",Myperimeter);
        }
        public Test1_perimeter(double r)
        {
            Myperimeter = 3.1415 * 2 * r;
        }
        public Test1_perimeter(double a,double b,double c)
        {
            Myperimeter = a + b + c;
        }
        public Test1_perimeter(double s,double m)
        {
            Myperimeter = 2 * (s + m);
        }
    }
    //设计类满足要求：带有一个索引器可以存储10个整型变量[索引器的目的是访问其他数据成员]，这里就是说索引范围就是100
    class Test2_Indexers : WrittenTest
    {
        public Test2_Indexers()
        {
            Console.WriteLine("这是继承自WrittenTest类（笔试题）的子类，用于测试索引器");
        }
        //定义整数集,arr成为该类的一个字段
        private long[] arr=new long[10]{10,20,30,40,50,60,70,80,90,100};
        
        //声明索引器（长整型）
        public long this[int index]
        {
            get
            { 
                if(index<0||index>=10)
                {
                    return 0;
                }
                else
                {
                    return arr[index];
                }
            }
            set 
            {
                if (!(index < 0 || index >= 10))
                {
                    arr[index] = value;
                }
            //现在可以在主程序中测试，给整数集中的变量赋值，并按照索引访问整数集成员
                
            }
            

        }
    }

    /*编写一个类，其中包含一个排序的方法Sort(),当传入的是一串整数，
     *就按照从小到大的顺序输出，如果传入的是一个字符串，就将字符串反序输出。   
     */
    class Test_sort:WrittenTest
    {
        public Test_sort()
        {
            Console.WriteLine("这是继承自WrittenTest类（笔试题）的子类，用于测试排序");
        }
        public static void sort(string str)
        { 
        //先判断传入的字符是否为整数串，这个就是不清楚的地方了。。。
        }
    }
    /*设计一个类，要求用事件每10秒报告机器当前时间(测试时报10次即可)
     * 也就是说，该类是发布者类，而控制台（主函数）可算是订阅者（其他类也可收到通知），这里系统时间每改变10s就会
     * 触发事件通知控制台输出
     */
    class ReportTime : WrittenTest
    {
        public ReportTime()
        {
            Console.WriteLine("这是继承自WrittenTest类（笔试题）的子类，用于报告当前时间");
        }
        //在发布者类中定义事件委托,参数1是发布对象，参数2是事件类
        public delegate void ReportEventHandler(object sender,EventArgs e);
        //现在就可以定义一个委托类型（之前的ReportEventHandler）的事件了
        public event ReportEventHandler Report;
        //用于触发Report事件，即经过10s
        public void OnReport()
        {
            for (int i = 0; i < 10;i++ )
            {
                
                Report(this, null);
                System.Threading.Thread.Sleep(1000);
            }
            
        }

    }
    /*扩展前一个程序，再设计一个订阅者类
     * 当订阅者收到发布者的通知后，自增变量并输出到控制台
     * 所以说自增变量应该为订阅者类的属性
     */
    class ReceiveTime : WrittenTest
    {
        //需要将ReportTime类的参数传递进来才能实现订阅
        public ReceiveTime(ReportTime HisReport)
        {
            Console.WriteLine("这是继承自WrittenTest类（笔试题）的子类，收到当前时间后输出自增变量值");
            //作为订阅者，需要订阅事件来监听事件,并添加事件处理程序（委托会顺序调用其中的处理程序）
            HisReport.Report+=new ReportTime.ReportEventHandler(HisReport_OnReport);
        }
    
        
       
    //事件处理程序的声明,属性构造(如果不用的化，外界无法监控该类的这个变量值)
        public int TimeCount { get; private set; } 
        public void HisReport_OnReport(object sender,EventArgs e)
        {
            
            TimeCount++;
            Console.WriteLine("当前的值为{0}",TimeCount);
        }

    }
    /*设计一个典型的猫叫，老鼠跑，主人被惊醒的程序
     * Cat类：这是个事件触发者
     * Mouse类：这是个订阅者，听到猫叫后，老鼠本能就是逃跑
     * Master类：这也可以算是个订阅者，主人因为猫的叫声而做出了一些行为
     **/
    class Cat : Icat 
    { 
    //声明委托和事件，如果在接口中，那么就需要在其他地方声明委托，而在接口内定义事件
        //因为委托是引用类型，而事件是方法，详见ICat中的Sleep事件
        public delegate void CryEventHandler();
        public event CryEventHandler Cry;
        public event SleepEventHandler Sleep;
        //定义触发事件的方法
        public void OnCry()
        {
            Console.WriteLine("猫：喵喵叫");
            Cry();
        }
        public void OnSleep()
        {
            Console.WriteLine("猫：huhu....eeee...");
            Sleep();
        }
        private string _color;
        public string Color
        { 
            get{return _color;}
            set { _color = value; }
        }
    }
    class Mouse : WrittenTest
    { 
    //订阅或监听Cry事件，为该事件添加处理程序(这种方式不好，这会导致猫类和老鼠类的耦合)
        public void Run()
        {
            Console.WriteLine("老鼠：猫来了，我得快跑");
        }
    }
    class Master : WrittenTest
    {
        public void WakeUp()
        {
            Console.WriteLine("主人：死猫把我给弄醒了，烦");
        }
    }
    //创建一个House类来订阅和监听Cry事件，为老鼠和主人提供通知
    class House: WrittenTest
    {
    
    }
}
