# Expense Tracker

Expense Tracker is a web application developed using ASP.NET Core MVC that helps you manage your finances effectively.

## Purpose

The purpose of the Expense Tracker project is to provide a user-friendly and efficient web-based solution for individuals to manage their finances. Whether you want to track your income, monitor your expenses by category, or gain insights into your financial habits, this application aims to make it easy and accessible. With user authentication and a range of features, Expense Tracker helps you take control of your personal finances with convenience and precision.

## Features

- **User Authentication**: Secure user registration and login with email confirmation.
- **Access Control**: Access to various features is restricted to only logged-in users.
- **Dashboard**: A central dashboard displays your total income, total expenses, and net balance.
- **Graphical Insights**: Visualize your expenses by category and track your income and expenses over the last 7 days with interactive graphs.
- **Category Management**: Create and manage your income and expense categories.
- **Transaction Tracking**: Easily add transactions with details, including amount, category, and notes.
- **User Profile**: Manage your profile settings, change your password or email, and more.

## Getting Started

To get the Expense Tracker project up and running on your local machine, follow these steps:

1. **Prerequisites**: Make sure you have .NET Core and ASP.NET Core SDK installed on your machine.

2. **Clone the Repository**: Use `git clone` to copy the project to your local machine.

   ```shell
   git clone https://github.com/your-username/expense-tracker.git

3. **Database Setup**: Update your database connection string in the `appsettings.json` file.

   ```shell
   {
      "ConnectionStrings": {
          "DefaultConnection": "your-connection-string-here"
      }
   }
   
4. **Database Migration**: Run database migrations to create the database schema.

   ```shell
   add-migration "your-migration-name"
   update-database

5. **Run the Application**: Start the ASP.NET Core application.
