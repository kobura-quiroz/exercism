static class AssemblyLine
{
    private const int CarsPerHour = 221;

    public static double SuccessRate(int speed) =>
        speed switch
        {
            >= 1 and <= 4 => 1,
            >= 5 and <= 8 => 0.90,
            9 => 0.80,
            10 => 0.77,
            _ => 0
        };

    public static double ProductionRatePerHour(int speed) => 
        speed * CarsPerHour * SuccessRate(speed);

    public static int WorkingItemsPerMinute(int speed) => 
        (int)ProductionRatePerHour(speed) / 60;
}
