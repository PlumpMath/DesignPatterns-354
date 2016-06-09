namespace DesignPatterns.StructuralPattern.Bridge.BridgeInterface
{
    public class SpeedSensorImpl : ISensorInterface
    {
        public string GetData()
        {
            return "100 from Company XXX";
        }
    }
}