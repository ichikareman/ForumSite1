using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using DomainObjects;

namespace EntityConfig
{
    public class ThreadEntityConfig: EntityTypeConfiguration<ThreadEntity>
    {
        public ThreadEntityConfig()
        {
            ToTable("tbl_thread");
            PropertConfig();
            RelationshipConfig();
        }

        private void PropertConfig()
        {
            Property(e => e.ThreadId).HasColumnName("ThreadId");
            Property(e => e.Subject).HasColumnName("Subject");
            Property(e => e.Message).HasColumnName("Message");
            Property(e => e.DatePosted).HasColumnName("DatePosted");
            Property(e => e.Tag).HasColumnName("Tag");
            Property(e => e.UserId).HasColumnName("UserId");
        }

        private void RelationshipConfig()
        {
            HasKey(e => e.ThreadId);
            //HasMany(e => e.Comments);
            //new System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ThreadEntity>().
            //HasMany(e => e.c
        }
    }
}
