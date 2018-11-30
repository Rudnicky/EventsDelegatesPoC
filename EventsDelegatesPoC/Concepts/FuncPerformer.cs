using System;

namespace EventsDelegatesPoC.Concepts
{
    /// <summary>
    /// Class to show how func works
    /// it's almost exaclty the same as actions
    /// yet it has to have return type not void like Actions
    /// can use lambda and anonymous methods.
    /// These are quite easy to use.
    /// </summary>
    public class FuncPerformer
    {
        public void DisplaySum(int x, int y)
        {
            // default usage 
            Func<int, int, int> Add = Sum;
            int result = Add(x, y);

            // lambda expression
            Func<int, int, int> AddSpecial = (a, b) => a + b;
            int specialResult = AddSpecial(x, y);

            // anonymous method
            Func<int, int, int> AddAnonymous = delegate (int a, int b)
            {
                return a + b;
            };
            int anonymResult = AddAnonymous(x, y);

            Console.WriteLine("Sum: " + result.ToString());
            Console.WriteLine("Sum: " + specialResult.ToString());
            Console.WriteLine("Sum: " + anonymResult.ToString());
        }

        private int Sum(int x, int y)
        {
            return x + y;
        }
    }
}
