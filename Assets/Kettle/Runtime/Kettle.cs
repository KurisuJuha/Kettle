using JuhaKurisu.DebugSystem.Logger;

namespace JuhaKurisu.DebugSystem
{
    public class Kettle<TLog>
    {
        public ILogger<TLog> log;
        
        public Kettle(ILogger<TLog> logger)
        {
            this.log = logger;
        }
    }
}