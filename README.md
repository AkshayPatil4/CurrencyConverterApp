# Currency Converter

Currency Converter is a web application that allows users to convert monetary amounts into words. The project consists of a backend API built with Microsoft's ASP.NET Core and a frontend developed using Angular with Angular Material for styling.

## Overview

The Currency Converter project provides a simple and user-friendly interface for converting monetary amounts into words. The backend API, built with ASP.NET Core, handles the conversion logic, while the Angular frontend ensures a seamless and interactive user experience.

## Features

- **Convert to Words:** The API endpoint `/api/CurrencyConverter/convertToWords` takes a decimal amount as input and returns the equivalent amount in words.

## Technologies Used

### Backend

- **ASP.NET Core:** The backend of the Currency Converter API is developed using ASP.NET Core, providing a robust and scalable foundation.

### Frontend

- **Angular:** The frontend of the project is built using Angular, a powerful and widely-used web application framework.

- **Angular Material:** Angular Material is employed for styling, ensuring a consistent and visually appealing user interface.

## Usage

### Running the API

1. Navigate to the `CurrencyConverterApi` directory.
2. Run the ASP.NET Core application.

bash :: dotnet run
The API will be accessible at http://localhost:5108.

Running the Angular App
Navigate to the CurrencyConverterApp directory.

Install dependencies.

bash:: npm install
Run the Angular application.

bash:: ng serve
The Angular app will be available at http://localhost:4200.

Accessing the Application
Open a web browser and go to http://localhost:4200 to use the Currency Converter.

API Endpoint
Convert to Words:
Endpoint: /api/CurrencyConverter/convertToWords
Method: GET
Parameters: amountStr (string) - Decimal amount to convert to words.
Issues and Contributions
If you encounter any issues or have suggestions for improvements, feel free to open an issue or contribute to the project.
