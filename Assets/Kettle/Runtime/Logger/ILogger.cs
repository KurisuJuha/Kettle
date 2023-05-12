using System;

namespace JuhaKurisu.DebugSystem.Logger
{
    public interface ILogger<in T>
    {
        public void Log(T s);
    }
}