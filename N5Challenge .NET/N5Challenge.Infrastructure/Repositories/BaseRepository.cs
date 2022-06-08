using N5Challenge.Infrastructure.Data;
using N5Challenge.Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N5Challenge.Infrastructure.Repositories
{
    public class BaseRepository : IBaseRepository
    {
        private readonly N5ChallengeContext context;
        public BaseRepository(N5ChallengeContext context)
        {
            this.context = context;
        }
        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }
        public async Task AddAsync(object entity)
        {
            await context.AddAsync(entity);
        }
    }
}
