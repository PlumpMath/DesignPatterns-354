using System;
using System.Collections.Generic;
using System.Linq;
using DesignPatterns.StructuralPattern.Proxy.DbContext;
using DesignPatterns.StructuralPattern.Proxy.Entities;

namespace DesignPatterns.StructuralPattern.Proxy.BookProxy
{
    public class BookStoreProxy : IBook
    {
        private readonly List<Page> _pages;
        private BookStore _bookStore;


        public BookStoreProxy()
        {
            _pages = new List<Page>();
        }


        public Page GetPage(int number)
        {
            var page = _pages.FirstOrDefault(x => x.Number == number);
            if (page == null)
            {
                if (_bookStore == null)
                {
                    _bookStore = new BookStore();
                }
                Console.WriteLine("Get page number: {0} from DBContext:", number);
                page = _bookStore.GetPage(number);
                _pages.Add(page);
            }
            return page;
        }
    }
}