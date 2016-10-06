using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;

namespace MyLearnNote
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    //FileMethod();
        //    //测试带索引器的类，看看当中的数据成员
        //    Test2_Indexers LongIndexValue = new Test2_Indexers();
        //    long a = 0;
        //    a = LongIndexValue[0];
        //    //此处输出的是第一个值，成功
        //    Console.WriteLine("{0}", a);
        //    //测试事件类
        //    //此处作为订阅者需要监听事件
        //    ReportTime MyReport = new ReportTime();
        //    MyReport.Report += new ReportTime.ReportEventHandler(MyReport_OnReport);
        //    //此处为订阅者类得情况
        //    ReceiveTime MyReceive = new ReceiveTime(MyReport);

        //    //测试触发事件
        //    MyReport.OnReport();
        //    //初始化，得到一只猫的实例，老鼠的实例，主人的实例
        //    Cat MyCat = new Cat();
        //    Mouse mouse = new Mouse();
        //    Master master = new Master();

        //    //测试猫叫事件，老鼠跑和主人醒可以看成是委托的两个事件处理程序
        //    MyCat.Cry += new Cat.CryEventHandler(mouse.Run);
        //    MyCat.Cry += new Cat.CryEventHandler(master.WakeUp);
        //    MyCat.OnCry();
        //}
        //public static void FileMethod()
        //{
        //    //先想好目录位置
        //    string dir = System.Environment.CurrentDirectory.ToString() + @"\Test";
        //    //先创建一个文件夹对象并实例化来存放测试的文件和程序
        //    DirectoryInfo Dir = new DirectoryInfo(dir);
        //    //创建目录
        //    if (!Dir.Exists)
        //    {
        //        Dir.Create();
        //        return;
        //    }

        //    //现在可以在该目录中创建我们所测试的文件
        //    //先给文件命名
        //    String fileName = dir + @"\Test.txt";
        //    //创建文件对象并实例化文件对象f
        //    FileInfo f = new FileInfo(fileName);
        //    if (!f.Exists)
        //    {
        //        f.Create();
        //        return;
        //    }
        //    //现在要测试向这个文件中写入数据以及从该文件中读取数据,我们用流的方式才能写入外部源（而不仅仅是磁盘）
        //    //首先创建流对象
        //    Byte[] buffer = new Byte[128];
        //    StreamWriter sw = new StreamWriter(fileName, true, Encoding.UTF8, buffer.Length);
        //    //往流中写数据
        //    sw.Write("how are you的第一句话");
        //    //写完后关闭流对象的实例
        //    sw.Close();
        //    //测试成功并追加文本，现在从该文件中用流对象来读取数据，放到一个动态字符串中
        //    //读和写的不同在于我们读取时是可以有选择性的，可以全读，也可以一行一行读等
        //    StreamReader sr = new StreamReader(fileName);
        //    StringBuilder sb = new StringBuilder();
        //    for (int i = 0; i < 50; i++)
        //    {
        //        string nextline = sr.ReadLine();
        //        sb.Append(nextline);
        //    }
        //    Console.WriteLine(sb.ToString());
        //}
        //private static void MyReport_OnReport(object sender, EventArgs e)
        //{
        //    string Date = System.DateTime.Now.ToString();
        //    Console.WriteLine("当前系统时间为：{0}", Date);

        //}

    }
}
