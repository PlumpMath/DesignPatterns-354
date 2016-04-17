using DesignPatterns.BehaviorPatterns.Observer.Observable;
using DesignPatterns.BehaviorPatterns.Observer.Observer;

namespace DesignPatterns.BehaviorPatterns.Observer
{
    public class ObserverTest : PatternTest
    {
        public ObserverTest() : base("Observer")
        {

        }


        public override void Run()
        {
            var stock = new Stock();

            var bank = new Bank(stock);
            var broker = new Broker(stock);

            stock.Market();

            broker.StopObserve();

            stock.Market();
        }
    }
}