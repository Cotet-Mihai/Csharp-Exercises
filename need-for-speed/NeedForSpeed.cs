using System;

class RemoteControlCar
{   
    public int Meters = 0;
    private int _fullBattery = 100;
    
    public int Speed;
    private int _batteryDrain;
    
    public RemoteControlCar(int speed, int batteryDrain)
    {
        Speed = speed;
        _batteryDrain = batteryDrain;
    }

    public bool BatteryDrained() => (_fullBattery < _batteryDrain);

    public int DistanceDriven() => Meters;
    public void Drive()
    {
        if (!BatteryDrained())
        {
            Meters += Speed;
            _fullBattery -= _batteryDrain;
        }
    }

    public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);
}

class RaceTrack
{
    private int _distance;
    public RaceTrack(int distance)
    {
        _distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        int numberOfDrive = _distance / car.Speed;
        
        int i = 0;
        while (i <= numberOfDrive)
        {
            car.Drive();
            i++;
        }
        return car.Meters >= _distance;
    }
}
