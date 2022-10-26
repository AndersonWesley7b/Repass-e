using Repass_e.Domain.Entities;
using Repass_e.Infrastructure.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repass_e.Infrastructure.Persistence.Repositories.Tickets
{
    public class TicketRepository : GenericRepository<Ticket, AppDataContext>
    {
        public TicketRepository(AppDataContext context):base(context)
        {

        }
    }
}
