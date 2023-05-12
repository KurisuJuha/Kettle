using System;
using UnityEngine;

namespace JuhaKurisu.DebugSystem.Logger
{
    public class UnityLogger : ILogger<string>
    {
        public void Log(string s)
        {
            Debug.Log(s);
        }
    }
}