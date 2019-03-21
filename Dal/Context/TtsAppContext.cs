using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using Dal.Entities;

namespace Dal.Context
{
    class TtsAppContext : DbContext
    {
        public TtsAppContext(string name): base(name)
        {
            
        }

        public DbSet<AboutSchool> AboutSchool { get; set; }
    }
}
