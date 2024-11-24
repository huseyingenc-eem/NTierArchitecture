using NTierArchitecture.Business.Abstractions;
using NTierArchitecture.Business.Validators;
using NTierArchitecture.DataAccess.Repositories;
using NTierArchitecture.Entities.Models;
using System.Linq.Expressions;
using System.Text;
using FluentValidation.Results;

namespace NTierArchitecture.Business.Services
{
    public class EmployeeService : IManager<Employee>
    {
        private readonly EmployeeRepository _repository;
        public EmployeeService(EmployeeRepository empRepo)
        {
            _repository = empRepo;
        }

        public void Create(Employee entity)
        {
            ValidationControl(entity);

            if (IfEntityExists(e => e.Phone == entity.Phone))
                throw new Exception("Bu Çalışan daha önce kayıt edilmiştir.");

            _repository.Create(entity);
        }

        public void Delete(Guid Id)
        {
            var cat = _repository.GetByID(Id);
            if (cat.IsActive)
                throw new Exception("Aktif olan bir çalışan silinemez");

            _repository.Delete(cat.Id);
        }

        public IEnumerable<Employee> GetAll()
        {
            return _repository.GetAll();
        }

        public Employee GetByID(Guid Id)
        {
            return _repository.GetByID(Id);
        }


        public bool IfEntityExists(Expression<Func<Employee, bool>> filter)
        {
            return _repository.IfEntityExists(filter);
        }

        public void Update(Employee entity)
        {
            ValidationControl(entity);

            if (IfEntityExists(e => e.Phone == entity.Phone &&
                e.Id != entity.Id))
                throw new Exception("Güncellemeye çalıştığınız numarayı başka Çalışan kullanıyor.");

            if (entity != null)
                _repository.Update(entity);
        }

        public void ValidationControl(Employee entity)
        {
            EmployeeValidator eVal = new EmployeeValidator();
            ValidationResult result = eVal.Validate(entity);

            if (!result.IsValid)
            {
                StringBuilder sb = new StringBuilder();
                result.Errors.ForEach(r => sb.AppendLine(r.ErrorMessage));
                throw new Exception(sb.ToString());
            }
        }
    }
}
