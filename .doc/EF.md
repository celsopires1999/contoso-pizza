Course Repository:
```bash
https://github.dev/MicrosoftDocs/ef-core-for-beginners

```

Install the Entity Framework Core tools globally:
```bash
dotnet tool install --global dotnet-ef
```

To use the Entity Framework Core tools, you can run the following commands:
```bash
dotnet ef migrations add InitialCreate
```

To remove the last migration, you can use:
```bash
dotnet ef migrations remove
```

To apply the migrations to the database, run:
```bash
dotnet ef database update 
```

This command scaffolds a DbContext and entity classes for an existing database.

```bash
dotnet ef dbcontext scaffold "Server=host.docker.internal;Port=3306;Database=contosopizza;User=root;Password=root;" Pomelo.EntityFrameworkCore.MySql --context-dir Data --output-dir Models --data-annotations
```