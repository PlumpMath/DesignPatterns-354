using System;

namespace DesignPatterns.BehaviorPatterns.ChainOfResponsibility.Chain
{
    public class BankPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver.Receiver receiver)
        {
            if (receiver.ViaBank)
            {
                Console.WriteLine("$"+ receiver.Amount + " Handle via Bank");
            }
            else if (Successor != null)
            {
                Successor.Handle(receiver);
            }
        }
    }
}