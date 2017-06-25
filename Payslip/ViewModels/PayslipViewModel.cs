namespace Payslip.ViewModels
{
    public class PayslipViewModel
    {
        public PayslipViewModel(
            string name,
            string paymentPeriod,
            decimal grossIncome,
            decimal incomeTax,
            decimal netIncome,
            decimal super)
        {
            Name = name;
            PaymentPeriod = paymentPeriod;
            GrossIncome = grossIncome;
            IncomeTax = incomeTax;
            NetIncome = netIncome;
            Super = super;
        }

        public string Name { get; }
        public string PaymentPeriod { get; }
        public decimal GrossIncome { get; }
        public decimal IncomeTax { get; }
        public decimal NetIncome { get; }
        public decimal Super { get; }
    }
}