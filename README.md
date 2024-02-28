# Online Sales Management System

The Online Sales Management System is a web application designed to track sales records and manage employees in an online sales environment. This system allows users to register employees, monitor their sales performance, and organize them into specific departments.

## Key Features
- **Employee Management:** Register and manage employees, including their personal information and sales performance.
- **Sales Tracking:** Record and monitor sales transactions, including the date of sale, amount, and status.
- **Department Organization:** Group employees into departments to streamline management and reporting.
- **Data Analysis:** Analyze sales data to gain insights into performance and identify trends.

This system provides a comprehensive solution for businesses engaged in online sales, offering tools to effectively manage personnel and track sales performance.

# 📝 **Sales Web MVC Project (BACKEND DOCUMENTATION)** 

## Controllers

### Departments Controller

The Departments Controller manages operations related to departments.

#### Actions:

- **Index**: Displays a list of all departments.
- **Details**: Displays details of a specific department.
- **Create**: Renders a form to create a new department.
- **Edit**: Renders a form to edit an existing department.
- **Delete**: Renders a confirmation page to delete a department.

### Home Controller

The Home Controller manages general application pages.

#### Actions:

- **Index**: Renders the home page.
- **About**: Renders information about the application.
- **Contact**: Renders contact information.
- **Privacy**: Renders the privacy policy page.
- **Error**: Renders error pages.

### Sales Records Controller

The Sales Records Controller manages sales records.

#### Actions:

- **Index**: Renders the sales records page.
- **SimpleSearch**: Performs a simple search for sales records.
- **GroupingSearch**: Performs a grouped search for sales records.

### Sellers Controller

The Sellers Controller manages operations related to sellers.

#### Actions:

- **Index**: Displays a list of all sellers.
- **Create**: Renders a form to create a new seller.
- **Edit**: Renders a form to edit an existing seller.
- **Delete**: Renders a confirmation page to delete a seller.
- **Details**: Displays details of a specific seller.
- **Error**: Renders error pages.

## Data

### SalesWebMVCContext

The SalesWebMVCContext class provides access to the database context.

### Seeding Service

The Seeding Service initializes the database with sample data.

## Models

### Department

The Department class represents a department.

### Sales Record

The Sales Record class represents a sales record.

### Seller

The Seller class represents a seller.

## Models/Enums

### SaleStatus

The SaleStatus enum represents the status of a sale.

## Models/ViewModels

### ErrorViewModel

The ErrorViewModel class represents data for error views.

### SellerFormViewModel

The SellerFormViewModel class represents data for the seller form.

## Services

### Department Service

The Department Service provides operations related to departments.

#### Methods:

- **FindAllAsync**: Retrieves all departments asynchronously.

### Sales Record Service

The Sales Record Service provides operations related to sales records.

#### Methods:

- **FindByDateAsync**: Retrieves sales records within a specified date range asynchronously.
- **FindByDateGroupingAsync**: Retrieves sales records grouped by department within a specified date range asynchronously.

### Seller Service

The Seller Service provides operations related to sellers.

#### Methods:

- **FindAllAsync**: Retrieves all sellers asynchronously.
- **InsertAsync**: Inserts a new seller asynchronously.
- **FindByIDAsync**: Retrieves a seller by ID asynchronously.
- **RemoveAsync**: Removes a seller asynchronously.
- **UpdateAsync**: Updates a seller asynchronously.

### Exceptions

#### DbConcurrencyException

Thrown when there are concurrency issues in the database.

#### IntegrityException

Thrown when there are integrity constraint violations.

#### NotFoundException

Thrown when an entity is not found.

## Main

### Program

The Program class contains the entry point for the application.

---

# 📝 **Sales Web MVC Project (FRONTEND DOCUMENTATION)** 

This documentation provides an overview of the frontend code structure and functionality of the Sales Web MVC application. Below are the main sections detailing each view along with their purpose and functionality.

#### View: Create Department

- **Purpose**: This view allows users to create a new department.
- **Functionality**:
  - Displays a form with a field for entering the department name.
  - Upon submission, sends a request to create a new department.

#### View: Delete Department

- **Purpose**: This view allows users to delete a department.
- **Functionality**:
  - Displays the details of the department to be deleted.
  - Provides an option to confirm the deletion.

#### View: Department Details

- **Purpose**: Displays detailed information about a department.
- **Functionality**:
  - Shows the name of the department.

#### View: Edit Department

- **Purpose**: Allows users to edit the details of a department.
- **Functionality**:
  - Displays a form pre-filled with the current department name.
  - Allows users to modify the department name and save changes.

#### View: Department Index

- **Purpose**: Lists all departments.
- **Functionality**:
  - Displays a table with a list of departments and their names.
  - Provides options to edit, view details, and delete each department.

#### View: Grouping Search Sales Record

- **Purpose**: Displays sales records grouped by department.
- **Functionality**:
  - Allows users to filter sales records by date range.
  - Groups sales records by department and displays total sales amount for each department.

#### View: Simple Search Sales Record

- **Purpose**: Allows users to search for sales records based on a date range.
- **Functionality**:
  - Provides a simple form for entering a date range.
  - Displays total sales amount within the specified date range.

#### View: Create Seller

- **Purpose**: Enables users to create a new seller.
- **Functionality**:
  - Displays a form with fields for entering seller details such as name, email, birth date, base salary, and department.
  - Allows users to select the department from a dropdown list.

#### View: Delete Seller

- **Purpose**: Allows users to delete a seller.
- **Functionality**:
  - Displays details of the seller to be deleted.
  - Provides an option to confirm the deletion.

#### View: Seller Details

- **Purpose**: Displays detailed information about a seller.
- **Functionality**:
  - Shows the name, email, birth date, base salary, and department of the seller.

#### View: Edit Seller

- **Purpose**: Allows users to edit the details of a seller.
- **Functionality**:
  - Displays a form pre-filled with the current seller details.
  - Allows users to modify seller information and save changes.

#### View: Seller Index

- **Purpose**: Lists all sellers.
- **Functionality**:
  - Displays a table with a list of sellers and their details.
  - Provides options to edit, view details, and delete each seller.

#### View: About Page

- **Purpose**: Provides information about the application.
- **Functionality**:
  - Displays information about the developer (me).
  - Includes links to the developer's [GitHub profile](https://github.com/caiotbraga).

#### View: Contact Page

- **Purpose**: Displays contact information.
- **Functionality**:
  - Provides links to the developer's [Instagram](https://instagram.com/caiotbraga), [LinkedIn](https://www.linkedin.com/in/caiotbraga/), and email.

#### View: Home Page

- **Purpose**: Landing page of the application.
- **Functionality**:
  - Displays a carousel with information about ASP.NET, Visual Studio, and Microsoft Azure.
  - Provides sections with links to application usage, how-to guides, overview, and deployment.

This documentation outlines the structure and functionality of each frontend view in the Sales Web MVC application.

## License

This project is licensed under the [MIT License](LICENSE).
