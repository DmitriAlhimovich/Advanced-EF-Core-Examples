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
            var calls = await _context.Calls.ToListAsync();

            return calls.AsEnumerable();
        }
    }
}
