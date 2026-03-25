class RemoteControlCar
{
    private int _Speed { get; set; }
    private int _BatteryDrainPercentage { get; set; }
    private int _DistanceDriven { get; set; }
    private int _Battery { get; set; } = 100;

    private const int _nitroSpeed = 50;
    private const int _nitroBatteryDrainPercentage = 4;
    
    public RemoteControlCar()
    {
    }

    public RemoteControlCar(int speed, int batteryDrainPercentage)
    {
        _Speed = speed;
        _BatteryDrainPercentage = batteryDrainPercentage;
    }

    public bool BatteryDrained() => _Battery < _BatteryDrainPercentage;

    public int DistanceDriven() => _DistanceDriven;

    public void Drive() 
    {    
        if (BatteryDrained())
            return;
        _DistanceDriven += _Speed;
        _Battery -= _BatteryDrainPercentage;
    }

    public static RemoteControlCar Nitro() => new RemoteControlCar(_nitroSpeed, _nitroBatteryDrainPercentage);

    public int GetSpeed() => _Speed;
    public int GetBatteryDrainPercentage() => _BatteryDrainPercentage;
}

class RaceTrack
{
    private int _Distance { get; set; }
    
    public RaceTrack(int distance)
    {
        _Distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        var timesThatNeedToDrive = Math.Ceiling(Convert.ToDouble(_Distance) / Convert.ToDouble(car.GetSpeed()));
        var totalBatteryThatWillConsume = timesThatNeedToDrive * car.GetBatteryDrainPercentage();
        return totalBatteryThatWillConsume <= 100;
    }
}
