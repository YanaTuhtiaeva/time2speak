using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Dal.Interfaces
{
    public interface IAboutRepository<AboutSchool>
    {
        AboutSchool Get();
    }
}
