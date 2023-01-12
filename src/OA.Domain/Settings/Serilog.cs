using System.Collections.Generic;

namespace OA.Domain.Settings
{
    public class Serilog
    {
        public string MinimumLevel { get; set; }
        public List<WriteToItem> WriteTo { get; set; }
        public Properties Properties { get; set; }
    }



}
