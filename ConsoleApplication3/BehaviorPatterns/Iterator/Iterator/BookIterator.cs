using System.Collections;
using DesignPatterns.BehaviorPatterns.Iterator.Aggregator;

namespace DesignPatterns.BehaviorPatterns.Iterator.Iterator
{
    public class BookIterator : IEnumerator
    {
        private readonly ILibraryEnumerable _library;
        private int _index;


        public BookIterator(ILibraryEnumerable library)
        {
            _library = library;
        }


        public bool MoveNext()
        {
            return _index < _library.Count;
        }

        public void Reset()
        {
            _index = 0;
        }

        public object Current
        {
            get
            {
                return _library[_index++];
            }
        }
    }
}