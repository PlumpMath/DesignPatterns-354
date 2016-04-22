using System.Collections;

namespace DesignPatterns.BehaviorPatterns.Iterator.Aggregator
{
    public interface ILibraryEnumerable : IEnumerable
    {
        int Count { get; }

        Book this[int index] { get; }
    }
}