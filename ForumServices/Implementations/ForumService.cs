using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DomainObjects;

namespace ForumServices.Implementations
{
    public class ForumService:IForumService
    {
        private ForumContext.ForumContext _context;

        public ForumService()
        {
            _context = new ForumContext.ForumContext();
        }

        public IEnumerable<ThreadEntity> GetAll()
        {
            return _context.Set<ThreadEntity>().AsEnumerable();
        }

        public ThreadEntity Get(int threadId)
        {
            return _context.Set<ThreadEntity>().FirstOrDefault(e => e.ThreadId == threadId);
        }
    }
}
