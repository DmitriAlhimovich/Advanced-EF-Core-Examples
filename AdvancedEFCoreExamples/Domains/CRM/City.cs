using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedEFCoreExamples.Domains.CRM
{
    public class City
    {
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public Country Country { get; set; }

        public long? Latitude { get; set; }
        public long? Longitude { get; set; }
    }
}
