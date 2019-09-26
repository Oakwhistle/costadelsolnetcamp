using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace costadelsoltapas.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemID { get; set; }
        public Tapas Tapas { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartID { get; set; }

    }
}
