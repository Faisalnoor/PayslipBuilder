define('indexPage', ['ajax'], function (ajax) {
    'use strict';

    ajax.setErrorPrefix("There was an error. Please try again.");

    var buildPayslips = function (payslips) {
        $("#payslip-container tbody").empty();

        for (var payslip in payslips) {
            if (payslips.hasOwnProperty(payslip)) {
                var item = payslips[payslip];
                var row = '<tr>' +
                    '<td>' + item.Name + '</td>' +
                    '<td>' + item.PaymentPeriod + '</td>' +
                    '<td>' + item.GrossIncome + '</td>' +
                    '<td>' + item.IncomeTax + '</td>' +
                    '<td>' + item.NetIncome + '</td>' +
                    '<td>' + item.Super + '</td>' +
                    '</tr>';

                $('#payslip-container tbody').append(row);
                $('#payslip-container').show();
            }
        }
    };

    var removePercentageSignFromSuperRate = function(employees) {
        for (var employee in employees) {
            if (employees.hasOwnProperty(employee)) {
                employees[employee]["superRate"] = employees[employee]["superRate"]
                    .toString()
                    .replace('%', '')
                    .replace(/\s/g, '');
            }
        }
    };

    var generatePayslip = function (employees) {

        removePercentageSignFromSuperRate(employees);

        ajax.call('/Payslip/GeneratePayslip', 'POST', { employees: employees })
            .done(function(response) {
                buildPayslips(response);
            });
    };


    return {
        generatePayslip: generatePayslip
    };
})
