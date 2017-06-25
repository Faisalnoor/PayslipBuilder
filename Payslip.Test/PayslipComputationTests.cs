using Domain.Extensions;
using Infrastructure.Helper;
using Infrastructure.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Payslip.Test
{
    [TestClass]
    public class PayslipComputationTests
    {
        [TestMethod]
        public void GetTaxSlab()
        {
            var taxSlab = TaxSlabRepository.GetTaxSlabByIncome(60050);

            Assert.IsNotNull(taxSlab);
            Assert.AreEqual(taxSlab.BaseTax, 3572);
            Assert.AreEqual(taxSlab.VariableTaxPercentage, 0.325m);
            Assert.AreEqual(taxSlab.MinimumIncome, 37001);
            Assert.AreEqual(taxSlab.MaximumIncome, 80000);
        }

        [TestMethod]
        public void GetIncomeTax()
        {
            var incomeTax = TaxSlabRepository
                .GetTaxSlabByIncome(60050)
                .GetIncomeTax(60050);
            
            Assert.AreEqual(incomeTax, 922);
        }

        [TestMethod]
        public void GetGrossIncome()
        {
            var grossIncome = PayslipComputation.GetGrossIncome(60050);
            Assert.AreEqual(grossIncome, 5004);
        }

        [TestMethod]
        public void GetNetIncome()
        {
            var netIncome = PayslipComputation.GetNetIncome(5004, 922);
            Assert.AreEqual(netIncome, 4082);
        }

        [TestMethod]
        public void GetSuper()
        {
            var super = PayslipComputation.GetSuper(5004, 9);
            Assert.AreEqual(super, 450);
        }
    }
}
