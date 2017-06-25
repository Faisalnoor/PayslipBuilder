using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Domain.Model;
using Infrastructure.Helper;
using Payslip.ViewModels;
using Utilities.Exception;
using Utilities.FunctionalLogic;

namespace Payslip.Controllers
{
    public class PayslipController : Controller
    {
        public ActionResult GeneratePayslip(IEnumerable<Employee> employees)
        {
            var payslips = employees
                .InvalidDataExceptionIfNullOrEmpty()
                .Select(emp => emp
                    .ToResult("Invalid employee data")
                    .OnSuccess(e => new PaySlip(e))
                    .OnSuccess(p => p.SetGrossIncome(PayslipComputation.GetGrossIncome(emp.AnnualSalary)))
                    .OnSuccess(p => p.SetIncomeTax(PayslipComputation.GetIncomeTax(emp.AnnualSalary)))
                    .OnSuccess(p => p.SetNetIncome(PayslipComputation.GetNetIncome(p.GrossIncome, p.IncomeTax)))
                    .OnSuccess(p => p.SetSuper(PayslipComputation.GetSuper(p.GrossIncome, emp.SuperRate))))
                .Select(x =>
                {
                    var employee = x.Value.Employee;
                    var paySlip = x.Value;

                    return new PayslipViewModel(
                        employee.FullName,
                        employee.PaymentPeriod,
                        paySlip.GrossIncome,
                        paySlip.IncomeTax,
                        paySlip.NetIncome,
                        paySlip.Super);
                })
                .ToList();

            return Json(payslips);
        }
    }
}