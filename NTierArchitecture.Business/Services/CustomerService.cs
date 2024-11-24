using NTierArchitecture.Business.Abstractions;
using NTierArchitecture.Business.Validators;
using NTierArchitecture.DataAccess.Repositories;
using NTierArchitecture.Entities.Models;
using System.Linq.Expressions;
using System.Text;
using FluentValidation.Results;

namespace NTierArchitecture.Business.Services
{
    public class CustomerService : IManager<Customer>
    {
        private readonly CustomerRepository _repository;
        public CustomerService(CustomerRepository cusRepo)
        {
            _repository = cusRepo;
        }
        public void Create(Customer entity)
        {
            ValidationControl(entity);

            if (IfEntityExists(c => c.Phone == entity.Phone))
                throw new Exception("Bu müşteri daha önce kayıt edilmiştir.");

            _repository.Create(entity);
        }

        public void Delete(Guid Id)
        {
            var cus = _repository.GetByID(Id);
            if (cus.IsActive)
                throw new Exception("Aktif olan bir Kullanıcı Silinemez.");

            _repository.Delete(cus.Id);
        }

        public IEnumerable<Customer> GetAll()
        {
            return _repository.GetAll();
        }

        public Customer GetByID(Guid Id)
        {
            return _repository.GetByID(Id);
        }

        public bool IfEntityExists(Expression<Func<Customer, bool>> filter)
        {
            return _repository.IfEntityExists(filter);
        }

        public void Update(Customer entity)
        {
            ValidationControl(entity);
            // burda kendisini günceleyebiliyor ama başka bir numaraya güncellediğinde hata mesajı fırlatıyor.
            if (IfEntityExists(c => c.Phone == entity.Phone && c.Id != entity.Id))
                throw new Exception("Güncellemeye Çalıştığınız numarayı başka kullanıcı kullanıyor.");

            if (entity != null)
                _repository.Update(entity);
        }

        public void ValidationControl(Customer entity)
        {
            CustomerValidator cVal = new CustomerValidator();
            ValidationResult result = cVal.Validate(entity);

            if (!result.IsValid)
            {
                StringBuilder sb = new StringBuilder();
                result.Errors.ForEach(r => sb.AppendLine(r.ErrorMessage));
                throw new Exception(sb.ToString());
            }
        }
    }
}
