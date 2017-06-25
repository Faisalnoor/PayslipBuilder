using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Domain.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Payslip.Controllers;
using Payslip.ViewModels;

namespace Payslip.Test
{
    [TestClass]
    public class PayslipControllerTests
    {
        private readonly List<Employee> _employees = new List<Employee>();

        [TestInitialize]
        public void Initialise()
        {
            _employees.Add(new Employee
            {
                FirstName = "David",
                LastName = "Rudd",
                AnnualSalary = 60050,
                SuperRate = 9,
                PaymentPeriod = "01 March - 31 March"
            });

            _employees.Add(new Employee
            {
                FirstName = "Ryan",
                LastName = "Chen",
                AnnualSalary = 120000,
                SuperRate = 10,
                PaymentPeriod = "01 March - 31 March"
            });
        }

        [TestMethod]
        public void GeneratePayslips()
        {
            var controller = new PayslipController();
            var payslips = controller.GeneratePayslip(_employees) as JsonResult;
            var payslipViewModels = payslips?.Data as List<PayslipViewModel>;

            var davidPayslips = payslipViewModels?.Single(x => x.Name == "David Rudd");
            var ryanPayslips = payslipViewModels?.Single(x => x.Name == "Ryan Chen");

            Assert.IsNotNull(payslipViewModels);
            
            //
            Assert.AreEqual(davidPayslips?.GrossIncome, 5004);
            Assert.AreEqual(davidPayslips?.IncomeTax, 922);
            Assert.AreEqual(davidPayslips?.NetIncome, 4082);
            Assert.AreEqual(davidPayslips?.Super, 450);

            //
            Assert.AreEqual(ryanPayslips?.GrossIncome, 10000);
            Assert.AreEqual(ryanPayslips?.IncomeTax, 2696);
            Assert.AreEqual(ryanPayslips?.NetIncome, 7304);
            Assert.AreEqual(ryanPayslips?.Super, 1000);
        }
    }
}
