using System;

namespace EventsDelegatesPoC.Concepts
{
    /// <summary>
    /// Class to play with Actions
    /// The main difference between delegates and actions are
    /// <para> action delegates can be used with anonymous methods or lambda expressions </para>
    /// <para> action return type must be void. there's no other option, </para>
    /// <para> actions are faster to define then delegates. </para>
    /// </summary>
    public class ActionPerformer
    {
        public void ShowInteger(int x)
        {
            // the most simple usage of action. 
            // w/o it we might also use delegate but
            // we would have to create it above in
            // scope of our class and then use it.
            // with action it's much faster.
            Action<int> action = DisplayCustomInteger;
            action(x);

            // another way of implementing Action by
            // creating it's instance and passing through
            // constructor method that we want to point to.
            Action<int> newAction = new Action<int>(DisplayCustomInteger);
            newAction(x);

            // using lambda expression 
            Action<int> lambdaAction = i => { DisplayCustomInteger(i); };
            lambdaAction(x);

            // anonymous option
            Action<int> anonymousAction = delegate (int i)
            {
                Console.WriteLine("X: " + i.ToString());
            };
            anonymousAction(x);
        }

        private void DisplayCustomInteger(int x)
        {
            Console.WriteLine("X: " + x.ToString());
        }
    }
}
