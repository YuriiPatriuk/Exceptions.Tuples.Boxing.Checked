using System;

namespace Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Class  immutable
            Tuple<int, string> t = new Tuple<int, string>(100,"Yarik"); //heap(class)
            Console.WriteLine($"{t.Item1} --- {t.Item2}");
            //t.Item1 = 100; - dont work

            //int @int = 100;

            var tuple = t.ToValueTuple();// stack(structure)
            tuple.Item1 = 200;
            Console.WriteLine($"{tuple.Item1} --- {tuple.Item2}");

            (int id, string name) = tuple;

            Console.WriteLine($"{id} : {name}");

            var t2 = (Name: "Anton", Phone: "0987654321");// ValueTuple   Item1 = Name, Item2 = Phone
            t2.Name = "Anton A";
            Console.WriteLine($"{t2.Name} - {t2.Phone}");
            

        }
    }
}
