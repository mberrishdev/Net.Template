# MB.Template – Clean Architecture for .NET

A Clean Architecture solution template for .NET projects.  
This template includes all key layers to help you start building scalable applications faster:  
**API**, **Application**, **Domain**, **Infrastructure**, and **Persistence**.

---

## 🚀 Getting Started

### 1. Clone the Template Repository

```bash
git clone https://github.com/yourusername/mb.template.git
cd mb.template
```

### 2. Install the Template Locally

Register the template with the .NET CLI:

```bash
dotnet new install .
```

After this, the template will appear in the list:
```bash
dotnet new list
```

You’ll see something like:
```pgsql
Template Name                Short Name      Language  Tags
--------------------------  --------------  --------  --------------------
MB.Template                 nettemplate      [C#]      CleanArchitecture/WebAPI

```
###  3. Create a New Project

Use the short name nettemplate to generate a new solution:

```bash
dotnet new nettemplate -n YourProjectName -o YourProjectName
cd YourProjectName
```
This will create a clean architecture solution with your specified name.


### 4. Restore & Run

```bash
dotnet restore
dotnet build
dotnet run --project src/YourProjectName.Api
```


### 🧼 Uninstall the Template (Optional)

To remove the template from your system:

```bash
dotnet new uninstall /full/path/to/mb.template
```

To find installed template paths, run:

```bash
dotnet new --debug:reinit
```

### 📁 Project Structure

```pgsql
src/
├── YourProjectName.Api           --> Entry point (Web API)
├── YourProjectName.Application   --> Business logic (Use Cases, Interfaces)
├── YourProjectName.Domain        --> Core domain models and rules
├── YourProjectName.Infrastructure--> Cross-cutting concerns
└── YourProjectName.Persistence   --> EF Core and data access layer
```

### 💡 Customization
This template uses symbol replacement. You can customize the solution name by passing --SolutionName:

```bash
dotnet new nettemplate -n MyApp -o MyApp --SolutionName "MyApp"

```
### 👤 Author
Mikheil Berishvili

