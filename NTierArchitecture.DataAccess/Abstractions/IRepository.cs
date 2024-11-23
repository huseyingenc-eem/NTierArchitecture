using NTierArchitecture.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.DataAccess.Abstractions
{
    public interface IRepository<T> where T : Entity
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(Guid Id);
        IEnumerable<T> GetAll();
        T GetById(Guid Id);



        //ICollection<T> GetAll2();
        //IQueryable<T> GetAll3(); // sadece sorgular oluşturur. tavsiye edilmez.
        //List<T> GetAll(); // bütün list ekliyor diğer değişkenlere gerek kalmaz.

    }
}
