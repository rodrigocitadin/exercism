using System;

class RemoteControlCar
{
    private int Battery = 100;
    private int DrivenDistance;

    public static RemoteControlCar Buy() => new RemoteControlCar();

    public string DistanceDisplay() => $"Driven {DrivenDistance} meters";


    public string BatteryDisplay()
    {
        if (Battery <= 0) return $"Battery empty";

        return $"Battery at {Battery}%";
    }

    public void Drive()
    {
        if (Battery > 0)
        {
            Battery -= 1;
            DrivenDistance += 20;
        }
    }
}
