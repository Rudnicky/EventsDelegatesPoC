namespace EventsDelegatesPoC.Concepts
{
    /// <summary>
    /// Conceptual class to show how to use delegates
    /// that can return something and get some arguments
    /// </summary>
    public class SalaryCounter
    {
        #region Fields
        private const int DAYS = 365;
        private const int AVARAGE_WEEKS = 52;
        private const int FULLTIME = 40;

        // these are created in that way and initialized 
        // in constructor because it doesn't know yet
        // about these functions. Unless these foos
        // might be static then it's fine.
        private readonly ComputeYear _computeYear;
        private readonly ComputeWeekly _computeweekly;
        #endregion

        #region Delegates
        // [delegate] [return type] [name] [arguments, ..., x]
        private delegate double ComputeYear(double x, double y);
        private delegate double ComputeWeekly(double x);
        #endregion

        #region Constructor
        public SalaryCounter()
        {
            _computeYear = ComputYearSalary;
            _computeweekly = ComputeWeeklyWage;
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Computes year salary by given values
        /// </summary>
        /// <param name="moneyPerHour"></param>
        /// <param name="hoursPerWeek"></param>
        public void DisplayYearSalary(double moneyPerHour, double hoursPerWeek)
        {
            var output = _computeYear(moneyPerHour, hoursPerWeek);
            System.Console.WriteLine("Computed value per year: " + output.ToString());
        }

        /// <summary>
        /// Computes weekly wage by given value
        /// </summary>
        /// <param name="moneyPerHour"></param>
        public void DisplayWeeklyWage(double moneyPerHour)
        {
            var output = _computeweekly(moneyPerHour);
            System.Console.WriteLine("Computed value per week: " + output.ToString());
        }
        #endregion

        #region Private Methods
        private double ComputYearSalary(double moneyPerHour, double hoursPerWeek)
        {
            return moneyPerHour * hoursPerWeek * AVARAGE_WEEKS;
        }

        private double ComputeWeeklyWage(double moneyPerHour)
        {
            return moneyPerHour * FULLTIME;
        }
        #endregion
    }
}
