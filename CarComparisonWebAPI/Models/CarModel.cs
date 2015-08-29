using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarComparisonWebAPI.Models
{
    public class CarModel
    {
        public MakeDetails Make { get; set; }
        public EnergyConsumption Consumpsion { get; set; }
        public Guid ID { get; set; }
        public string ModelName { get; set; }
        public string SubModelName { get; set; }
        public EngineDetails Engine { get; set; }
    }
}