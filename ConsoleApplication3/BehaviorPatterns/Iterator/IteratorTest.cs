using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.BehaviorPatterns.Iterator.Aggregator;

namespace DesignPatterns.BehaviorPatterns.Iterator
{
    public class IteratorTest : PatternTest
    {
        public IteratorTest()
            : base("Iterator")
        {
        }


        public override void Run()
        {
            var library = new Library(10);

            Console.WriteLine("--Manual--");
            DoManual(library);
            Console.WriteLine("--Foreach--");
            DoForeach(library);
        }

        private static void DoManual(IEnumerable library)
        {
            var iterator = library.GetEnumerator();
            while (iterator.MoveNext())
            {
                Console.WriteLine(iterator.Current);
            }
        }

        private static void DoForeach(IEnumerable library)
        {
            foreach (var book in library)
            {
                Console.WriteLine(book);
            }
        }
    }
}