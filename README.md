# 🍕 Pizza Ordering System - Windows Forms App

![Pizza Ordering Demo](pizza-demo.gif) *<!-- Replace with your actual GIF -->*

[![C# Version](https://img.shields.io/badge/C%23-.NET%204.8-blue.svg)](https://dotnet.microsoft.com/)
[![Windows Forms](https://img.shields.io/badge/Windows%20Forms-YES!-success.svg)](https://docs.microsoft.com/en-us/dotnet/desktop/winforms/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

> **Slice perfection at your fingertips** - A deliciously coded pizza ordering system with full customization capabilities!

## 🧀 Features

### 🍅 Order Customization
| Control Type | Functionality | Example |
|--------------|---------------|---------|
| **✔️ Checkboxes** | Multi-select toppings | Pepperoni, Mushrooms, Olives |
| **🔘 Radio Buttons** | Exclusive size selection | Small, Medium, Large |
| **🛒 Combo Box** | Crust style selection | Thin, Thick, Stuffed |
| **📝 Text Box** | Special instructions | "Cut into 8 slices" |

### 🧮 Order Processing
- Real-time price calculation
- Order summary generation
- Receipt printing functionality
- Order history tracking

## 🖼️ Screenshot
![Order Interface](screenshot.png) *<!-- Add your actual screenshot -->*

## 🚀 Installation

```bash
# Clone the repository
git clone https://github.com/your-username/food-ordering-system-windows-form-app-.git

# Open in Visual Studio
start PizzaOrderingSystem.sln
```

🧑‍🍳 Behind the Counter
🏗️ OOP Architecture

```bash
public class Pizza
{
    public string Size { get; set; }
    public List<string> Toppings { get; } = new List<string>();
    public string CrustType { get; set; }
    
    public decimal CalculatePrice()
    {
        // Pricing logic based on selections
    }
}
```
🎨 UI Implementation

```bash
// Creating topping checkboxes dynamically
foreach (var topping in availableToppings)
{
    var cb = new CheckBox 
    {
        Text = topping.Name,
        Tag = topping.Price,
        AutoSize = true
    };
    cb.CheckedChanged += UpdateOrderTotal;
    toppingsPanel.Controls.Add(cb);
}
```
