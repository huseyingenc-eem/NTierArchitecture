using FluentValidation;
using FluentValidation.Results;
using NTierArchitecture.Business.Abstractions;
using NTierArchitecture.Business.Validators;
using NTierArchitecture.DataAccess.Repositories;
using NTierArchitecture.Entities.Abstractions;
using NTierArchitecture.Entities.Models;
using System.Linq.Expressions;
using System.Text;

namespace NTierArchitecture.Business.Services
{
    public class CategoryService : IManager<Category>
    {
        private readonly CategoryRepository _repository;
        public CategoryService(CategoryRepository catRepo)
        {
            _repository = catRepo;
        }
        public void Create(Category entity)
        {
            ValidationControl(entity);

            if (IfEntityExists(c => c.CategoryName == entity.CategoryName))
                throw new Exception("Bu kategori daha önce kayıt edilmiştir.");

            _repository.Create(entity);
        }

        public void Delete(Guid Id)
        {
            var cat=_repository.GetByID(Id);
            if (cat.IsActive)
                throw new Exception("Aktif olan bir kategori silinemez");

            _repository.Delete(cat.Id);
        }

        public IEnumerable<Category> GetAll()
        {
            return _repository.GetAll();
        }

        public Category GetByID(Guid Id)
        {
            return _repository.GetByID(Id);
        }


        public bool IfEntityExists(Expression<Func<Category, bool>> filter)
        {
            return _repository.IfEntityExists(filter);
        }

        public void Update(Category entity)
        {
            ValidationControl(entity);

            if (entity!=null)
                _repository.Update(entity);
        }

        public void ValidationControl(Category entity)
        {
            CategoryValidator pVal = new CategoryValidator();
            ValidationResult result = pVal.Validate(entity);

            if (!result.IsValid)
            {
                StringBuilder sb = new StringBuilder();
                result.Errors.ForEach(r => sb.AppendLine(r.ErrorMessage));
                throw new Exception(sb.ToString());
            }
        }
    }
}
