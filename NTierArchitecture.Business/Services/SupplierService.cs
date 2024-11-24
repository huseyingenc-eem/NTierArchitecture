using NTierArchitecture.Business.Abstractions;
using NTierArchitecture.Business.Validators;
using NTierArchitecture.DataAccess.Repositories;
using NTierArchitecture.Entities.Models;
using System.Linq.Expressions;
using System.Text;
using FluentValidation.Results;

namespace NTierArchitecture.Business.Services
{
    public class SupplierService : IManager<Supplier>
    {
        private readonly SupplierRepository _repository;

        public SupplierService(SupplierRepository suprepo)
        {
            _repository = suprepo;
        }

        public void Create(Supplier entity)
        {
            ValidationControl(entity);


            if (IfEntityExists(s => (s.CompanyName == entity.CompanyName ||
                s.Phone == entity.Phone) &&
                s.Id != entity.Id))
                throw new Exception("Bu tedarikçi daha önce kayıt edilmiştir.");

            _repository.Create(entity);
        }

        public void Delete(Guid Id)
        {
            var cat = _repository.GetByID(Id);
            if (cat.IsActive)
                throw new Exception("Aktif olan bir tedarikçi silinemez");

            _repository.Delete(cat.Id);
        }

        public IEnumerable<Supplier> GetAll()
        {
            return _repository.GetAll();
        }

        public Supplier GetByID(Guid Id)
        {
            return _repository.GetByID(Id);
        }

        public bool IfEntityExists(Supplier entity)
        {
            return _repository.IfEntityExists(
                s => (s.CompanyName == entity.CompanyName ||
                s.Phone == entity.Phone) &&
                s.Id != entity.Id);
        }

        public bool IfEntityExists(Expression<Func<Supplier, bool>> filter)
        {
            return _repository.IfEntityExists(filter);
        }

        public void Update(Supplier entity)
        {
            ValidationControl(entity);

            if (IfEntityExists(s => (s.CompanyName == entity.CompanyName || s.Phone == entity.Phone) && s.Id != entity.Id))
                throw new Exception("Değiştirmeye çalıştığınız bilgiler başka kullanıca kullanılıyor.");
                
            if (entity != null)
                _repository.Update(entity);
        }

        public void ValidationControl(Supplier entity)
        {
            SupplierValidator sVal = new SupplierValidator();
            ValidationResult result = sVal.Validate(entity);

            if (!result.IsValid)
            {
                StringBuilder sb = new StringBuilder();
                result.Errors.ForEach(r => sb.AppendLine(r.ErrorMessage));
                throw new Exception(sb.ToString());
            }
        }
    }
}
