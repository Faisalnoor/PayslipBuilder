namespace Domain.Model
{
    /// <summary>
    ///     Tax slab defines the tax for the income.
    /// </summary>
    public class TaxSlab
    {
        public decimal MinimumIncome { get; set; }

        public decimal MaximumIncome { get; set; }

        public decimal BaseTax { get; set; }

        public decimal VariableTaxPercentage { get; set; }
    }
}
