using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DesignPatterns.CreationalPatterns.Prototype
{
    [Serializable]
    public abstract class Shape
    {
        public abstract string GetInfo();

        public Shape DeepCopy()
        {
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, this);

                ms.Seek(0, SeekOrigin.Begin);

                return formatter.Deserialize(ms) as Shape;
            }
        }
    }
}