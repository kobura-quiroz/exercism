class RemoteControlCar
{
    private int _distanceDriven = 0;
    private int _battery = 100;
    
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {_distanceDriven} meters";
    }

    public string BatteryDisplay()
    {
        return _battery > 0 ? $"Battery at {_battery}%" : "Battery empty";
    }

    public void Drive()
    {
        if (_battery == 0) return;
        _distanceDriven += 20;
        _battery -= 1;
    }
}
