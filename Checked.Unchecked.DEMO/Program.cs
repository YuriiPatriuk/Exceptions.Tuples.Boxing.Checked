using System;

namespace Checked.Unchecked.DEMO
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 250, b=2;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{a}---------{b}");
                try
                {
                    //checked працює тільки на цілочисельні типи
                    checked //буде вийняток якщо перетинається межа типу(верхня чи нижня)
                    {
                        ++a;
                        unchecked
                        {
                            --b;
                        }
                    }
                }
                catch(OverflowException ex)
                {
                    Console.WriteLine("\t"+ex.Message);
                    a = 0;
                }
                
            }
            byte value = 250;
            byte res =checked( (byte)(value + 10));
            Console.WriteLine(res);
        }
    }
}
