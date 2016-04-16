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

            //var specifications = new List<ISpecification<Person>>();

            //if (contition1)
            //{
                //specifications.Add(PersonSpecification.GetByName("Name"));
            //}
            //if (contition1)
            //{
                //specifications.Add(PersonSpecification.GetByAge(25));
            //}

            //var specification = specifications.Aggregate((curr, next) => curr.And(next));

            var specification = PersonSpecification.GetByName("Name_10").And(PersonSpecification.GetByAge(0));

            //var person = GetByName(PersonSpecification.GetByName("Name"));

            return list.Where(specification.IsSatisfiedBy).ToList();
        }

        //private static IEnumerable<Person> GetByName(ISpecification<Person> spec)
        //{
        //    return _repo.GetAll(spec.Predicate);
        //}
    }
}