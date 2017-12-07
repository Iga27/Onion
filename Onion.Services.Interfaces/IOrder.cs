using Onion.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Services.Interfaces
{
    public interface IOrder //we dont have repository of orders(we do not need store orders in db unlike books)
    {
        void MakeOrder(Book book);
    }
}
