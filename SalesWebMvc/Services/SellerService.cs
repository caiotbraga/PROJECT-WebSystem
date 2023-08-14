using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Data;
using SalesWebMvc.Models;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Services.Exceptions;

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcContext context;

        public SellerService(SalesWebMvcContext c)
        {
            context = c;
        }

        public async Task<List<Seller>> FindAllAsync()
        {
            return await context.Seller.ToListAsync();
        }

        public async Task InsertAsync(Seller s)
        {
            context.Add(s);
            await context.SaveChangesAsync();
        }

        public async Task<Seller> FindByIDAsync(int id)
        {
            return await context.Seller.Include(obj => obj.Department).FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            var seller = await context.Seller.FindAsync(id);
            context.Seller.Remove(seller);
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Seller obj)
        {
            bool hasAny = await context.Seller.AnyAsync(x => x.Id == obj.Id);
            if (!hasAny)
            {
                throw new NotFoundException("Id not found!");
            }

            try //need try first cuz when you update a db can have some exceptions that need be trated
            {
                context.Update(obj);
                await context.SaveChangesAsync();
            }catch(DbUpdateConcurrencyException e) //catching a data acess exception and throwing a service exception 
            {
                throw new DbConcurrencyException(e.Message);
            }
        }

    }
}
