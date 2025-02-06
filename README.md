# Centre Management System

Welcome to the **Centre Management System**! This is a .NET Core 3.1 backend application designed to manage centres, buildings, rotations, and other related entities. The project follows a **clean architecture** and **CQRS (Command Query Responsibility Segregation)** pattern, ensuring separation of concerns, scalability, and maintainability.

---

## 🛠️ **Project Structure**

The project is organized into multiple layers, each with a specific responsibility. Below is an overview of the key components:

### **1. Data Layer (`DATA`)**
- **Context**: Contains the `CentreDbContext` for database interactions.
- **Migrations**: Includes database migration files:
  - `20240806022841_2.Designer.cs`
  - `20240806022841_2.cs`
  - `CentreDbContextModelSnapshot.cs`
- **Repository**: Contains the `GenericRepository.cs` for generic CRUD operations.
- **Project File**: `DATA.csproj`

### **2. Domain Layer (`Domain`)**
- **Commands**: Contains commands for CQRS operations:
  - `AddGenericCommand.cs`
  - `DeleteGenericCommand.cs`
  - `PutGenericCommand.cs`
- **Dtos**: Data Transfer Objects (DTOs) for entities:
  - `BatimentDto.cs`
  - `CentreDto.cs`
- **Handlers**: Command and query handlers for CQRS:
  - `AddGenericHandler.cs`
  - `DeleteGenericHandler.cs`
  - `GetGenericHandler.cs`
  - `GetListGenericHandler.cs`
  - `PutGenericHandler.cs`
- **Interfaces**: Contains `IGenericRepository.cs` for repository abstraction.
- **Models**: Entity models for the domain
- **Queries**: Contains queries for CQRS:
  - `GetGenericQuery.cs`
  - `GetListGenericQuery.cs`
- **Project File**: `Domain.csproj`

### **3. API Layer (`api`)**
- **Controllers**: Contains API controllers for managing entities:
  - `BatimentController.cs`
  - `CentreController.cs`
  - `RotationController.cs`
  - `SoucheController.cs`
  - `SpéculationController.cs`
- **Mapper**: Contains `MapperProfiles.cs` for AutoMapper configurations.
- **Properties**: Includes `launchSettings.json` for runtime configurations.
- **Startup Files**: `Program.cs` and `Startup.cs` for application configuration.
- **App Settings**: Configuration files for different environments:
  - `appsettings.Development.json`
  - `appsettings.json`
- **Project File**: `api.csproj`

### **4. Infrastructure Layer (`infra`)**
- **Dependency Injection**: Contains `DependencyContainer.cs` for IoC configuration.
- **Project File**: `infra.csproj`

### **5. Root Files**
- **Solution File**: `CentreManagementSystem.sln`
- **IDE Files**: Configuration files for Visual Studio (`.vs`).

---

## 🚀 **Getting Started**

Follow these steps to set up the project locally:

### **Prerequisites**
- .NET Core 3.1 SDK

### **Steps**
1. **Clone the repository**:
   ```bash
   git clone https://github.com/yourusername/centre-management-system.git
   cd centre-management-system
   ```

2. **Restore dependencies**:
   ```bash
   dotnet restore
   ```

3. **Run the application**:
   ```bash
   dotnet run --project api
   ```

4. **Access the API**:
   - Open your browser or API client (e.g., Postman).
   - Navigate to `http://localhost:5000` (or the specified port).

---

## 🛠️ **Technologies Used**
- **.NET Core 3.1**
- **CQRS Architecture**
- **Entity Framework Core**
- **AutoMapper**

---

## 🧩 **CQRS Architecture**

The project is built using the **CQRS (Command Query Responsibility Segregation)** pattern, which separates the read and write operations for better scalability and maintainability. Here's how CQRS is implemented:

### **Commands**
- **AddGenericCommand.cs**: Handles the creation of new entities.
- **DeleteGenericCommand.cs**: Handles the deletion of entities.
- **PutGenericCommand.cs**: Handles the updating of existing entities.

### **Queries**
- **GetGenericQuery.cs**: Retrieves a single entity by its ID.
- **GetListGenericQuery.cs**: Retrieves a list of entities.

### **Handlers**
- **AddGenericHandler.cs**: Executes the logic for adding new entities.
- **DeleteGenericHandler.cs**: Executes the logic for deleting entities.
- **GetGenericHandler.cs**: Executes the logic for retrieving a single entity.
- **GetListGenericHandler.cs**: Executes the logic for retrieving a list of entities.
- **PutGenericHandler.cs**: Executes the logic for updating entities.

This separation ensures that the application's read and write operations are independent, making it easier to optimize and scale.

---

## 🤝 **Contributing**

Contributions are welcome! If you'd like to contribute, please follow these steps:

1. Fork the repository.
2. Create a new branch:
   ```bash
   git checkout -b feature/YourFeature
   ```
3. Make your changes and commit them:
   ```bash
   git commit -m 'Add some feature'
   ```
4. Push to the branch:
   ```bash
   git push origin feature/YourFeature
   ```
5. Open a pull request.


---

## 👨‍💻 **Author**

**Rayen Ameur**    

---
