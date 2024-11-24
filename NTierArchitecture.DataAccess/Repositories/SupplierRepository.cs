using NTierArchitecture.DataAccess.Context;
using NTierArchitecture.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.DataAccess.Repositories
{
    public class SupplierRepository : GenericRepository<Supplier>
    {
        public SupplierRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
