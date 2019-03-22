using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dal.Context;
using Dal.Entities;
using Dal.Interfaces;

namespace Dal.Repositories
{
    public class AboutRepository : IAboutRepository<AboutSchool>
    {
        private TtsAppContext context;

        public AboutRepository(string name)
        {
            context = new TtsAppContext(name);
        }
        public AboutSchool Get()
        {
            return context.AboutSchool.FirstOrDefault();
        }
    }
}
