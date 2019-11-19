using Microsoft.EntityFrameworkCore;
using OA.DomainEntities;
using OA.Repo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OA.Repo.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationContext _context;
        private DbSet<T> entities;
        string errorMessage = string.Empty;

        public Repository(ApplicationContext context)
        {
            this._context = context;
            entities = context.Set<T>();
        }

        public void Delete(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException();
            Remove(entity);
            SaveChanges();
        }

        public T Get(long Id)
        {
            return entities.SingleOrDefault(x => x.Id == Id);
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public void Insert(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            entities.Add(entity);
            SaveChanges();
        }

        public void Remove(T entity)
        {
            if(entity == null)
                throw new ArgumentNullException("entity");
            entities.Remove(entity);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            SaveChanges();
        }
    }
}
