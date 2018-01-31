Payslip Builder
===============

- Pre-requisites

	- Windows 
	- .Net 4.5.2 Framework
	- Visual Studio Professional 2015 **OR** Visual Studio Community 2015 with Extensions (from Tools > Extensions and Updates:
		- NuGet Package Manager (3.4)

	- IIS Express (8.0) - install via the "Web Platform"

- Assumptions:
	- Input file is in json format.
		- Please look at the Employee.json file in the project directory for details of fields and formats.
	- Input file will always have correct format and data.
		- All the fields i.e. firstName, lastName, annualSalary, superRate, paymentPeriod are mandatory.
		- The payment period is always in calendar month range e.g. 01 March - 31 March

- Setup And Start instructions:
	- Install nodejs (https://nodejs.org/en/).
	- Goto project directory>payslips folder , open windows cli run `npm install` to download javascript dependencies.
	- Goto project directory, There is a Payslip.sln file in project directory. double click it to open in visual studio.
	- Right click on Solution folder in visual studio select Rebuild Solution or (Clean and then Build Solution).
	- Right click on Payslip.Test project in visual studio select Run Unit Tests.
	- Right click on Payslip project And Select Set as StartUp Project.
	- Start the application, drag and drop the employee.json file on the box in UI to generate the payslips.
		- firstName, lastName, annualSalary, superRate, paymentPeriod are the required fields in the json file.
