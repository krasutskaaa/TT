namespace ParselAndDelivery.vehicle;

public class Car : IVehicle
{
    public VehicleBrands Brand { get; set ;}
    public string Model { get; set; }
    public string Color { get; set; }
    public string Owner { get; set; }
    public double FuelAmmount { get; set; }
    private int NumberOfWheels { get; set; }
    private bool EngineRunning { get; set; }
    public DateTime DateOfCreating {  get; set; } = DateTime.Now;
    public Car(string model, string owner, double fuelAmmount, int numberOfWheels)
    {
        Model = model;
        Owner = owner;
        FuelAmmount = fuelAmmount;
        EngineRunning = false;
        NumberOfWheels = numberOfWheels;
    }

    public void EngineTurnOn()
    {
        if (FuelAmmount > 0)
            EngineRunning = true;
    }

    public void EngineTurnOff()
    {
        EngineRunning = false;
    }

    public void DriveOneKm()
    {
        if (EngineRunning && FuelAmmount >= 0.06)
        {
            FuelAmmount -= 0.06;
        }
    }

    public void Maintenance()
    {
        throw new NotImplementedException();
    }

    public void BreakDown()
    {
        throw new NotImplementedException();
    }

    public void Fix()
    {
        throw new NotImplementedException();
    }
}
