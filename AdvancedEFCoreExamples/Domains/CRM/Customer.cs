using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedEFCoreExamples.Domains.CRM
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string CityName { get; set; }
        public string CityCountryCode { get; set; }
        public City City { get; set; }

        public string Address { get; set; }

        public DateTime NextCall { get; set; }
    }
}
