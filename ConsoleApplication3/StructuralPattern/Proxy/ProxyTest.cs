using System;
using DesignPatterns.StructuralPattern.Proxy.BookProxy;

namespace DesignPatterns.StructuralPattern.Proxy
{
    public class ProxyTest : PatternTest
    {
        public ProxyTest() : base("Proxy")
        {
        }


        public override void Run()
        {
            var bookStoreProxy = new BookStoreProxy();

            var page1 = bookStoreProxy.GetPage(1);
            Console.WriteLine(page1);

            var page2 = bookStoreProxy.GetPage(2);
            Console.WriteLine(page2);

            page1 = bookStoreProxy.GetPage(1);
            Console.WriteLine(page1);

            var page3 = bookStoreProxy.GetPage(3);
            Console.WriteLine(page3);

            page2 = bookStoreProxy.GetPage(2);
            Console.WriteLine(page2);

            page3 = bookStoreProxy.GetPage(3);
            Console.WriteLine(page3);
        }
    }
}