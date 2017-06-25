Pre-requisites

* Windows 
* .Net 4.5.2 Framework
* Visual Studio Professional 2015 **OR** Visual Studio Community 2015
  with Extensions (from Tools > Extensions and Updates:
	- NuGet Package Manager (3.4)

* IIS Express (8.0) - install via the "Web Platform"


* Setup And Start instructions:
- Install nodejs (https://nodejs.org/en/).
- Goto project directory>payslips folder , open windows cli run `npm install` to download javascript dependencies.
- Goto project directory, There is a Payslip.sln file in project directory. double click it to open in visual studio.
- Right click on Solution folder in visual studio select Rebuild Solution or (Clean and then Build Solution).
- Right click on Payslip.Test project in visual studio select Run Unit Tests.
- Right click on Payslip project And Select Set as StartUp Project.
- Start the application and drop .json file on the box to generate the payslips.
	- Please look at the Employee.json file in the project directory for details of fields and formats.
	- firstName, lastName, annualSalary, superRate, paymentPeriod are the required fields in the json file.

* Assumptions:
- Employee(.json) Input file will always be correct (in both its format and its data)
	- For example, the payment period is always in calendar month range (i.e. 01 March - 31 March)
	- All the fields i.e. firstName, lastName, annualSalary, superRate, paymentPeriod are mandatory.