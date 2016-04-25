namespace DesignPatterns.BehaviorPatterns.ChainOfResponsibility.Receiver
{
    public class Receiver
    {
        public bool ViaBank { get; private set; }

        public bool ViaWesternUnion { get; private set; }

        public bool ViaPayPal { get; private set; }

        public decimal Amount { get; private set; }


        public Receiver(bool viaBank, bool viaWesternUnion, bool viaPayPal, decimal amount)
        {
            ViaBank = viaBank;
            ViaWesternUnion = viaWesternUnion;
            ViaPayPal = viaPayPal;
            Amount = amount;
        }
    }
}