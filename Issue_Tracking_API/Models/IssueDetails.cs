using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Issue_Tracking_API.Models
{
    public class IssueDetails
    {
        public int Id { get; set; }
        public string Issue_Description { get; set; }
        public string Issue_Reporter_Name { get; set; }
        public DateTime Issue_Reported_Date { get; set; }
        public string Issue_Assignee_Name { get; set; }
    }
}
