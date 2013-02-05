using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using DomainObjects;

namespace ForumContext
{
    public class DbInitializer : DropCreateDatabaseAlways<ForumContext>
    {
        protected override void Seed(ForumContext context)
        {
            var ent = new ThreadEntity
                {
                    Subject = "The First Thread's Subject",
                    Message = "This is the first thread's message.",
                    DatePosted = DateTime.Now,
                    Tag = "TestTag",
                    UserId = 1
                };

            context.Entry(ent).State = EntityState.Added;

            ent = new ThreadEntity()
                {
                    Subject = "The 2nd Thread's Subject",
                    Message = "This is the 2nd thread's message. I Made it longer with this",
                    DatePosted = DateTime.Now,
                    Tag = "TestTag",
                    UserId = 1
                };
            context.Entry(ent).State = EntityState.Added;


            context.SaveChanges();
            base.Seed(context);
        }

        public void InitializeDatabase(ForumContext context)
        {


        }
    }
}
