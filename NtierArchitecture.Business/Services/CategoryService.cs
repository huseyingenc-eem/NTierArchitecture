using FluentValidation.Results;
using NtierArchitecture.Business.Abstractions;
using NtierArchitecture.Business.Validators;
using NTierArchitecture.DataAccess.Repositories;
using NTierArchitecture.Entities.Models;
using System.Text;

namespace NtierArchitecture.Business.Services
{
    public class CategoryService : IManager<Category>
    {
        private readonly CategoryRepository Id;

        public CategoryService(CategoryRepository catRepo)
        {
            Id = catRepo;
        }
        public void Create(Category entity)
        {
            //Install-Package FluentValidation
            CategoryValidator cVal = new();
            ValidationResult result=  cVal.Validate(entity);
            //StringBuilder sb = new();
            //result.Errors.ForEach(x=>sb.AppendLine(x.ToString()));
            if (!result.IsValid)
            {
                
                throw new Exception(string.Join("\n",result.Errors));
                //throw new Exception(sb.ToString());
            }
        }

        public void Delete(Guid Id)
        {
            
        }

        public IEnumerable<Category> GetAll()
        {
            throw new Exception("aada");
        }

        public Category GetById(Guid Id)
        {
            throw  new Exception("aada");
        }

        public void Update(Category entity)
        {
            throw new Exception("aada");
        }
    }
}
