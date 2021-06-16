using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithTuples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=> fun with tuples");
            (string name, int age, string title) daughter = ("Joan", 8, "Miss");
            var son= (name:"Jason",age:11, title:"Master");
            //printing the tuples
            Console.WriteLine($"{son.title}  {son.name} is age:{son.age}");
            Console.WriteLine($"{daughter.title}  {daughter.name} is age:{daughter.age}");

            Console.WriteLine("=> infered tuples names");
            var foo = new { Prop1 = "first", Prop2 = "second" };
            var bar = (foo.Prop1, foo.Prop2);
            Console.WriteLine($"{bar.Prop1};{bar.Prop2}");

            Console.WriteLine("=> tuples as method return values");
            var samples = FillTheseValues();
            Console.WriteLine($"int is{samples.a}");
            Console.WriteLine($"string is {samples.b}");
            Console.WriteLine($"boolean is {samples.c}");


            Console.ReadLine();
        }

        private static (int a, string b,bool c) FillTheseValues()
        {
            return (9, "Enjoy your string", true);
        }
    }
}
