using ConsoleApp2.Concepts;
using EventsDelegatesPoC.Concepts;
using System;

namespace EventsDelegatesPoC
{
    class Program
    {
        static void Main(string[] args)
        {
            // delegate void [name]
            CanMachine canMachine = new CanMachine();
            canMachine.Start();

            // delegate void [name] [arg]
            MessageShouter messageShouter = new MessageShouter();
            messageShouter.Start();

            // delegate [return type] [name] [args, ..., n]
            SalaryCounter salaryCounter = new SalaryCounter();
            salaryCounter.DisplayYearSalary(20, 40);
            salaryCounter.DisplayWeeklyWage(20);

            // delegate with events based on these delegates
            ComputerOperations computerOperations = new ComputerOperations();
            computerOperations.OnComputerStarted += ComputerOperations_OnComputerStarted;
            computerOperations.OnComputerClosed += ComputerOperations_OnComputerClosed;
            computerOperations.OnComputerCrashed += ComputerOperations_OnComputerCrashed;
            computerOperations.OnJustchecking += ComputerOperations_OnJustchecking;
            computerOperations.OnJustcheckingWithCustomArgs += ComputerOperations_OnJustcheckingWithCustomArgs;

            // these methods could be fired in any place
            // each of these methods invoke subscribed events.
            computerOperations.Start();
            computerOperations.Close();
            computerOperations.SomethingWentWrong();
            computerOperations.JustToCheckDefaultEventHandler();
            computerOperations.JustcheckingWithExtraArgs();

            // unsubscribe from these events, otherwise
            // garbage collector won't take these
            // strong references
            Unsubscribe(computerOperations);

            // Action<[type]> [name]
            ActionPerformer actionPerformer = new ActionPerformer();
            actionPerformer.ShowInteger(10);

            // Func<[arg], ..., [returnType]> [name]
            FuncPerformer funcPerformer = new FuncPerformer();
            funcPerformer.DisplaySum(10, 10);

            // Predicate<[arg]> [name]
            PredicatePerformer predicatePerformer = new PredicatePerformer();
            predicatePerformer.CheckIfStringIsUpperCase("Pawel");

            Console.ReadKey();
        }

        #region Private Methods
        private static void ComputerOperations_OnJustchecking(object sender, EventArgs e)
        {
            Console.WriteLine("Just Checking reached the holder!");
        }

        private static void ComputerOperations_OnComputerCrashed(string msg)
        {
            Console.WriteLine(msg);
        }

        private static void ComputerOperations_OnComputerClosed()
        {
            Console.WriteLine("Computer Closed!");
        }

        private static void ComputerOperations_OnComputerStarted()
        {
            Console.WriteLine("Computer Started!");
        }

        private static void ComputerOperations_OnJustcheckingWithCustomArgs(object sender, Utils.CustomEventArgs e)
        {
            Console.WriteLine("Just Checking reached the holder! ... with extra arguments");
        }

        private static void Unsubscribe(ComputerOperations computerOperations)
        {
            computerOperations.OnComputerStarted -= ComputerOperations_OnComputerStarted;
            computerOperations.OnComputerClosed -= ComputerOperations_OnComputerClosed;
            computerOperations.OnComputerCrashed -= ComputerOperations_OnComputerCrashed;
            computerOperations.OnJustchecking -= ComputerOperations_OnJustchecking;
            computerOperations.OnJustcheckingWithCustomArgs -= ComputerOperations_OnJustcheckingWithCustomArgs;
        }
        #endregion
    }
}
