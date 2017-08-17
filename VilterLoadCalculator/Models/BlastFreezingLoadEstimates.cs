using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using VilterLoadCalculator.Data;

namespace VilterLoadCalculator.Models
{
    class BlastFreezingLoadEstimates : DatabaseService<BlastFreezingLoadEstimates>
    {
        public string Product { get; set; }
        public int Amount { get; set; }
        public int Weight { get; set; }
        public int SupplyAirTemp { get; set; }
        public int SupplyAirVelocity { get; set; }
        public int ProductTempEntering { get; set; }
        public int ProductTempLeaving { get; set; }
        public int HeatRemoved { get; set; }
        public string EstimatedTimeHeatRemoval { get; set; }

        private void GetProperty()

        {

        }
        

    }

    


}

