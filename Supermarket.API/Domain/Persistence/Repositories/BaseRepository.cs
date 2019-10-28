using Supermarket.API.Domain.Persistence.Contexts;

namespace Supermarket.API.Domain.Persistence.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly AppDbContext context;
        
        public BaseRepository(AppDbContext context) 
        {
            this.context = context;
        }
    }
}