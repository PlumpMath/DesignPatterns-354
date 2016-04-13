using System.Text;

namespace DesignPatterns.CreationalPatterns.Builder.Product
{
    public class Bread
    {
        public Flour Flour { get; set; }

        public Salt Salt { get; set; }

        public Additives Additives { get; set; }


        public override string ToString()
        {
            var sb = new StringBuilder();

            if (Flour != null)
            {
                sb.AppendLine(Flour.Sort);
            }
            if (Salt != null)
            {
                sb.AppendLine("Соль");
            }
            if (Additives != null)
            {
                sb.AppendLine(Additives.Name);
            }

            return sb.ToString();
        }
    }
}