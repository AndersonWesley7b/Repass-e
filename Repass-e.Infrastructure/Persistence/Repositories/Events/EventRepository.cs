using Repass_e.Domain.Entities;
using Repass_e.Infrastructure.DataContext;

namespace Repass_e.Infrastructure.Persistence.Repositories.Events
{
    public class EventRepository : GenericRepository<Event, AppDataContext>
    {
        public EventRepository(AppDataContext context) : base(context)
        {
        }
    }
}
