using System;

namespace ConsoleApp2
{
    /// <summary>
    /// Conceptual class to show how to use void 
    /// simple delegates 
    /// </summary>
    internal class CanMachine
    {
        // declare delegate that's not returning anything
        // it's just the pointer for an void function
        private delegate void MyDelegateForCustomVoidFunction();

        /// <summary>
        /// Starts whole machine process
        /// </summary>
        internal void Start()
        {
            // create instances of our delegates 
            // and assign them to chosen functions
            MyDelegateForCustomVoidFunction firstDelegate = CokeMessage;
            MyDelegateForCustomVoidFunction secondDelegate = SpriteMessage;
            MyDelegateForCustomVoidFunction thirdDelegate = FantaMessage;

            Messages.DisplayCanOptions();

            Can can;

            do
            {
                Console.WriteLine(Messages.AskAboutCan);
                can = (Can)Convert.ToInt32(Console.ReadLine());

                switch (can)
                {
                    case Can.CocaCola:
                        firstDelegate();
                        break;
                    case Can.Sprite:
                        secondDelegate();
                        break;
                    case Can.Fanta:
                        thirdDelegate();
                        break;
                    default:
                        break;
                }
            } while (can != Can.Default);
        }

        private void CokeMessage()
        {
            Console.WriteLine("You've chosen Coke");
        }

        private void SpriteMessage()
        {
            Console.WriteLine("You've chosen Sprite");
        }

        private void FantaMessage()
        {
            Console.WriteLine("You've chosen Fanta");
        }
    }
}
