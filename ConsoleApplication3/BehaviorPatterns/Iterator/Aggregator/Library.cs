using System.Collections;
using DesignPatterns.BehaviorPatterns.Iterator.Iterator;

namespace DesignPatterns.BehaviorPatterns.Iterator.Aggregator
{
    public class Library : ILibraryEnumerable
    {
        private readonly Book[] _books;

        public int Count
        {
            get
            {
                return _books.Length;
            }
        }


        public Library(int bookCount)
        {
            _books = new Book[bookCount];
            for (var i = 0; i < bookCount; i++)
            {
                _books[i] = new Book("Book "+i);
            }
        }


        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _books.Length; i++)
            {
                yield return _books[i];
            }
            //return new BookIterator(this);
        }

        public Book this[int index]
        {
            get
            {
                return _books[index];
            }
        }
    }
}