using System;
using System.Collections.Generic;
using System.Text;

namespace _07.RawData
{
    public class Engine
    {
        public Engine(int speed, int power)
        {
            EngineSpeed = speed;
            EnginePower = power;
        }
        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }
    }
}
