using System;

namespace Boxing.Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] arr = { 100, 4,7, 12.5, "line", 'A', true, 3};
            double sum = 0;
            foreach (var item in arr)
            {
                Console.WriteLine(item);
                //if (item.GetType().Name == "Int32") // "int" - dont work
                //{
                //    sum += (int)item;
                //}
                //else if(item is double)
                //{
                //    sum += (double)item;
                //}
                switch (item)
                {
                    case int i when i<100: // 1)is int  2) i = (int)item
                        sum += i;
                        break;
                    case double i:
                        sum += i;
                        break;
                }
            }
            Console.WriteLine($"Sum: {sum}");



















        }
    }
}
