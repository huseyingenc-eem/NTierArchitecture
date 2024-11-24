using NTierArchitecture.Business.Abstractions;
using FluentValidation.Results;
using NTierArchitecture.DataAccess.Repositories;
using NTierArchitecture.Entities.Models;
using System.Linq.Expressions;
using NTierArchitecture.Business.Validators;
using System.Text;


namespace NTierArchitecture.Business.Services
{
    public class ProductService : IManager<Product>
    {
        private readonly ProductRepository _repository;
        public ProductService(ProductRepository proRepo)
        {
            _repository = proRepo;
        }

        public void Create(Product entity)
        {
            ValidationControl(entity);

            if (IfEntityExists(p => p.ProductName == entity.ProductName && p.SupplierID == entity.SupplierID))
                throw new Exception("Bu Ürün aynı tedarikçide zaten eklenmiştir.");

            _repository.Create(entity);
        }

        public void Delete(Guid Id)
        {
            var cat = _repository.GetByID(Id);
            if (cat.IsActive)
                throw new Exception("Aktif olan bir Ürün silinemez");

            _repository.Delete(cat.Id);
        }

        public IEnumerable<Product> GetAll()
        {
            return _repository.GetAll();
        }

        public Product GetByID(Guid Id)
        {
            return _repository.GetByID(Id);
        }

        public bool IfEntityExists(Expression<Func<Product, bool>> filter)
        {
            return _repository.IfEntityExists(filter);
        }
        

        public void Update(Product entity)
        {
            ValidationControl(entity);

            if (IfEntityExists(p => p.ProductName == entity.ProductName && p.SupplierID == entity.SupplierID))
                throw new Exception("Bu Ürün aynı tedarikçide zaten eklenmiştir.");

            if (entity != null)
                _repository.Update(entity);
        }

        public void ValidationControl(Product entity)
        {
            ProductValidator pVal = new ProductValidator();
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
