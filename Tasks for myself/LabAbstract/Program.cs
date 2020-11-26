using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAbstract
{
    class Program
    {
        static void Main(string[] args)
        {

            string s1 = "boo";
            string s2 = "for";
            string s3 = "boo";
            string s4 = "rrr";

            Console.WriteLine(s1 == s3);
            Console.WriteLine(s2 == s4);
            Console.WriteLine((Object)s1 == (Object)s2);
            Console.WriteLine((Object)s1 == (Object)s2);


            List<int> numbers = new List<int>() {1, 2, 3 , 4, 6, 7};


            Utility util = new Utility();
            Console.WriteLine(util.ManataToQepik(128.46787));

            //Man man = new Man("I am a man");
            //Woman woman = new Woman("I am a woman");

            //Person cabbar = new Person("Cabbar", "Hasanov", 21);
            //Person rauf = new Person("Rauf", "Rafizade", 20);
            //Console.WriteLine(rauf == cabbar);

            Eagle eagle = new Eagle();
            // upcasting
            object shark = new Shark();

            //Animal eagle1 = eagle; also called implicit casting
            int x = 5;
            //object y = x;
            
            //downcasting ==>> which is dangerous
            Bird b1 = new Eagle();
            //Eagle e1 = (Eagle)b1; also called explicit casting

            Shark sh = new Shark();

            object[] animals = { eagle, sh, b1, x };
            foreach (var animal in animals)
            {
                if(animal is Eagle)
                {
                    Console.WriteLine("that is an eagle");
                }
                else
                {
                    Console.WriteLine("not even close");
                }
            }
            //secure downcasting - 1 >>> cevire bilirse ozunu bilmirse null qaytaracaq
            if (b1 as Eagle != null)
            {
                Eagle e1 = (Eagle)b1;
            }
            else
            {
                Console.WriteLine("not an eagle");
            }

            // secure casting - 2 >>> yalniz true false qaytarir
            if (b1 is Eagle)
            {
                Eagle e1 = (Eagle)b1;
                Console.WriteLine("Cast eledim");
            }
            else
            {
                Console.WriteLine("not an eagle");
            }
                
        }

        class Utility
        {
            public int ManataToQepik(double inputVal)
            {
                return (int)(inputVal * 100);
            }
        }

        #region Abstraction
        abstract class Human
        {
            public Human(string text)
            {
                Console.WriteLine(text);
            }
            public string Name;

            public string Surname;

            public bool Gender;

            public abstract void Eat();

            public void Test()
            {
                Console.WriteLine("this is method");
            }

        }

        class Man : Human
        {
            public Man(string t):base(t) { }

            public override void Eat()
            {
                Console.WriteLine("Man eat wildly");
            }
        }

        class Woman : Human
        {
            public Woman(string t):base(t) { }

            public override void Eat()
            {
                Console.WriteLine("woman eat more wildly");
            }
        }
        #endregion

        #region Custom Type operators
        class Person
        {
            public Person(string name, string surname, int age)
            {
                Name = name;
                Surname = surname;
                Age = age;
            }

            public string Name { get; set; }

            public string Surname { get; set; }

            public int Age { get; set; }

            public static bool operator > (Person p1, Person p2)
            {
                return p1.Name.Length > p2.Name.Length;
            }

            public static bool operator < (Person p1, Person p2)
            {
                return p1.Age < p2.Age;
            }

            public static bool operator == (Person p1, Person p2)
            {
                return p1.Age == p2.Age;
            }

            public static bool operator !=(Person p1, Person p2)
            {
                return p1.Age != p2.Age;
            }


        }
        #endregion

        #region Polymorphism, Casting
        abstract class Animal
        {
            public abstract void Eat();
        }

        abstract class Fish : Animal
        {
            public abstract void Swim();
        }

        abstract class Bird : Animal
        {
            public abstract void Fly();
        }

        class Shark : Fish
        {
            public int Weight { get; set; }
            public int SwimmingSpeed { get; set; }

            public override void Eat()
            {
                Console.WriteLine("fish is eating"); ;
            }

            public override void Swim()
            {
                Console.WriteLine("fish is swimming"); ;
            }
        }

        class Eagle : Bird
        {
            public int FlyingSpeed { get; set; }

            public override void Eat()
            {
                Console.WriteLine("bird is eating");
            }

            public override void Fly()
            {
                Console.WriteLine("bird is flying"); ;
            }
        }

        class Duck : Bird
        {
            public override void Eat()
            {
                Console.WriteLine("bird is eating"); ;
            }

            public override void Fly()
            {
                Console.WriteLine("bird is flying"); ;
            }
        }
        #endregion
    }
}
