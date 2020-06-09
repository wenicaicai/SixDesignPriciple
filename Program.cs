using System;

namespace SixDesignPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var dip= new DIP();
            var CTBook = new Book();
            var WCNewspaper = new NewsPaper();
            dip.ReadStore(CTBook);
            dip.ReadStore(WCNewspaper);
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
