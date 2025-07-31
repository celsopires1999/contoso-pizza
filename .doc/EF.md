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