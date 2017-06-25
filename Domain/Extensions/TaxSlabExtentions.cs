using Domain.Model;

namespace Domain.Extensions
{
    public static class TaxSlabExtentions
    {
        /// <summary>
        ///     Calculate monthly income tax
        /// </summary>
        public static decimal GetIncomeTax(this TaxSlab taxSlab, decimal income)
        {
            var incomeTax =
                (taxSlab.BaseTax + ((income - (taxSlab.MinimumIncome - 1)) * taxSlab.VariableTaxPercentage)) / 12;

            return decimal.Round(incomeTax, 0);
        }
    }
}
