using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App014_SystemCollectionGeneric
{
    class Program
    {
        class Person
        {
            public int PersonId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        // Custom Generic Method
        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }


        // Generic Class
        public class Point<T> where T: new()    
        {
            private T xPos;
            private T yPos;

            public T X
            {
                get { return xPos; }
                set { xPos = value; }
            }

            public T Y
            {
                get { return yPos; }
                set { yPos = value; }
            }

            public Point(T xPos, T yPos)
            {
                this.xPos = xPos;
                this.yPos = yPos;
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("List<T>");

            // List<T> Generic Collection
            List<Person> people = new List<Person>()
                {
                    new Person{ PersonId = 1, FirstName= "Bilge", LastName= "Pamukcu"},
                    new Person{ PersonId=2, FirstName= "Andrew", LastName= "Porter"},
                    new Person{ PersonId=3, FirstName="Tedd", LastName="Broker" }
                };

            foreach (Person p in people)
            {
                Console.WriteLine($"Id = {p.PersonId}, First Name = {p.FirstName}, Last Name = {p.LastName}");
            }

            // Converted Generic List to Non-Generic ArrayList
            ArrayList peopleNonGeneric = new ArrayList(people);


            //-------------------------------------------------------------------------------


            Console.WriteLine("\nStack<T>");

            // Stack<T> Generic Collection (LIFO)
            Stack<Person> people2 = new Stack<Person>();
            people2.Push(new Person { PersonId=1, FirstName = "Bilge", LastName = "Pamukcu" });
            people2.Push(new Person { PersonId=2, FirstName = "Andrew", LastName = "Porter" });
            people2.Push(new Person { PersonId=3, FirstName = "Tedd", LastName = "Broker" });
            people2.Push(new Person { PersonId=4, FirstName = "Amy", LastName = "Stanley" });
            people2.Pop();

            foreach (Person p in people2)
            {
                Console.WriteLine($"Id = {p.PersonId}, First Name = {p.FirstName}, Last Name = {p.LastName}");
            }


            //-------------------------------------------------------------------------------


            Console.WriteLine("\nQueue<T>");

            // Queue<T> Generic Collection (FIFO)
            Queue<Person> people3 = new Queue<Person>();
            people3.Enqueue(new Person { PersonId = 1, FirstName = "Bilge", LastName = "Pamukcu" });
            people3.Enqueue(new Person { PersonId = 2, FirstName = "Andrew", LastName = "Porter" });
            people3.Enqueue(new Person { PersonId = 3, FirstName = "Tedd", LastName = "Broker" });
            people3.Enqueue(new Person { PersonId = 4, FirstName = "Amy", LastName = "Stanley" });
            people3.Dequeue();

            foreach (Person p in people3)
            {
                Console.WriteLine($"Id = {p.PersonId}, First Name = {p.FirstName}, Last Name = {p.LastName}");
            }

            //-------------------------------------------------------------------------------
            Console.WriteLine("\nCustom Generic Method Swap<T>");

            Person person1 = new Person { PersonId = 1, FirstName="Person1"};
            Person person2 = new Person { PersonId = 2, FirstName = "Person2" };

            Console.WriteLine("Before application of custom generic method Swap<T>");
            Console.WriteLine($"Id = {person1.PersonId}, First Name = {person1.FirstName}");
            Console.WriteLine($"Id = {person2.PersonId}, First Name = {person2.FirstName}");

            Swap<Person>(ref person1, ref person2);

            Console.WriteLine("\nAfter application of custom generic method Swap<T>");
            Console.WriteLine($"Id = {person1.PersonId}, First Name = {person1.FirstName}");
            Console.WriteLine($"Id = {person2.PersonId}, First Name = {person2.FirstName}");



            //-------------------------------------------------------------------------------

            // Using Generic Class
            Point<int> point1 = new Point<int>(2,7);
            Point<double> point2 = new Point<double>(2, 7);

            //-------------------------------------------------------------------------------

            Console.ReadLine();

        }
    }
}
