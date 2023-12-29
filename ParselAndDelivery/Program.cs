using ParselAndDelivery.vehicle;


Car car = new Car("Toyota Corolla", "Vasya", 30, 4);
var truck = new Truck();

car.EngineTurnOn();
car.DriveOneKm();
car.DriveOneKm();

Console.WriteLine(car.FuelAmmount);