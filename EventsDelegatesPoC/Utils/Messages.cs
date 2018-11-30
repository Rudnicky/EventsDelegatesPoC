using System;

namespace EventsDelegatesPoC
{
    internal static class Messages
    {
        internal static void DisplayCanOptions()
        {
            Console.WriteLine("You can choose: ");
            Console.WriteLine("0 - Exit");
            Console.WriteLine("1 - CocaCola");
            Console.WriteLine("2 - Sprite");
            Console.WriteLine("3 - Fanta");
        }

        internal static string AskAboutCan = "Which Can do you want?";
    }
}
