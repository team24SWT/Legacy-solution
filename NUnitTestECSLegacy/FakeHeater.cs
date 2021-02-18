using ECS.Legacy;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestECSLegacy
{
    public class FakeHeater : IHeater
    {
        public bool HeaterTurnedOn;
        public bool HeaterTurnedOff;
        public void TurnOn()
        {
            System.Console.WriteLine("Heater is on");
            HeaterTurnedOn = true;
        }
        public void TurnOff()
        {
            System.Console.WriteLine("Heater is off");
            HeaterTurnedOff = true;
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
