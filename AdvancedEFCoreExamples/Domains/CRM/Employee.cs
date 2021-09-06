using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedEFCoreExamples.Domains.CRM
{
    public class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime HireDate { get; set; }
    }
}
