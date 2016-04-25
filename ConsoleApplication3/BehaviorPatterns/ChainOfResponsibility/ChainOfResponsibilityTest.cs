using System;
using DesignPatterns.BehaviorPatterns.ChainOfResponsibility.Chain;
using MyReceiver = DesignPatterns.BehaviorPatterns.ChainOfResponsibility.Receiver.Receiver;

namespace DesignPatterns.BehaviorPatterns.ChainOfResponsibility
{
    public class ChainOfResponsibilityTest : PatternTest
    {
        public ChainOfResponsibilityTest() : base("Chain Of Responsibiliry")
        {
        }


        public override void Run()
        {
            var receiver = new MyReceiver(true, true, true, 10);

            var payPalHandler = new PayPalPaymentHandler();
            var westernHandler = new WesternUnionPaymentHandler();
            var bankHandler = new BankPaymentHandler();

            Console.WriteLine("Priority: bank, western, paypal");

            westernHandler.Successor = payPalHandler;
            bankHandler.Successor = westernHandler;

            Console.WriteLine("Bank:");
            bankHandler.Handle(receiver);

            receiver = new MyReceiver(false, true, true, 100);
            Console.WriteLine("Western:");
            bankHandler.Handle(receiver);

            receiver = new MyReceiver(false, false, true, 1000);
            Console.WriteLine("PayPal:");
            bankHandler.Handle(receiver);
        }
    }
}