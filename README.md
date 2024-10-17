# Web API with Angular

This project is a web application that combines an ASP.NET Core Web API with an Angular frontend.

## Project Structure

- **Project1**: Contains the main application code.
  - **ClientApp**: Angular frontend application.
  - **Controllers**: API controllers.
  - **Migrations**: Entity Framework Core migrations.
  - **Models**: Data models.
  - **Utilities**: Utility classes and methods.
  - **ViewModels**: View models for the application.
  - **Views**: Razor views.
  - **Program.cs**: Entry point for the ASP.NET Core application.
  - **Project1.csproj**: Project file for the main application.
  - **appsettings.json**: Configuration settings.
  - **appsettings.Development.json**: Development-specific configuration settings.
  - **libman.json**: Library Manager configuration file.
  - **openapi.json**: OpenAPI specification file.

- **TestProject1**: Contains unit tests for the application.
  - **TestProject1.csproj**: Project file for the test project.

- **Project1.sln**: Visual Studio solution file.

## Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Node.js](https://nodejs.org/) (for the Angular frontend)
- [Angular CLI](https://angular.io/cli)

## Getting Started

### Backend

1. Navigate to the `Project1` directory:
    ```sh
    cd Project1
    ```

2. Restore the .NET dependencies:
    ```sh
    dotnet restore
    ```

3. Update the database:
    ```sh
    dotnet ef database update
    ```

4. Run the ASP.NET Core application:
    ```sh
    dotnet run
    ```

### Frontend

1. Navigate to the `ClientApp` directory:
    ```sh
    cd Project1/ClientApp
    ```

2. Install the npm dependencies:
    ```sh
    npm install
    ```

3. Run the Angular development server:
    ```sh
    ng serve
    ```

4. Open your browser and navigate to `http://localhost:4200/`.

## Building the Project

### Backend

To build the ASP.NET Core application, run:
    ```sh
    dotnet build
    ```

### Frontend

To build the Angular application, run:
    ```sh
    ng build
    ```

The build artifacts will be stored in the `dist/` directory.

## Running Tests

### Backend

To run the unit tests for the ASP.NET Core application, navigate to the `TestProject1` directory and run:
    ```sh
    dotnet test
    ```

### Frontend

To run the unit tests for the Angular application, navigate to the `ClientApp` directory and run:
    ```sh
    ng test
    ```

## Further Help

For more help on the Angular CLI, use `ng help` or check out the [Angular CLI README](https://github.com/angular/angular-cli/blob/main/README.md).

For more help on ASP.NET Core, visit the [ASP.NET Core documentation](https://learn.microsoft.com/en-us/aspnet/core).


This [README.md](https://github.com/microsoftdotnetdevelopment/Todoapp/blob/master/README.md) file provides an overview of the project structure, prerequisites, and instructions for getting started, building, and running tests for both the backend and frontend parts of the application.