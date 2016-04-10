using System.ComponentModel;
using DesignPatterns.GenerativePatterns.FactoryMethod.Creator;
using DesignPatterns.GenerativePatterns.FactoryMethod.Product;

namespace DesignPatterns.GenerativePatterns.FactoryMethod
{
    public class FactorMethodTest : PatternTest
    {
        public FactorMethodTest() : base("FactoryMethod")
        {
            
        }


        private static Developer GetDeveloper(DeveloperType developerType)
        {
            switch (developerType)
            {
                case DeveloperType.Panel:
                    return new PanelDeveloper();
                case DeveloperType.Wood:
                    return new WoodDeveloper();
                default:
                    throw new InvalidEnumArgumentException("developerType");
            }
        }

        public override void Run()
        {
            Developer dev = GetDeveloper(DeveloperType.Panel);
            House house = dev.Create();

            dev = GetDeveloper(DeveloperType.Wood);
            house = dev.Create();
        }
    }


    public enum DeveloperType
    {
        Panel,
        Wood
    }
}