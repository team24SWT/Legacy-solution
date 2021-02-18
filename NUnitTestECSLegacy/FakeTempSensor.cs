using ECS.Legacy;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestECSLegacy 
{
    public class FakeTempSensor : ITempSensor
    {
        private int temp_;
        public FakeTempSensor(int temp)
        {
            temp_ = temp;
        }
        public int GetTemp()
        {
            return temp_;
        }
        public bool RunSelfTest()
        {
            return true;
        }
    }
}
