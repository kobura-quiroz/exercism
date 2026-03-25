class RemoteControlCar
{
    private int _speed;
    private int _batteryDrainPercentage;
    private int _distanceDriven;
    private int _battery = 100;

    private const int _nitroSpeed = 50;
    private const int _nitroBatteryDrainPercentage = 4;
    
    public RemoteControlCar(int speed, int batteryDrainPercentage)
    {
        _speed = speed;
        _batteryDrainPercentage = batteryDrainPercentage;
    }

    public bool BatteryDrained() => _battery < _batteryDrainPercentage;

    public int DistanceDriven() => _distanceDriven;

    public void Drive() 
    {    
        if (BatteryDrained())
            return;
        _distanceDriven += _speed;
        _battery -= _batteryDrainPercentage;
    }

    public static RemoteControlCar Nitro() => new RemoteControlCar(_nitroSpeed, _nitroBatteryDrainPercentage);

    public int Speed => _speed;
    public int BatteryDrainPercentage => _batteryDrainPercentage;
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
        var timesThatNeedToDrive = (_distance + car.Speed - 1) / car.Speed;
        var totalBatteryThatWillConsume = timesThatNeedToDrive * car.BatteryDrainPercentage;
        return totalBatteryThatWillConsume <= 100;
    }
}
