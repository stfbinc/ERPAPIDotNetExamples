* Dependencies
  The examples are implemented as Razor pages dotnet core project and it depended only from dotnet core 2.1

* How to execute
  - install dotnet core 2.1
  - open cmd and change dir to examples/dotnet
  - type dotnet run
  - open localhost:5000 in Browser

* What is included?
  - example for login and getting session id process
  - example for getting List of records on any screen in System
  - example for updating record on any screen in System
  - example for creating record on any screen in System

* How it works?
  - run project and open it in Browser
  - open one of examples
  - take a look at console output from API methods

* Overall System Design Notes:

  - All of the grid screens in the system are called "SomethingList"
  - All of the detail screens off of the grid screens are called "SomethingHeader"
  - If the data set we are talking about is a parent / child data-set, we use the terminology Header/Detail
  - So, for example, Order Parent Information would be in the OrderHeader Table, the details would be in the OrderDetails table
  - Grid Screens are List / Details or List / Header depending on the relationships
  - All table names and field names are given plain-English names so there should be nothing to figure out. 

This above information will help you find the API to call

* About the API Call Orginization:

The API is organized by Screen and screen function, which I thought it would be very intuitive, so, if you needed to know where an API function is or where it's called from, you call the API for that screen then that function.

So, for example the "Company Creation" code would be called using the "CompanyList" API Call, which is where in the program the company creation button lives.
Same for the Division creation and department creation, they would be in the "DivisionList" API and the Department List API
SO, basically to know which API to call for which function, you would find that function in the Enterprise ERP System and then use the API for that screen to do the function.

* Some Specific API Location Examples:

  - Create a company - CompanyList API

  - Create some divisions and departments of that company - DivisionsList, DepartmentsList (Remember Department is a child of Division which is a child of Company)

  - Create warehouses for each of them  - WarehouseList API

  - Create items - ItemsList API

  - Create orders - OrderHeaderList API (Working examples are here: https://github.com/stfbinc/EnterpriseCart/ (EnterpriseCart API Sample App)

  - Create invoices - InvoiceHeaderList API (Works the same as orders)

  - Get some reports about above functionalities  - Report API Calls start with RPT




