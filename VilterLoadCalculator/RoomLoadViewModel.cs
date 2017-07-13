using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VilterLoadCalculator
{
    class RoomLoadViewModel
    {
        public double Flow { get; set; }

        public double TemperatureToMaintain
        {
            get
            {
                return TemperatureToMaintain;
            }
            set
            {
                TemperatureToMaintain = value;
            }
        }

        private double _temperatureEnvironment;
        public double TemperatureEnviroment
        {
            get
            {
                return _temperatureEnvironment;
            }
            set
            {
                _temperatureEnvironment = value;
            }
        }

        int FLuid { get; set; }

        public double RoomLoad { get; set; }


          }
}
