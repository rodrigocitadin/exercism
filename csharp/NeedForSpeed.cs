using System;

class RemoteControlCar
{
    private int _speed;
    private int _batteryDrain;
    private int _battery = 100;
    private int _distanceDriven = 0;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        _speed = speed;
        _batteryDrain = batteryDrain;
    }

    public bool BatteryDrained() => _batteryDrain > _battery ? true : false;

    public int DistanceDriven() => _distanceDriven;

    public void Drive()
    {
        if (_batteryDrain > _battery) return;

        _distanceDriven += _speed;
        _battery -= _batteryDrain;
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
        while (car.DistanceDriven() < _distance && !car.BatteryDrained())
        {
            car.Drive(); 
        }

        return car.DistanceDriven() >= _distance;
    }
}

