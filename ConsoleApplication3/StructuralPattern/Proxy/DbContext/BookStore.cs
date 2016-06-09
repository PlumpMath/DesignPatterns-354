using System.Collections.Generic;
using System.Linq;
using DesignPatterns.StructuralPattern.Proxy.Entities;

namespace DesignPatterns.StructuralPattern.Proxy.DbContext
{
    public class BookStore : IBook
    {
        private readonly List<Page> _pages;


        public BookStore()
        {
            // create data base context
            _pages = new List<Page>
            {
                new Page {Number = 1, Text = "Page 1"},
                new Page {Number = 2, Text = "Page 2"},
                new Page {Number = 3, Text = "Page 3"}
            };
        }


        public Page GetPage(int number)
        {
            // get from data base context
            return _pages.First(x => x.Number == number);
        }
    }
}