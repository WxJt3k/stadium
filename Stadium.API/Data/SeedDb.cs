using Stadium.Shared.Entities;
using Stadium.API.Data;

namespace Stadium.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckTicketsAsync();
        }

        private async Task CheckTicketsAsync()
        {
            if (!_context.Tickets.Any())
            {
                for (int i = 0; i < 50000; i++)
                {
                    var ticket = new Ticket
                    {
                        UseDate = new DateTime(2000, 1, 1),
                        FueUsada = false,
                        Porteria = "",
                    };

                    _context.Tickets.Add(ticket);
                }
            }

            await _context.SaveChangesAsync();
        }
    }
}