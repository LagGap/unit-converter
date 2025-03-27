
# Unit Converter Web App

This is a Unit Converter web application built using ASP.NET Core MVC and .NET 9.0. It was developed as part of a challenge from [Roadmap.sh](https://roadmap.sh/projects/unit-converter).

## Features

- Convert lengths between different units.
- Convert weights between different units.
- Convert temperatures between different units.

## Prerequisites

- Ensure you have .NET 9.0 installed on your machine. You can download it from the [official .NET website](https://dotnet.microsoft.com/download/dotnet/9.0).

## Getting Started

Follow these steps to get the application up and running on your local machine:

1. **Clone the Repository**

   Open your terminal or command prompt and run the following command to clone the repository:

   ```bash
   git clone https://github.com/LagGap/unit-converter.git
   ```

2. **Navigate to the Project Directory**

   Change your directory to the cloned repository:

   ```bash
   cd unit-converter
   ```

3. **Build the Application**

   Build the application using the .NET CLI:

   ```bash
   dotnet build
   ```

4. **Run the Application**

   Run the application using the following command:

   ```bash
   dotnet run
   ```

5. **Access the Application**

   Open your web browser and navigate to the port specified in your terminal to access the Unit Converter app.

6. **Architecture**

   ```Controllers/```Controls the passage from the form views to the result with the converted unit 
   ```Models/ ```Contains the different viewmodels for transferring data from a view to another and the unit converter 
   ```Views/``` Contains all the views for the different forms and the result of the conversion
   ```Programs.cs/``` Responsible to launch the application

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.

## Acknowledgments

- Thanks to [Roadmap.sh](https://roadmap.sh/projects/unit-converter) for the challenge inspiration.
- Built with ASP.NET Core MVC and .NET 9.0.