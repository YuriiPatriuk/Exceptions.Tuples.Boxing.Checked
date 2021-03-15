using System;
using System.Collections;
//using System.Collections.Generic;

namespace Exception_Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            try
            {
                account.Login = "abc";

            }
            catch (LoginException ex) when (ex.Message.Length>5)
            {
                Console.WriteLine($"Message: {ex.Message}");
                Console.WriteLine($"HelpLink: {ex.HelpLink}");
                Console.WriteLine($"TargetSite: {ex.TargetSite}");
                Console.WriteLine($"StackTrace: {ex.StackTrace}");
                foreach (DictionaryEntry item in ex.Data)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }



        }
    }
}
