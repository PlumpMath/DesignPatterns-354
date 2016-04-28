namespace DesignPatterns.BehaviorPatterns.Mediator.Mediator
{
    public class Manager : AbstractMediator
    {
        public Collegue.Collegue Programmer { get; set; }

        public Collegue.Collegue Tester { get; set; }

        public Collegue.Collegue Customer { get; set; }


        public override void Send(string msg, Collegue.Collegue collegue)
        {
            if (Programmer == collegue)
            {
                Tester.Notify(msg);
            }
            else if (Tester == collegue)
            {
                Customer.Notify(msg);
            }
            else if (Customer == collegue)
            {
                Programmer.Notify(msg);
            }
        }
    }
}