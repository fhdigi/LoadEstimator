namespace VilterLoadCalculator.ViewModels
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
