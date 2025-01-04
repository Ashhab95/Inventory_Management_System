
# Inventory Management System

## Introduction

The **Inventory Management System** is a C# application developed to help small business owners efficiently manage their store inventory and sales. Designed for Mr. Ali, a general store owner, this application addresses common inventory issues such as keeping track of product stock, recording sales, and ensuring accountability through a user-friendly digital solution.

The application allows users to:
- Add, update, and delete product information.
- Search for products quickly.
- Record sales using a checkout function.
- View past transactions using a transaction log.
- Secure the system with a login module to prevent unauthorized access.

## Features

- **User Authentication**: A login module ensures that only authorized users can access the system.
- **Product Management**:
  - Add new products to the inventory.
  - Update existing product information.
  - Delete products from the inventory.
- **Sales Management**:
  - Record sales using a simple checkout system.
  - Automatically deduct sold items from the inventory.
- **Transaction Log**:
  - View past transactions with details such as bill number, customer name, and total amount.
  - Search for transactions by date.
- **Validation Checks**: Ensures that users input correct data types in various fields.
- **Platform Independence**: The application can run on any operating system that supports the .NET framework and Microsoft SQL Server.

## Technologies Used

- **Programming Language**: C#
- **IDE**: Microsoft Visual Studio
- **Database**: SQL Server (managed using SQL Server Management Studio)
- **Framework**: .NET Framework
- **Libraries**: System.Drawing for graphical components

## How to Run the Application

### Prerequisites

- **.NET Framework**: Ensure that the .NET framework is installed on your system.
- **SQL Server**: Install Microsoft SQL Server and SQL Server Management Studio.
- **Database Setup**:
  1. Create a new database in SQL Server.
  2. Use the provided SQL scripts to create the necessary tables (`Product`, `Cart`, `TransactionLog`).

### Steps

1. **Clone the Repository**

   ```bash
   git clone https://github.com/yourusername/inventory-management-system.git
   cd inventory-management-system
   ```

2. **Open the Project**

   Open the solution file (`InventoryManagementSystem.sln`) in Microsoft Visual Studio.

3. **Build the Solution**

   In Visual Studio, click on `Build > Build Solution` or press `Ctrl+Shift+B`.

4. **Configure the Database Connection**

   Update the connection string in the `App.config` file to point to your local SQL Server instance.

5. **Run the Application**

   Click on `Start` or press `F5` to run the application.

## Success Criteria

- The program is compatible with various operating systems.
- User-friendly interface with simple navigation.
- Secure login functionality.
- Ability to manage product information (add, update, delete).
- Ability to search for products and view transaction history.
- Accurate validation checks for all user inputs.

## Future Enhancements

- Implementing different user clearance levels (admin and regular users).
- Displaying products by category to improve navigation.
- Adding a print function to generate physical receipts for transactions.
- Incorporating a total sales summary in the transaction log.

## Contact

For any inquiries or feedback, please contact **Kazi Ashhab Rahman** at [kazi.a.rahman@mail.mcgill.ca](mailto:kazi.a.rahman@mail.mcgill.ca).
