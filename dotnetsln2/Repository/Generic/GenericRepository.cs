using dotnetsln2.Models.Base;
using dotnetsln2.Models.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace dotnetsln2.Repository.Generic
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationContext _context;
        private DbSet<T> dataset;

        public GenericRepository(ApplicationContext context)
        {
            _context = context;
            dataset = context.Set<T>();
        }

        public T Create(T item)
        {
            try
            {
                var created = dataset.Add(item).Entity;
                _context.SaveChanges();
                return created;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(long id)
        {
            try
            {
                var delete = dataset.FirstOrDefault(item => item.Id == id);
                dataset.Remove(delete);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public T Edit(T item)
        {
            try
            {
                _context.Entry(item).State = EntityState.Modified;
                _context.SaveChanges();
                return item;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<T> FindAll()
        {
            try
            {
                return dataset.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public T FindById(long id)
        {
            try
            {
                return dataset.FirstOrDefault(item => item.Id == id);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
