using System.Collections.Generic;

namespace VilterLoadCalculator.ViewModels
{
    public class RoomLoadViewModel
    {
        public List<string> Products { get; set; }
        public double Flow { get; set; }
        public double TemperatureToMaintain { get; set; }
        public double TemperatureEnviroment { get; set; }
        int Fluid { get; set; }
        public double RoomLoad { get; set; }
    }


}
