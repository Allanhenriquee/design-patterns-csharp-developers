using BuilderSimple.Console.Models;

var completeOrder = new OrderSimple.OrderSimpleBuilder()
    .AddProduct("Notebook", 5500.00m)
    .AddProduct("Mouse", 250.00m)
    .AddProduct("Teclado", 400.00m)
    .SetPaymentMethod("Cartao de Credito")
    .ApplyDiscount(100.00m)
    .CalculateTax(0.08m)
    .SetShippingAddress("Rua, Bairro, Cidade, Estado, Brasil")
    .Build();

Console.WriteLine(completeOrder);
Console.WriteLine();

var simplifiedOrder = new OrderSimple.OrderSimpleBuilder()
    .AddProduct("Celular", 3000.00m)
    .SetPaymentMethod("Pix")
    .CalculateTax(0.08m)
    .Build();

Console.WriteLine(simplifiedOrder);