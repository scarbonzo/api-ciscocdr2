using api_ciscocdr2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace api_ciscocdr2.Controllers.v1
{
    [ApiController]
    [Produces("application/json")]
    [Route("v1/calls")]
    public class CallsController : ControllerBase
    {
        private readonly CallAnalyzerContext _context;

        public CallsController(CallAnalyzerContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get(DateTime? Start = null, DateTime? End = null, string Number = null, string Device = null, string Cause = null, int take = 25, int skip = 0)
        {
            if (Start == null)
            {
                Start = DateTime.Now.Date;
            }

            if (End == null)
            {
                End = DateTime.Now.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
            }

            var calls = _context.Calls
                .Where(c => c.DateTimeDisconnect >= Start && c.DateTimeDisconnect <= End);

            if (Number != null)
            {
                calls = calls
                    .Where(c => c.CallingPartyNumber.Contains(Number) || c.OriginalCalledPartyNumber.Contains(Number) || c.FinalCalledPartyNumber.Contains(Number));
            }

            if (Device != null)
            {
                calls = calls
                    .Where(c => c.OrigDeviceName.Contains(Device) || c.DestDeviceName.Contains(Device));
            }

            if (Cause != null)
            {
                calls = calls
                    .Where(c => c.OrigCauseValue == Cause || c.DestCauseValue == Cause);
            }

            var results = calls
                .Skip(skip)
                .Take(take)
                .OrderByDescending(c => c.DateTimeDisconnect);

            return Ok(results);
        }

        [HttpGet]
        [Route("{Id}")]
        public ActionResult GetById(string Id)
        {
            try
            {
                var result = _context.Calls
                    .Where(c => c.Pkid == "\"" + Id + "\"")
                    .FirstOrDefault();

                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return NotFound();
                }
            }
                catch
            {
                return BadRequest(Id);
            }
        }
    }
}
