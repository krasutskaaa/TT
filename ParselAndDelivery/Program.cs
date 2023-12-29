using ParselAndDelivery.parsel;



var parsel = new Parsel();
parsel.Customer = "Vasya";
parsel.AddProduct("IPhone 13", 20000, 0.5);
parsel.AddProduct("Potato", 20, 1);
parsel.AddProduct("Milk", 40, 1);


Console.WriteLine(parsel.Customer);
Console.WriteLine(parsel.GetWeight());
Console.WriteLine(parsel.GetFullPrice());
