using System;
using System.Collections.Generic;
using System.Linq;

namespace RobotMoving
{
    class Program
    {
        static void Main(string[] args)
        {
            LinqTest tt = new LinqTest(); 
            tt.test();
            var exit = false;
            Console.WriteLine("Welcome to the Robot Moving App! ");
            Console.WriteLine("Type the valid Command:PLACE X,Y,NORTH /Move/Left/Right/Report ");
            Robot robotA = new Robot();
            while (exit == false)
            {
                string cmdargs;
                robotA.RunConsoleCommand(CommandHelper.CommParse(Console.ReadLine(), out cmdargs), cmdargs);
                //CommandHelper.CommandExecute(robotA, CommandHelper.CommParse(Console.ReadLine(), out cmdargs), cmdargs);
            }

        }


        

    }

    internal class LinqTest
    {
        //    Person magnus = new Person() { FirstName = "Magnus", LastName= "Hedlund" };
        //    Person terry = new Person() { FirstName = "Terry", LastName = "Adams" };
        //    Person charlotte = new Person() { FirstName = "Charlotte", LastName = "Weiss" };
        //    Person arlene = new Person() { FirstName = "Arlene", LastName = "Huff" };
        //    Person rui = new Person() { FirstName = "Rui", LastName = "Raposo" };

        public void test()
        {
            List<Person> people = new List<Person>() {
        new Person() { FirstName = "Magnus", LastName= "Hedlund" },
        new Person() { FirstName = "Terry", LastName = "Adams" },
        new Person() { FirstName = "Charlotte", LastName = "Weiss" },
        new Person() { FirstName = "Arlene", LastName = "Huff" },
        new Person() { FirstName = "Rui", LastName = "Raposo" }
        };

            List<Pet> pets = new List<Pet>()
        {
            new Pet(){ Name="Barley", Owner=new Person() { FirstName = "Terry", LastName = "Adams" } },
            new Pet(){ Name="Boots",  Owner=new Person() { FirstName = "Terry", LastName = "Adams" } },
            new Pet(){ Name="Whiskers", Owner=new Person() { FirstName = "Charlotte", LastName = "Weiss" } },
            new Pet(){ Name="Blue Moon", Owner=new Person() { FirstName = "Rui", LastName = "Raposo" } },
            new Pet(){ Name="Daisy", Owner=new Person() { FirstName = "Magnus", LastName= "Hedlund" } }
        };

            var q = from person in people
                    join pt in pets on person equals pt.Owner
                    select new
                    {
                        PetName = pt.Name,
                        OwnerFirstname = person.FirstName
                        ,
                        OwnerLastname = person.LastName
                    };

            foreach(var x in q)
            {
                Console.WriteLine(x.PetName);
                Console.WriteLine(x.OwnerFirstname);
                Console.WriteLine(x.OwnerLastname);
            }


        }



    }

    internal class Pet
    {
        public string Name { get; set; }
        public Person Owner { get; set; }

    }

    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
