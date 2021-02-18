namespace ECS.Legacy
{
    public class Heater : IHeater
    {
        public bool HeaterTurnedOn;
        public bool HeaterTurnedOff;
        public void TurnOn()
        {
            System.Console.WriteLine("Heater is on");
        }
        
        public void TurnOff()
        {
            System.Console.WriteLine("Heater is off");
        }
        //public bool isHeaterOn()
        //{
        //    return HeaterTurnedOn;
        //}
        //public bool isHeaterOff()
        //{
        //    return HeaterTurnedOff;
        //}

        public bool RunSelfTest()
        {
            return true;
        }
    }
}