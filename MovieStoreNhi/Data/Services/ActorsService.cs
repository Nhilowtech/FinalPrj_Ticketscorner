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
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(AppDbContext context) : base(context)
        {
        }
    }
}
