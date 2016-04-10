using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.OtherPatterns.Specification.Test
{
    public class SpecificationTest : PatternTest
    {
        public SpecificationTest() : base("Specification")
        {
        }


        public override void Run()
        {
            var list = GetFilteredList();

            foreach (var person in list)
            {
                Console.WriteLine(person);
            }
        }

        private static IEnumerable<Person> GetData()
        {
            var list = new List<Person>();

            for (int i = 0; i < 20; i++)
            {
                list.Add(new Person{Age = 10+i, Name = "Name_" + i});
            }

            return list;
        }

        private static IEnumerable<Person> GetFilteredList()
        {
            var list = GetData();

            var nameSpec = new PersonNameSpecification("Name_10");
            var ageSpec = new PersonAgeSpecification(0);

            var s = nameSpec.And(ageSpec);

            return list.Where(s.IsSatisfiedBy).ToList();
        }
    }
}