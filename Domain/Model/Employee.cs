namespace Domain.Model
{
    public class Employee
    {
        /// <summary>
        ///     Employee first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        ///     Employee last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        ///     Employee full name
        /// </summary>
        public string FullName => $"{FirstName} {LastName}";

        /// <summary>
        ///     Employee annual salary
        /// </summary>
        public decimal AnnualSalary { get; set; }

        /// <summary>
        ///     Employee super rate
        /// </summary>
        public float SuperRate { get; set; }

        /// <summary>
        ///     Employee payment period
        /// </summary>
        public string PaymentPeriod { get; set; }
    }
}
