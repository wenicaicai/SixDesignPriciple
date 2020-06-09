using System;
using System.Collections.Generic;
using System.Text;

namespace SixDesignPrinciple
{
    /// <summary>
    /// 依赖倒置原则
    /// Dependency Inversion Principle
    /// 告诉我们需要面向接口编程
    /// 核心：面向接口编程
    /// 现在TDD开发模式就是依赖倒置原则...最成功的应用
    /// 1.高层不依赖低层，两者都应该依赖抽象
    /// 2.抽象不应该依赖细节
    /// 3.细节应该依赖抽象
    /// 给点实列啦
    /// </summary>
    public class DIP
    {
        public void ReadStore(Book book)
        {
            Console.WriteLine("妈妈要准备讲故事啦...3 2 1 ...开始讲故事...");
            Console.WriteLine(book.GetContent());
            /*
             * 1.有一天，需要读报纸了
             * 2.书本、音乐、电影、杂志、报刊、图画等等
             * 3.解决方式：写个接口，载体的读取的接口
             */

        }

        public void ReadStore(NewsPaper newsPaper)
        {
            Console.WriteLine("妈妈要准备讲故事啦3 2 1 ...开始讲故事...");
            Console.WriteLine(newsPaper.GetContent());
        }

        public void ReadStore(IReader reader)
        {
            Console.WriteLine("妈妈要准备讲故事啦3 2 1 ...开始讲故事...");
            Console.WriteLine(reader.GetContent());
        }
    }

    public class Book : IReader
    {
        public string GetContent()
        {
            return "很久很久以前...";
        }
    }


    public class NewsPaper : IReader
    {
        public string GetContent()
        {
            return "2020.01.23 中国武汉发生封城";
        }
    }

}
