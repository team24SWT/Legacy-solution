﻿using System;

namespace ECS.Legacy
{
    internal class TempSensor
    {
        private Random gen = new Random();

        public int GetTemp()
        {
            return gen.Next(-5, 45);
        }
        //hello world
        public bool RunSelfTest()
        {
            return true;
        }
    }
}