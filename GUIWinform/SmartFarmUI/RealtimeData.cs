using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFarmUI
{
    public class RealtimeData
    {
        public double CurrentHumid { get; set;  }
        public double CurrentTemperature { get; set; }
        public double CurrentPresure { get; set; }
        public int CurrentMoiSensor { get; set; }
    }
}
