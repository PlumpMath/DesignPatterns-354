using DesignPatterns.StructuralPattern.Bridge.BridgeInterface;

namespace DesignPatterns.StructuralPattern.Bridge.Abstraction
{
    public abstract class SensorDevice
    {
        public ISensorInterface SensorInterface;


        protected SensorDevice(ISensorInterface sensorInterface)
        {
            SensorInterface = sensorInterface;
        }


        public virtual string GetSensorData()
        {
            return SensorInterface.GetData();
        }

        public abstract string GetSensorInfo();

        public abstract void DoSomeWork();
    }
}