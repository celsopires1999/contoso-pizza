
using ContosoPizza.Data;
using ContosoPizza.Models;

using ContosopizzaContext context = new();

// Product veggieSpecial = new()
// {
//     Name = "Veggie Special Pizza",
//     Price = 9.99m
// };

// context.Products.Add(veggieSpecial);

// Product deluxeMeat = new()
// {
//     Name = "Deluxe Meat Pizza",
//     Price = 12.99m
// };

// context.Add(deluxeMeat);

// context.SaveChanges();

var veggieSpecial = context.Products
                        .Where(p => p.Name == "Veggie Special Pizza")
                        .FirstOrDefault();

if (veggieSpecial is not null)
{
    context.Remove(veggieSpecial);
    context.SaveChanges();
}

var products = from product in context.Products
                where product.Price > 10.00m
                orderby product.Name
                select product;


foreach (Product p in products)
{
    Console.WriteLine($"Id: {p.Id}");
    Console.WriteLine($"Name: {p.Name}");
    Console.WriteLine($"Price: {p.Price}");
    Console.WriteLine(new string('-', 20));
}