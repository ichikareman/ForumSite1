using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using DomainObjects;
using EntityConfig;

namespace ForumContext
{
    public class ForumContext:DbContext
    {
        IDbSet<ThreadEntity> ThreadEntities { get; set; }

        public ForumContext():base("name=ForumContext")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ThreadEntityConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}
