using System;

namespace Exceptions
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter number: ");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine($"Successfull reading: {number}");

            }
            catch(FormatException ex)
            {
                Console.WriteLine($"Exception type: {ex.GetType()} \nMessage: {ex.Message}");
                Console.WriteLine($"Help link: {ex.HelpLink}");
                Console.WriteLine($"TargetSite: {ex.TargetSite}");
                Console.WriteLine($"StackTrace: {ex.StackTrace}");
            }
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Exception type: {ex.GetType()} \nMessage: {ex.Message}");
            //}
            finally //must be performed(виконатися) in any case
            {
                Console.WriteLine("Finally worked");
            }
        }
    }
}
