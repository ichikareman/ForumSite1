using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForumSite.Models
{
    public class ThreadModel
    {
        public int ThreadId { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime DatePosted { get; set; }
        public string Tag { get; set; }
    }
}