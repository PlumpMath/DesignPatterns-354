using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.BehaviorPatterns.Iterator.Aggregator;

namespace DesignPatterns.BehaviorPatterns.Iterator.Iterator
{
    public class OneMoreBookIterator
    {
        private readonly ILibraryEnumerable _library;
        private int _index;


        public OneMoreBookIterator(ILibraryEnumerable library)
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

        public Book Current
        {
            get
            {
                return _library[_index++];
            }
        }
    }
}
