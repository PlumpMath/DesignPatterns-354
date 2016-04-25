using MyReceiver = DesignPatterns.BehaviorPatterns.ChainOfResponsibility.Receiver.Receiver;

namespace DesignPatterns.BehaviorPatterns.ChainOfResponsibility.Chain
{
    public abstract class PaymentHandler
    {
        public PaymentHandler Successor { get; set; }

        public abstract void Handle(MyReceiver receiver);
    }
}