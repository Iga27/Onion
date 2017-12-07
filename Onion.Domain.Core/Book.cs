using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Domain.Core
{
    public class Book
    { //in DDD domain class also consists of different methods and have additional domain service
        //and all implementation in domain layer
        //application service should be really thin

        /*Onion Architecture is all about making the Domain/BusinessLogic independant on 'inferior' things like data-acccess, UI, services etc.
         * The Onion Architecture doesn't really care how you made the domain you have - it's adamant about protecting it from outside dependencies.*/

            //onion and ddd is a bit more different things
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
