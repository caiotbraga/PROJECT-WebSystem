using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Data;
using SalesWebMvc.Models;

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcContext context;

        public SellerService(SalesWebMvcContext c)
        {
            context = c;
        }

        public List<Seller> FindAll()
        {
            return context.Seller.ToList();
        }
    }
}
