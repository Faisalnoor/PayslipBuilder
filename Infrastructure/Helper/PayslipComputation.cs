using Domain.Extensions;
using Infrastructure.Repository;

namespace Infrastructure.Helper
{
    public static class PayslipComputation
    {
        public static decimal GetGrossIncome(decimal annualIncome) =>
            decimal.Round(annualIncome / 12, 0);

        public static decimal GetIncomeTax(decimal annualIncome) =>
            TaxSlabRepository.GetTaxSlabByIncome(annualIncome).GetIncomeTax(annualIncome);

        public static decimal GetNetIncome(decimal grossIncome, decimal incomeTax) =>
            grossIncome - incomeTax;

        public static decimal GetSuper(decimal grossIncome, float superRate) =>
            decimal.Round(grossIncome * (decimal) (superRate / 100), 0);
    }
}
