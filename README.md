# Bike Shop Inventory

Bike Shop Inventory is a Windows Forms application built with C# to manage bike inventory effectively. Whether you're running a bike shop or managing personal collections, this application provides an intuitive interface for handling various bike types like road bikes, mountain bikes, electric bikes, and folding bikes. Serialize and deserialize bike data with XML, and perform bike-specific operations seamlessly.

---

## Features

### 🛠️ General Features
- Add, update, search, and delete bike records.
- Serialize and deserialize data to/from XML.
- Dynamic bike speed adjustments.

### 🚴 Bike-Specific Functionalities
- **Road Bike**: Manage seat height.
- **Mountain Bike**: Adjust height from the ground and suspension type.
- **Electric Bike**: Track battery life.
- **Folding Bike**: Handle weight and frame material.

### 📊 Interface
- User-friendly interface with categorized bike specifications.
- List and print bike information based on type.
- Integrated XML operations for data persistence.

---

## Project Structure

```plaintext
MyBikeManager/
│
├── bus/                     # Business logic layer
│   ├── Bike.cs              # Abstract bike class
│   ├── ElectricBike.cs      # Electric bike subclass
│   ├── MountainBike.cs      # Mountain bike subclass
│   ├── RoadBike.cs          # Road bike subclass
│   ├── FoldingBike.cs       # Folding bike subclass
│   ├── Enums/               # Enumerations for bike properties
│   │   ├── EnumColor.cs
│   │   ├── EnumType.cs
│   │   └── EnumSuspension.cs
│   ├── Interfaces/          # Interfaces for bike behaviors
│   │   ├── IMovable.cs
│   │   └── IPrintable.cs
│   ├── DataCollection.cs    # Data handler for bikes
│   └── FileManager.cs       # XML serialization and deserialization
│
├── data/                    # XML data storage
│   ├── Bikes.xml
│   └── library.xml
│
├── user/                    # Windows Forms UI
│   ├── Form1.cs             # Main user interface
│   ├── Login.cs             # User authentication (future feature)
│   └── Program.cs           # Application entry point
│
├── Properties/              # Application metadata
├── Resources/               # Embedded resources
└── ClassDiagram.cd          # Class diagram for visual representation
```

---

## Class Diagram

The application follows an Object-Oriented Design (OOD) structure. Here's the class relationship diagram:

![Class Diagram](MyBike/sreenshot/Diagram.png)

---

## Screenshots

### User Interface
![User Interface](MyBike/sreenshot/Interface.png)

---

## How to Use

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/your-username/MyBikeManager.git
   ```
2. **Open the Solution**:
   Open the `MyBikeSolution.sln` file in Visual Studio.
3. **Run the Application**:
   Press `F5` or select the `Start` button in Visual Studio to launch the app.
4. **Manage Your Bikes**:
   Use the interface to add, update, search, or delete bike records.

---

## Future Enhancements

- 🛒 Add user authentication via `Login.cs`.
- 📈 Enhance reporting features with advanced analytics.
- 🌐 Enable cloud synchronization for bike records.
- 🎨 Improve UI styling and design.

---

## Contributing

Contributions are welcome! If you have ideas or enhancements, feel free to open an issue or submit a pull request.

---

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

---

## Acknowledgments

- Built with ❤️ by [Negar](https://github.com/negarprh).
