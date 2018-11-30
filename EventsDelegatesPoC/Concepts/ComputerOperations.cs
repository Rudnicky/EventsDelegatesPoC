using EventsDelegatesPoC.Utils;
using System;

namespace EventsDelegatesPoC.Concepts
{
    /// <summary>
    /// Class shows how events and delegates
    /// are working together
    /// </summary>
    public class ComputerOperations
    {
        public delegate void ComputerStarted();
        public event ComputerStarted OnComputerStarted;

        public delegate void ComputerClosed();
        public event ComputerClosed OnComputerClosed;

        public delegate void ComputerCrashed(string msg);
        public event ComputerCrashed OnComputerCrashed;

        // EventHandler is a type of built-in delegate
        // it has two arguments by default which are
        // (object sender, EventArgs e)
        public event EventHandler OnJustchecking;

        // Another buil-in delegate with possibility
        // of applying our own arguments that 
        // inhertis from EventArgs
        // (object sender, CustomEventArgs e)
        public event EventHandler<CustomEventArgs> OnJustcheckingWithCustomArgs;

        #region Public Methods
        public void Start()
        {
            Console.WriteLine("Power On machine");

            // extra check if event is subscribed somewhere!
            OnComputerStarted?.Invoke();
        }

        public void Close()
        {
            Console.WriteLine("Performing closing machine");

            OnComputerClosed?.Invoke();
        }

        public void SomethingWentWrong()
        {
            Console.WriteLine("I'm going to crash this PC!!");

            OnComputerCrashed?.Invoke("Uuups!!");
        }

        public void JustToCheckDefaultEventHandler()
        {
            Console.WriteLine("Let's check if it works");

            OnJustchecking?.Invoke(this, new EventArgs());
        }

        public void JustcheckingWithExtraArgs()
        {
            Console.WriteLine("Let's see if it works with extra custom arguments");

            OnJustcheckingWithCustomArgs?.Invoke(this, new CustomEventArgs());
        }
        #endregion
    }
}
