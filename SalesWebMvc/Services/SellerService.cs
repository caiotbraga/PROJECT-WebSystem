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

        public List<Seller> FindAll()
        {
            return context.Seller.ToList();
        }

        public void Insert(Seller s)
        {
            context.Add(s);
            context.SaveChanges();
        }

        public Seller FindByID(int id)
        {
            return context.Seller.Include(obj => obj.Department).FirstOrDefault(s => s.Id == id);
        }

        public void Remove(int id)
        {
            var seller = context.Seller.Find(id);
            context.Seller.Remove(seller);
            context.SaveChanges();
        }

        public void Update(Seller obj)
        {
            if(!context.Seller.Any(x => x.Id == obj.Id))
            {
                throw new NotFoundException("Id not found!");
            }

            try //need try first cuz when you update a db can have some exceptions that need be trated
            {
                context.Update(obj);
                context.SaveChanges();
            }catch(DbUpdateConcurrencyException e) //catching a data acess exception and throwing a service exception 
            {
                throw new DbConcurrencyException(e.Message);
            }
        }

    }
}
