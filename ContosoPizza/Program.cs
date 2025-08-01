// var builder = WebApplication.CreateBuilder(args);
// var app = builder.Build();

// app.MapGet("/", () => "Hello World!");

// app.Run();

using ContosoPizza.Data;
using ContosoPizza.Models;

using ContosoPizzaContext context = new();

Product veggieSpecial = new()
{
    Name = "Veggie Special Pizza",
    Price = 9.99m
};

context.Products.Add(veggieSpecial);

Product deluxeMeat = new()
{
    Name = "Deluxe Meat Pizza",
    Price = 12.99m
};

context.Add(deluxeMeat);

context.SaveChanges();
