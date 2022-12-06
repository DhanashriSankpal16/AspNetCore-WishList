using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WishList.Models
{
    public class Item
    {
        public int Id { get; set; }

        [Requied]
        [MaxLength(50)]
        public string Description { get; set; }
    }
}

