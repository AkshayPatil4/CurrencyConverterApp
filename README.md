# Currency Converter

Currency Converter is a web application that allows users to convert monetary amounts into words. The project consists of a backend API built with Microsoft's ASP.NET Core and a frontend developed using Angular with Angular Material for styling.

## Table of Contents

- [Overview](#overview)
- [Features](#features)
- [Technologies Used](#technologies-used)
- [Usage](#usage)
  - [Running the API](#running-the-api)
  - [Running the Angular App](#running-the-angular-app)
  - [Accessing the Application](#accessing-the-application)
- [API Endpoint](#api-endpoint)
- [Issues and Contributions](#issues-and-contributions)
- [License](#license)

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

   ```bash
   dotnet run
### Running the Angular App
1. Navigate to the CurrencyConverterApp directory.
2. Install dependencies.
   npm install
3. Run the Angular application.
   ng serve
   
### Accessing the Application
Open a web browser and go to http://localhost:4200 to use the Currency Converter.

###API Endpoint
Convert to Words:
1. Endpoint: /api/CurrencyConverter/convertToWords
2. Method: GET
3. Parameters: amountStr (string) - Decimal amount to convert to words.
   
###Issues and Contributions
If you encounter any issues or have suggestions for improvements, feel free to open an issue or contribute to the project.
