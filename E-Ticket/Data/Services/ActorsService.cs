using E_Ticket.Data.Base;
using E_Ticket.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Ticket.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        private readonly AppDbContext _context;
        public ActorsService(AppDbContext context):base (context) { }
        
        
    }
}
