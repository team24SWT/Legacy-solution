﻿namespace ECS.LegacyCore
{
    public class ECS
    {
        private int _threshold;
        private readonly ITempSensor _tempSensor;
        private readonly IHeater _heater;

        public ECS(int thr, ITempSensor tempsensor, IHeater heater)
        {
            SetThreshold(thr);
            _tempSensor = tempsensor;
            _heater = heater;
        }

        public void Regulate()
        {
            var t = _tempSensor.GetTemp();
            if (t < _threshold)
                _heater.TurnOn();
            else
                _heater.TurnOff();

        }

        public void SetThreshold(int thr)
        {
            _threshold = thr;
        }

        public int GetThreshold()
        {
            return _threshold;
        }

        public int GetCurTemp()
        {
            return _tempSensor.GetTemp();
        }

        //public bool GetIsHeaterOn()
        //{
        //    return _heater.isHeaterOn();
        //}

        //public bool GetIsHeaterOff()
        //{
        //    return _heater.isHeaterOff();
        //}

        public bool RunSelfTest()
        {
            return _tempSensor.RunSelfTest() && _heater.RunSelfTest();
        }
    }
}
