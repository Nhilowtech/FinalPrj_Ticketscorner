using MovieStoreNhi.Data;
using MovieStoreNhi.Data.Base;
using MovieStoreNhi.Data.Services;
using MovieStoreNhi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStoreNhi.Data.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(AppDbContext context) : base(context)
        {
        }
    }
}
