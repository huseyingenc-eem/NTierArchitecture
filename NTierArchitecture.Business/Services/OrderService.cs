using NTierArchitecture.Business.Abstractions;
using FluentValidation.Results;
using NTierArchitecture.Business.Validators;
using NTierArchitecture.DataAccess.Repositories;
using NTierArchitecture.Entities.Models;
using System.Text;
using System.Linq.Expressions;


namespace NTierArchitecture.Business.Services
{
    public class OrderService : IManager<Order>
    {
        private readonly OrderRepository _repository;
        public OrderService(OrderRepository orderRepo)
        {
            _repository = orderRepo;
        }

        public void Create(Order entity)
        {
            ValidationControl(entity);
            // aynı müşteriyi kullandığım için iptal ettim normal programda burasıda var 
            //if (IfEntityExists(o => o.CustomerID == entity.CustomerID && o.OrderDate == entity.OrderDate))
            //    throw new Exception("Bu sipariş daha önce kayıt edilmiştir.");

            _repository.Create(entity);
        }

        public void Delete(Guid Id)
        {
            var Order = _repository.GetByID(Id);
            if (Order.IsActive)
                throw new Exception("Aktif olan bir sipariş silinemez");

            _repository.Delete(Order.Id);
        }

        public IEnumerable<Order> GetAll()
        {
            return _repository.GetAll();
        }

        public Order GetByID(Guid Id)
        {
            if (Id == Guid.Empty)
                throw new Exception("Id bulunamadı.");

            return _repository.GetByID(Id);
        }

        public bool IfEntityExists(Expression<Func<Order, bool>> filter)
        {
            return _repository.IfEntityExists(filter);
        }

        public void Update(Order entity)
        {
            ValidationControl(entity);

            if (entity != null)
                _repository.Update(entity);
        }

        public void ValidationControl(Order entity)
        {
            OrderValidator oVal = new OrderValidator();
            ValidationResult result = oVal.Validate(entity);

            if (!result.IsValid)
            {
                StringBuilder sb = new StringBuilder();
                result.Errors.ForEach(r => sb.AppendLine(r.ErrorMessage));
                throw new Exception(sb.ToString());
            }
        }
    }
}
