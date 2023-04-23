using MovieStoreNhi.Data.Base;
using MovieStoreNhi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStoreNhi.Data.Services
{
    public interface ICinemasService : IEntityBaseRepository<Cinema>
    {
    }
}