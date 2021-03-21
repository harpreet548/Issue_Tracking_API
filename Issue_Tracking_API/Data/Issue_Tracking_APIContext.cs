using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Issue_Tracking_API.Models;

namespace Issue_Tracking_API.Data
{
    public class Issue_Tracking_APIContext : DbContext
    {
        public Issue_Tracking_APIContext (DbContextOptions<Issue_Tracking_APIContext> options)
            : base(options)
        {
        }

        public DbSet<Issue_Tracking_API.Models.IssueDetails> IssueDetails { get; set; }
    }
}
