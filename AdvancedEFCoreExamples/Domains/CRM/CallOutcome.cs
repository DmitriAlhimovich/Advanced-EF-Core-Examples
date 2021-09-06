using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedEFCoreExamples.Domains.CRM
{
    public class CallOutcome
    {
        public int CallId { get; set; }
        public Call Call { get; set; }

        public OutcomeType Type { get; set; }
        public string Comments { get; set; }

    }
}
