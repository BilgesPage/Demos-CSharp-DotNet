using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App021_SystemType
{
    class People : IEnumerable, IDisposable
    {
        Person[] people = {
                new Person{ Name = "Person01" },
                new Person{ Name = "Person02" },
                new Person{ Name = "Person03" },
                new Person{ Name = "Person04" },
            };

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            return people.GetEnumerator();
        }
    }

    class Person : IDisposable
    {
        public string Name { get; set; }

        public void Dispose()
        {
            Console.WriteLine("Person has disposed");
        }

        public void PersonMethod01() => Console.WriteLine("PersonMethod01 executed.");
        public void PersonMethod02() => Console.WriteLine("PersonMethod02 executed.");
        public void PersonMethod03() => Console.WriteLine("PersonMethod03 executed.");
    }

    static class MetaDataViewer
    {
        public static void ListMethods(Type t)
        {
            var methodNames = t.GetMethods();
            foreach (var name in methodNames)
            {
                Console.WriteLine(name);
            }
        }

        public static void ListProperties(Type t)
        {
            var properties = t.GetProperties();
            foreach (var name in properties)
            {
                Console.WriteLine(name);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Consuming GetType() method
            Person person = new Person();
            Console.WriteLine($"myGroup.GetType().Name: {person.GetType().Name}");
            Console.WriteLine($"myGroup.GetType().Namespace: {person.GetType().Namespace}");
            Console.WriteLine($"myGroup.GetType().IsValueType: {person.GetType().IsValueType}");
            Console.WriteLine($"myGroup.GetType().IsNested: {person.GetType().IsNested}");

            MetaDataViewer.ListMethods(person.GetType());
            MetaDataViewer.ListProperties(person.GetType());



            Console.ReadLine();
        }
    }
}
