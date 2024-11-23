using Microsoft.EntityFrameworkCore;
using NTierArchitecture.DataAccess.Abstractions;
using NTierArchitecture.DataAccess.Context;
using NTierArchitecture.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.DataAccess.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : Entity
    {
        private readonly ApplicationDBContext _dbContext;
        private readonly DbSet<T> _dbSet;
        public GenericRepository(ApplicationDBContext context) 
        {
            _dbContext = context;
            _dbSet = _dbContext.Set<T>();
        }
        public void Create(T entity)
        {
            _dbSet.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(Guid Id)
        {
            _dbSet.Remove(GetById(Id));
            _dbContext.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(Guid Id)
        {
            //var data=_dbSet.FirstOrDefault(x=>x.ID==Id);
            //if (data == null)
            //{
            //    throw new Exception("Bulunmadı.");
            //}
            //return data;
            // !bir ifadenin kesinlikle null gelmeyeceğini bildirmek için kullanılır.
            return (_dbSet.FirstOrDefault(x => x.ID == Id))! ?? throw new InvalidOperationException("Id bulunamadı.") ;
        }

        public void Update(T entity)
        {
            _dbContext.SaveChanges();
        }
    }
}
