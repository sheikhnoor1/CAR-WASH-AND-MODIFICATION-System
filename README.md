🚗 Car Wash and Modification Management System

A Windows desktop-based Car Wash and Modification Management System developed using C# Windows Forms. The application is designed to manage customers, vehicle types, services, employees, sales, payments, costs, and business reports for a car wash and modification business.

The project uses Microsoft SQL Server LocalDB for database connectivity and includes RDLC reporting for generating business reports and receipts.

📌 Features

🔐 Login & Authentication

User login system

Splash screen

Role-based employee management

Password-protected access

👥 Customer Management

Add new customers

Edit customer information

Delete customer records

Search customers

Store customer phone and address

Store vehicle number and vehicle model

Assign vehicle types to customers

Manage customer loyalty points

🚘 Vehicle Type Management

Add vehicle types

Edit vehicle types

Delete vehicle types

Search vehicle types

Categorize vehicles by class

🧰 Service Management

Add car wash/modification services

Edit service information

Delete services

Search services

Set service prices

Validate service price input

👨‍💼 Employee Management

Add employees

Edit employee information

Delete employee records

Search employees

Store phone, address, date of birth, gender, role, salary, and password

💰 Sales & Cash Management

Manage customer/service sales

Record service transactions

Calculate service prices

Manage cash payments

Settle customer payments

Generate receipts

💸 Cost Management

Manage Cost of Goods Sold

Add business costs

Edit cost information

Delete cost records

Track costs by date

📊 Reports & Business Analytics

The system provides business reports including:

Top-selling services

Revenue reports

Cost of Goods Sold reports

Gross profit calculation

Date-based report filtering

Receipt generation

⚙️ Settings

Manage vehicle types

Manage Cost of Goods Sold

Manage company information

🛠️ Tech Stack

Technology

Purpose

C#

Application development

.NET Framework 4.8

Application framework

Windows Forms

Desktop user interface

Microsoft SQL Server LocalDB

Database

ADO.NET / System.Data.SqlClient

Database connectivity

RDLC

Reports and receipts

Visual Studio

Development environment

SQL Server Types

SQL Server spatial/reporting support

📂 Project Structure

CAR WASH AND MODIFICATION System/
│
├── CarWashManagementSystem/
│   │
│   ├── images/
│   │
│   ├── Login.cs
│   ├── MainForm.cs
│   ├── Splash.cs
│   ├── Dashboard.cs
│   │
│   ├── Customer.cs
│   ├── CustomerModule.cs
│   │
│   ├── Employer.cs
│   ├── EmployerModule.cs
│   │
│   ├── Service.cs
│   ├── ServiceModule.cs
│   │
│   ├── Cash.cs
│   ├── CashCustomer.cs
│   ├── CashService.cs
│   ├── SettlePayment.cs
│   │
│   ├── ManageVehicleType.cs
│   ├── ManageCostofGoodSold.cs
│   ├── Setting.cs
│   │
│   ├── Report.cs
│   ├── receipt.cs
│   ├── rptReceipt.rdlc
│   │
│   ├── dbConnect.cs
│   ├── DataSet1.xsd
│   ├── Program.cs
│   ├── App.config
│   └── DBCarWash.mdf
│
├── packages/
│
├── CarWashManagementSystem.sln
└── README.md

🗄️ Database

The application uses a SQL Server LocalDB .mdf database.

Database file:

DBCarWash.mdf

The application connects to the database through the dbConnect class using SqlConnection.

The system manages data related to:

Customers

Vehicle Types

Services

Employees

Sales/Cash Transactions

Costs

Company Settings

🔗 Database Connectivity

The project uses:

System.Data.SqlClient

for communication between the Windows Forms application and SQL Server LocalDB.

The main database connection is handled by:

dbConnect.cs

The class provides methods for:

Opening the connection

Closing the connection

Executing SQL queries

Returning the SQL connection

⚙️ Project Setup

1. Install Visual Studio

Install Visual Studio with the required desktop development workload.

Recommended:

Visual Studio 2019 / 2022
.NET Framework 4.8

2. Open the Solution

Open:

CarWashManagementSystem.sln

in Visual Studio.

3. Restore Required Packages

The project uses packages including:

Microsoft.ReportingServices.ReportViewerControl.Winforms
Microsoft.SqlServer.Types

Restore the NuGet packages before building the project.

4. Check Database Connection

Open:

CarWashManagementSystem/dbConnect.cs

The current connection uses SQL Server LocalDB and the project database:

DBCarWash.mdf

If the project is moved to another computer, update the database file path inside dbConnect.cs so it points to the new location of DBCarWash.mdf.

5. Build the Project

In Visual Studio:

Build
→ Build Solution

or press:

Ctrl + Shift + B

6. Run the Application

Press:

F5

The application starts from the:

Splash

screen and then opens the main application.

🖥️ Main Modules

The application contains the following major modules:

Login
  ↓
Splash Screen
  ↓
Main Dashboard
  ├── Customers
  ├── Employees
  ├── Vehicle Types
  ├── Services
  ├── Cash / Sales
  ├── Payments
  ├── Reports
  └── Settings

📊 Reporting

The project uses Microsoft ReportViewer / RDLC for reporting.

Report-related files include:

Report.cs
receipt.cs
rptReceipt.rdlc
DataSet1.xsd

The reporting module supports:

Top-selling services

Revenue analysis

Cost analysis

Gross profit

Customer/service receipts

Date-range filtering

🧾 Receipt Generation

The application includes a receipt generation module.

The receipt functionality uses:

receipt.cs
rptReceipt.rdlc

to display and generate transaction receipts.

🔍 Search & Validation

Several modules provide search and validation functionality.

Examples include:

Customer search

Employee search

Service search

Vehicle type search

Required field validation

Numeric price validation

Date-based report filtering

🎯 Project Objective

The main objective of this project is to provide a centralized desktop management solution for a car wash and modification business.

The system helps manage:

Customer
   ↓
Vehicle
   ↓
Service
   ↓
Sales / Payment
   ↓
Receipt
   ↓
Reports

It reduces manual record keeping and provides a structured way to manage customers, employees, services, transactions, costs, and business performance.

📸 Screenshots

You can add application screenshots to the repository using a screenshots folder:

screenshots/
├── login.png
├── dashboard.png
├── customer.png
├── vehicle-type.png
├── service.png
├── employee.png
├── cash.png
└── reports.png

Then display them in this section using:

![Login](screenshots/login.png)

![Dashboard](screenshots/dashboard.png)

![Customer Management](screenshots/customer.png)

![Reports](screenshots/reports.png)

🚀 Future Improvements

Possible improvements include:

Online appointment/booking support

Automated SMS/email notifications

Online payment integration

Advanced customer loyalty system

Cloud database support

Improved role-based permissions

Advanced sales analytics

Automatic database backup

Modern responsive interface

📚 Learning Outcomes

This project demonstrates practical experience with:

C# programming

Windows Forms development

Object-oriented programming

SQL Server database integration

ADO.NET

CRUD operations

Form validation

Search functionality

Report generation

RDLC

Desktop application architecture

Database-driven application development

👨‍💻 Author

Sheikh Noor Uddin Bashar

Department of Computer Science & Engineering
American International University-Bangladesh (AIUB)

GitHub:

https://github.com/sheikhnoor1

📄 License

This project was developed for academic and educational purposes.
