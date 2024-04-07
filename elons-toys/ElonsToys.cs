using System;

class RemoteControlCar
{
    // fields
    private int totalBattery = 100;
    private int totalDistance = 0;
    
    public static RemoteControlCar Buy() => new RemoteControlCar();

    public string DistanceDisplay() => $"Driven {totalDistance} meters";

    public string BatteryDisplay() => (totalBattery != 0 ) ? $"Battery at {totalBattery}%" : "Battery empty";

    public void Drive()
    {
        if (totalBattery != 0)
        {
            totalBattery--;
            totalDistance += 20;
        }
    }
}
