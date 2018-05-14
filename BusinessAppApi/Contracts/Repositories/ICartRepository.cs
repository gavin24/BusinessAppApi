using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Models;

namespace BusinessApp.Contracts.Repositories
{
  public  interface ICartRepository : IRepository<Cart>
    {
      Cart GetCartByClientId(long clientId);
  }
}
