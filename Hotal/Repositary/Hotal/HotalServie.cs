using Management.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Management.Repositary.Hotal
{
   
    public class HotalServie
    {
        private readonly HotalDbContext _context;

        public HotalServie(HotalDbContext context)
    {
        _context = context;
    }
      /*  public async Task<ActionResult<IEnumerable<Hotel>>> GetHotels()
        {
          //  return await _context.ToList();
        }*/
    }
}
