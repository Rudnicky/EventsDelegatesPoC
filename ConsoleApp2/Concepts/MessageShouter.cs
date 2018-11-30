using System;

namespace ConsoleApp2.Concepts
{
    /// <summary>
    /// Creates delegates that return type is void 
    /// but they've got an argument 
    /// </summary>
    public class MessageShouter
    {
        private delegate void TellMeSomethingNice(string str);
        private delegate void TellMeSomethingWrong(string str);

        /// <summary>
        /// Starts whole Messageshouter process
        /// </summary>
        public void Start()
        {
            TellMeSomethingNice tellMeSomethingNice = NiceShout;
            TellMeSomethingWrong tellMeSomethingWrong = BadShout;

            tellMeSomethingNice("You're nice!");
            tellMeSomethingWrong("You're bad!");
        }

        private void NiceShout(string str)
        {
            Console.WriteLine(str);
        }

        private void BadShout(string str)
        {
            Console.WriteLine(str);
        }
    }
}
