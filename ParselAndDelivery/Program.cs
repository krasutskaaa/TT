//<<<<<<< HEAD
﻿using ParselAndDelivery.parsel;


//=======
﻿using ParselAndDelivery.delivery;
using ParselAndDelivery.vehicle;



Car car = new Car("Toyota Corolla", "Vasya", 30, 4);
var truck = new Truck();
//>>>>>>> delivery

var parsel = new Parsel();
parsel.Customer = "Vasya";
parsel.AddProduct("IPhone 13", 20000, 0.5);
parsel.AddProduct("Potato", 20, 1);
parsel.AddProduct("Milk", 40, 1);

//<<<<<<< HEAD

Console.WriteLine(parsel.Customer);
Console.WriteLine(parsel.GetWeight());
Console.WriteLine(parsel.GetFullPrice());
//=======
Console.WriteLine(car.FuelAmmount);

Delivery myDelivery = new Delivery
{
    Sender = "John",
    Recipient = "Jane",
    Car = new Car("Toyota Corolla", "Vasya", 30, 4)
};



    
//