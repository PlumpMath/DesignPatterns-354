using System.ComponentModel;
using DesignPatterns.CreationalPatterns.FactoryMethod.Creator;
using DesignPatterns.CreationalPatterns.FactoryMethod.Product;

namespace DesignPatterns.CreationalPatterns.FactoryMethod
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