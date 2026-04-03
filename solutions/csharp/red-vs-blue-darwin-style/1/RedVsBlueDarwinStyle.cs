namespace BlueRemoteControlCarTeam
{
    using Combined;
    
    public class RemoteControlCar
    {
        public RemoteControlCar(Motor motor, Chassis chassis, Telemetry telemetry)
        {
        }
    }
}

namespace RedRemoteControlCarTeam
{
    using Combined;
    
    public class RemoteControlCar
    {
        public RemoteControlCar(Motor motor, Chassis chassis, Telemetry telemetry, RunningGear runningGear)
        {
        }
    }
}


namespace Combined 
{
    public class RunningGear { }

    public class Telemetry { }

    public class Chassis { }

    public class Motor { }

    public static class CarBuilder
    {
        public static RedRemoteControlCarTeam.RemoteControlCar BuildRed()
        {
            return new RedRemoteControlCarTeam.RemoteControlCar(
                new Motor(),
                new Chassis(),
                new Telemetry(),
                new RunningGear()
            );
        }

        public static BlueRemoteControlCarTeam.RemoteControlCar BuildBlue()
        {
            return new BlueRemoteControlCarTeam.RemoteControlCar(
                new Motor(),
                new Chassis(),
                new Telemetry()
            );
        }
    }
}
