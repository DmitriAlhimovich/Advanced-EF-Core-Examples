using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdvancedEFCoreExamples.Domains.CRM;
using AdvancedEFCoreExamples.Domains.CRM.Context;
using Microsoft.EntityFrameworkCore;

namespace AdvancedEFCoreExamples.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CallController : ControllerBase
    {
        private readonly CrmContext _context;

        public CallController(CrmContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Call>> Get()
        {
            return await _context.Calls.ToListAsync();
        }

        [HttpGet("avgCallDurationByEmployee")]
        public async Task<IEnumerable<CallDurationByEmployeeModel>> GetAverageCallDurationByEmployee()
        {
            var result = await _context.Calls.Include(c => c.Employee).GroupBy(c => new {c.EmployeeId, c.Employee.LastName}).Select(g =>
                new CallDurationByEmployeeModel()
                {
                    EmployeeName = g.Key.LastName,
                    CallDuration = g.Average(c => EF.Functions.DateDiffMinute(c.StartTime, c.EndTime))
                }).ToListAsync();

            return result;
        }

        //[HttpGet("avgLeadCallDurationByEmployee")]
        //public async Task<IEnumerable<CallDurationByEmployeeModel>> avgLeadCallDurationByEmployee()
        //{
        //}

        //[HttpGet("avgComplaintCallDurationByEmployee")]
        //public async Task<IEnumerable<CallDurationByEmployeeModel>> avgComplaintCallDurationByEmployee()
        //{
        //}

        //[HttpGet("employeeWithMaxLeads")]
        //public async Task<IEnumerable<CallDurationByEmployeeModel>> employeeWithMaxLeads()
        //{
        //}
    }

    public class CallDurationByEmployeeModel
    {
        public string EmployeeName { get; set; }
        public double CallDuration { get; set; }
    }
}
