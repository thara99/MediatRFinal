using MeriatRFinal3.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace MeriatRFinal3.Context
{
    public interface IApplicationContext
    {
        DbSet<Product> Products { get; set; }

        Task<int> SaveChangesAsync();
    }
}