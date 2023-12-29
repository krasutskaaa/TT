namespace ParselAndDelivery.vehicle;

public interface IVehicle
{
    void EngineTurnOn();
    void EngineTurnOff();
    void DriveOneKm();

    void Maintenance();
    void BreakDown();
    void Fix();
}
