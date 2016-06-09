using DesignPatterns.StructuralPattern.Proxy.Entities;

namespace DesignPatterns.StructuralPattern.Proxy.DbContext
{
    public interface IBook
    {
        Page GetPage(int number);
    }
}