using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N5Challenge.Infrastructure.Repositories.Interfaces
{
    public interface IBaseRepository
    {
        Task SaveChangesAsync();
        Task AddAsync(object entity);
    }
}
