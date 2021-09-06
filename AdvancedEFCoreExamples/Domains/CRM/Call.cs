using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedEFCoreExamples.Domains.CRM
{
    public class Call
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public CallOutcome Outcome { get; set; }
    }
}
