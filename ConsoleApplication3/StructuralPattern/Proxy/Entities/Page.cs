namespace DesignPatterns.StructuralPattern.Proxy.Entities
{
    public class Page
    {
        public int Id { get; set; }

        public int Number { get; set; }

        public string Text { get; set; }


        public override string ToString()
        {
            return string.Format("Number: {0}, Text: {1}", Number, Text);
        }
    }
}