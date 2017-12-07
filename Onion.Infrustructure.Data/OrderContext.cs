using Onion.Domain.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Infrustructure.Data
{
    public class OrderContext: DbContext
    {
        public OrderContext() : base("OrderContext") { }

        public DbSet<Book> Books { get; set; }
    }
}
