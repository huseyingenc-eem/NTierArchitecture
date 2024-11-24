using NTierArchitecture.Business.Abstractions;
using NTierArchitecture.Business.Validators;
using NTierArchitecture.DataAccess.Repositories;
using NTierArchitecture.Entities.Models;
using System.Linq.Expressions;
using System.Text;
using FluentValidation.Results;
using System.Xml;

namespace NTierArchitecture.Business.Services
{
    public class OrderDetailService : IManager<OrderDetail>
    {
        private readonly OrderDetailRepository _repository;
        public OrderDetailService(OrderDetailRepository orderRepo)
        {
            
            _repository = orderRepo;
        }

        public void Create(OrderDetail entity)
        {
            ValidationControl(entity);

            if (IfEntityExists(od => od.OrderID == entity.OrderID && od.ProductID == entity.ProductID))
                throw new Exception("Bu ürün zaten bu siparişe eklenmiştir.");

            _repository.Create(entity);
        }

        public void Delete(Guid Id)
        {
            var cat = _repository.GetByID(Id);
            if (cat.IsActive)
                throw new Exception("Aktif olan bir sipariş silinemez");

            _repository.Delete(cat.Id);
        }

        public IEnumerable<OrderDetail> GetAll()
        {
            return _repository.GetAll();
        }

        public OrderDetail GetByID(Guid Id)
        {
            return _repository.GetByID(Id);
        }

        public bool IfEntityExists(Expression<Func<OrderDetail, bool>> filter)
        {
            return _repository.IfEntityExists(filter);
        }

        public void Update(OrderDetail entity)
        {
            ValidationControl(entity);

            if (entity != null)
                _repository.Update(entity);
        }

        public void ValidationControl(OrderDetail entity)
        {
            OrderDetailValidator odVal = new OrderDetailValidator();
            ValidationResult result = odVal.Validate(entity);

            if (!result.IsValid)
            {
                StringBuilder sb = new StringBuilder();
                result.Errors.ForEach(r => sb.AppendLine(r.ErrorMessage));
                throw new Exception(sb.ToString());
            }
        }
    }
}
