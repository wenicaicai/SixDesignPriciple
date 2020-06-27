using Common;
using Inherit;
using Models;
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
            BirdAdapter birdAdapter = new BirdAdapter(chicken);
            birdAdapter.ToTweet();
            //继承时，发生创建类的过程，方法列表、属性列表，父类的先于子类，先于对象创建

            //枚举的转换
            var foo = Days.Sunday.ToString();
            Console.WriteLine(foo);

            var goo = Enum.GetName(typeof(Days), 6);

            var hoo = Enum.TryParse("Tuesday", out Days bar);

            var too = (Days)Enum.Parse(typeof(Days), "Tuesday");

            var uoo = (byte)Days.Monday;

            var eoo = (Days)2;

            Type yoo = Enum.GetUnderlyingType(typeof(Days));

            var woo = Enum.GetValues(typeof(Days));

            var noo = Enum.GetNames(typeof(Days));

            var poo = (Days)21;

            Enum.IsDefined(typeof(Days), poo);

            var doo = default(Days);

            //枚举可以通过Description、Display等特性来为成员添加有用的辅助信息

            var user = new User { Id = 1, Roles = Common.Roles.Admin };
            /**
             * 枚举的Flags特性
             */
            if (user.Roles.HasFlag(Roles.Admin))
            {
                Console.WriteLine("I am Admin.");
            }

            //这是什么操作
            var ioo = (Roles.Admin | Roles.Member);

            var par = ioo & ~ioo;

        }
    }
}
