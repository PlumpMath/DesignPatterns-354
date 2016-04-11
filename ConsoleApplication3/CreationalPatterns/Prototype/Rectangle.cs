using System;

namespace DesignPatterns.CreationalPatterns.Prototype
{
    [Serializable]
    public class Rectangle : Shape
    {
        public Point Point { get; set; }

        public Rectangle(int x, int y)
        {
            Point = new Point(x, y);
        }

        public override string GetInfo()
        {
            return string.Format("Rectange - X={0} Y={1}", Point.X, Point.Y);
        }
    }
}