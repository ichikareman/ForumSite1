using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainObjects
{
    public class CommentEntity
    {
        public int ThreadId { get; set; }
        public int CommendId { get; set; }
        public string Message { get; set; }
        public DateTime DatePosted { get; set; }

        public int UserId { get; set; }
    }
}
