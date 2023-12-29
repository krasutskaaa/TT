using ParselAndDelivery.delivery;
using ParselAndDelivery.vehicle;


/*Car car = new Car("Toyota Corolla", "Vasya", 30, 4);
var truck = new Truck();

car.EngineTurnOn();
car.DriveOneKm();
car.DriveOneKm();

Console.WriteLine(car.FuelAmmount);*/

Delivery myDelivery = new Delivery
{
    Sender = "John",
    Recipient = "Jane",
    Car = new Car("Toyota Corolla", "Vasya", 30, 4)
};



    