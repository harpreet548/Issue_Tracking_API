using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Issue_Tracking_API.Data;
using Issue_Tracking_API.Models;

namespace Issue_Tracking_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IssueDetailsController : ControllerBase
    {
        private readonly Issue_Tracking_APIContext _context;

        public IssueDetailsController(Issue_Tracking_APIContext context)
        {
            _context = context;
        }

        // GET: api/IssueDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<IssueDetails>>> GetIssueDetails()
        {
            return await _context.IssueDetails.ToListAsync();
        }

        // GET: api/IssueDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IssueDetails>> GetIssueDetails(int id)
        {
            var issueDetails = await _context.IssueDetails.FindAsync(id);

            if (issueDetails == null)
            {
                return NotFound();
            }

            return issueDetails;
        }

        // PUT: api/IssueDetails/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIssueDetails(int id, IssueDetails issueDetails)
        {
            if (id != issueDetails.Id)
            {
                return BadRequest();
            }

            _context.Entry(issueDetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IssueDetailsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/IssueDetails
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<IssueDetails>> PostIssueDetails(IssueDetails issueDetails)
        {
            _context.IssueDetails.Add(issueDetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetIssueDetails", new { id = issueDetails.Id }, issueDetails);
        }

        // DELETE: api/IssueDetails/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<IssueDetails>> DeleteIssueDetails(int id)
        {
            var issueDetails = await _context.IssueDetails.FindAsync(id);
            if (issueDetails == null)
            {
                return NotFound();
            }

            _context.IssueDetails.Remove(issueDetails);
            await _context.SaveChangesAsync();

            return issueDetails;
        }

        private bool IssueDetailsExists(int id)
        {
            return _context.IssueDetails.Any(e => e.Id == id);
        }
    }
}
