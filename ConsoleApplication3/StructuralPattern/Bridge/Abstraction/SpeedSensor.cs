using System;
using DesignPatterns.StructuralPattern.Bridge.BridgeInterface;

namespace DesignPatterns.StructuralPattern.Bridge.Abstraction
{
    public class SpeedSensor : SensorDevice
    {
        public SpeedSensor(ISensorInterface sensorInterface) : base(sensorInterface)
        {
        }


        public override string GetSensorInfo()
        {
            return "Speed Sensor";
        }

        public override void DoSomeWork()
        {
            Console.WriteLine("Speed Sensor Working");
        }
    }
}