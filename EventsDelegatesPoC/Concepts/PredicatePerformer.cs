using System;

namespace ConsoleApp2.Concepts
{
    /// <summary>
    /// Predicates are delegates that takes only ONE input parameter
    /// and return boolean return type
    /// can also use lambda expressions and anonymous mechanism
    /// </summary>
    public class PredicatePerformer
    {
        public void CheckIfStringIsUpperCase(string str)
        {
            Predicate<string> isUpper = IsUpperCase;
            bool result = isUpper(str);

            Predicate<string> isUpperSpecial = new Predicate<string>(IsUpperCase);
            bool resultSpecial = isUpperSpecial(str);

            Predicate<string> isUpperLambda = x => IsUpperCase(x);
            bool resultLambda = isUpperLambda(str);

            Predicate<string> isUpperAnonymous = delegate (string x)
            {
                return IsUpperCase(x);
            };
            bool resultAnonymous = isUpperAnonymous(str);

            Console.WriteLine("IsUpper: " + result.ToString());
            Console.WriteLine("IsUpper: " + resultSpecial.ToString());
            Console.WriteLine("IsUpper: " + resultLambda.ToString());
            Console.WriteLine("IsUpper: " + resultAnonymous.ToString());
        }

        private bool IsUpperCase(string str)
        {
            return str.Equals(str.ToUpper());
        }
    }
}
