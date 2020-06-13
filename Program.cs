using Inherit;
using Polymorphic;
using System;

namespace SixDesignPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var dip = new DIP();
            var CTBook = new Book();
            var WCNewspaper = new NewsPaper();
            dip.ReadStore(CTBook);
            dip.ReadStore(WCNewspaper);
            Console.WriteLine("Hello World!");

            //多态
            IPerson programmer = new Programmer();
            programmer.DoWork();
            IPerson myfanther = new Father();
            myfanther.DoWork();
            Console.ReadKey();

            //测试继承（鸡类、鹰类）
            Bird bird = new Bird();
            Chicken chicken = new Chicken();
            //继承时，发生创建类的过程，方法列表、属性列表，父类的先于子类，先于对象创建
        }
    }
}
