using System;
using DesignPatterns.CreationalPatterns.Builder.Builder;
using DesignPatterns.CreationalPatterns.Builder.Director;

namespace DesignPatterns.CreationalPatterns.Builder
{
    public class BuilderTest : PatternTest
    {
        public BuilderTest() : base("Builder")
        {
        }

        public override void Run()
        {
            Console.WriteLine("Manufactory Bread -> Bake:");
            BreadBuilder builder = new ManufactoryBreadBuilder();
            Bake(builder);

            Console.WriteLine("Home Bread -> Bake:");
            builder = new HomeBreadBuilder();
            Bake(builder);
        }

        private void Bake(BreadBuilder builder)
        {
            var baker = new Baker(builder);
            baker.Bake();
            Console.WriteLine(builder.Bread.ToString());
        }
    }
}