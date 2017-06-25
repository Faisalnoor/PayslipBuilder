using System.Collections.Generic;
using System.Linq;
using Domain.Model;
using Utilities.Exception;

namespace Infrastructure.Repository
{
    public static class TaxSlabRepository
    {
        /// <summary>
        ///     For demo simplicity purposes, we just use a List here. In a real application, 
        ///     this would access some sort of database, probably using Entity Framework.
        /// </summary>
        private static readonly List<TaxSlab> TaxSlabs = new List<TaxSlab>();

        static TaxSlabRepository()
        {
            TaxSlabs.Add(new TaxSlab
            {
                MinimumIncome = 0,
                MaximumIncome = 18200,
                BaseTax = 0,
                VariableTaxPercentage = 0
            });
            TaxSlabs.Add(new TaxSlab
            {
                MinimumIncome = 18201,
                MaximumIncome = 37000,
                BaseTax = 0,
                VariableTaxPercentage = 0.19m
            });
            TaxSlabs.Add(new TaxSlab
            {
                MinimumIncome = 37001,
                MaximumIncome = 80000,
                BaseTax = 3572,
                VariableTaxPercentage = 0.325m
            });
            TaxSlabs.Add(new TaxSlab
            {
                MinimumIncome = 80001,
                MaximumIncome = 180000,
                BaseTax = 17547,
                VariableTaxPercentage = 0.37m
            });
            TaxSlabs.Add(new TaxSlab
            {
                MinimumIncome = 180001,
                MaximumIncome = decimal.MaxValue,
                BaseTax = 54547,
                VariableTaxPercentage = 0.45m
            });
        }
        
        /// <summary>
        ///     Get all tax slabs
        /// </summary>
        public static IEnumerable<TaxSlab> GetTaxSlabs()
        {
            return TaxSlabs;
        }

        /// <summary>
        ///     Get tax slab by income
        /// </summary>
        public static TaxSlab GetTaxSlabByIncome(decimal income)
        {
            return TaxSlabs
                .Where(x => income >= x.MinimumIncome && income <= x.MaximumIncome)
                .InvalidDataExceptionIfNotMatched(1)
                .Single();
        }
    }
}
