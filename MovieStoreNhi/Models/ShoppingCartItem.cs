using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MovieStoreNhi.Data.Base;
using MovieStoreNhi.Models;

namespace MovieStoreNhi.Models
{
    public class ShoppingCartItem: IEntityBase
    {
        [Key]
        public int Id { get; set; }

        public Movie Movie { get; set; }
        public int Amount { get; set; }


        public string ShoppingCartId { get; set; }
    }
}