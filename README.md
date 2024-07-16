# Currency Converter 💲


Convert numerical monetary amounts into their equivalent written form (e.g., "123.45" to "One hundred twenty-three dollars and forty-five cents"). This application comprises an ASP.NET Core backend API for conversion logic and an Angular frontend with Angular Material for a polished user experience.

## 💡 Key Features

* **Accurate Conversion:** Accurately converts decimal amounts to words, including dollars and cents.
* **User-Friendly Interface:** Provides a clean and intuitive interface for easy input and output display.
* **Angular Material Styling:** Utilizes Angular Material for a modern and visually appealing design.
* **RESTful API:** Exposes a simple API endpoint for seamless integration with other applications.

## 🚀 Getting Started

### 1. Backend (ASP.NET Core)

* **Prerequisites:**
    * .NET Core SDK: Ensure you have the .NET Core SDK installed on your machine.

* **Running the API:**
    ```bash
    cd CurrencyConverterApi 
    dotnet run
    ```
    The API will typically run on `http://localhost:5000` (or `https://localhost:5001`).

### 2. Frontend (Angular)

* **Prerequisites:**
    * Node.js and npm: Ensure you have Node.js and npm installed on your machine.

* **Running the Angular App:**
    ```bash
    cd CurrencyConverterApp
    npm install
    ng serve
    ```
    The Angular app will be available at `http://localhost:4200` in your browser.

## 🌐 Usage

1. **Access the App:** Open your web browser and navigate to `http://localhost:4200/`.
2. **Enter Amount:** Type the decimal amount you want to convert in the input field.
3. **Click "Convert":** The application will display the converted amount in words.

## 🛠️ API Endpoint

* **Convert to Words:**
    * **Endpoint:** `/api/CurrencyConverter/convertToWords`
    * **Method:** `GET`
    * **Parameter:** `amountStr` (string) - The decimal amount to be converted.

## 🤝 Contributing
Contributions are welcome! Feel free to open issues or submit pull requests.
