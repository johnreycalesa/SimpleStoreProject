# ShopEase

## Project Description
ShopEase is a lightweight web application built with .NET 8. It provides a simple online store experience, allowing users to view available products and review their orders. The application reads data from `products.json` and `orders.json`.

---

## Features
- **Homepage**: Links to the Store and My Orders pages.
- **Store Page**: Displays a list of products with their names and prices.
- **My Orders Page**: Lists all orders with their IDs and calculated net prices.

---

## Prerequisites
- .NET SDK 8.0 or higher
- A code editor like Visual Studio or Visual Studio Code

---

## Installation

### 1. Clone the Repository
```bash
git clone <repository-url>
cd ShopEase
```

### 2. Restore Dependencies
Run the following command to restore NuGet packages:
```bash
dotnet restore
```

### 3. Build the Project
```bash
dotnet build
```

---

## Running the Application

### 1. Start the Application
Run the following command to start the development server:
```bash
dotnet run
```

### 2. Access the Application
Open your browser and navigate to:
```
http://localhost:5000
```

---

## Project Structure
```
ShopEase/
│
├── Data/
│   ├── products.json      # JSON file containing product data
│   └── orders.json        # JSON file containing orders data
│
├── Pages/
│   ├── Index.cshtml       # Homepage
│   ├── Store.cshtml       # Store page
│   ├── MyOrders.cshtml    # Orders page
│
├── Models/
│   ├── Product.cs         # Product model
│   ├── Order.cs           # Order model
│   └── OrderItem.cs       # OrderItem model
│
├── Program.cs             # Main entry point
└── README.md              # Project documentation
```

---

## Data Details

### products.json
```json
[
  {
    "id": 1,
    "name": "Product A",
    "price": 100.0
  },
  {
    "id": 2,
    "name": "Product B",
    "price": 150.0
  }
]
```

### orders.json
```json
[
  {
    "orderId": 101,
    "items": [
      { "id": 1, "quantity": 2 },
      { "id": 2, "quantity": 1 }
    ]
  }
]
```

---

## Net Price Calculation
Net Price is calculated as:
```
Net Price = Σ (Product Price × Quantity) for each item in the order
```

---

## Contribution
Feel free to fork the project and submit pull requests. For any suggestions or issues, open an issue on the repository.

---

## License
This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.
