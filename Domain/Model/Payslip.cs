namespace Domain.Model
{
    public class PaySlip
    {
        public PaySlip(Employee employee)
        {
            Employee = employee;
        }

        /// <summary>
        ///     Employee  details
        /// </summary>
        public Employee Employee { get; }
        
        /// <summary>
        ///     Employee gross income
        /// </summary>
        public decimal GrossIncome { get; private set; }

        /// <summary>
        ///     Employee net income
        /// </summary>
        public decimal NetIncome { get; private set; }

        /// <summary>
        ///     Employee super
        /// </summary>
        public decimal Super { get; private set; }

        /// <summary>
        ///     Employee income tax
        /// </summary>
        public decimal IncomeTax { get; private set; }


        public virtual void SetGrossIncome(decimal grossIncome)
        {
            GrossIncome = grossIncome;
        }
        
        public virtual void SetIncomeTax(decimal incomeTax)
        {
            IncomeTax = incomeTax;
        }

        public virtual void SetNetIncome(decimal netIncome)
        {
            NetIncome = netIncome;
        }

        public virtual void SetSuper(decimal super)
        {
            Super = super;
        }

    }
}
