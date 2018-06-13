using Microsoft.EntityFrameworkCore;

namespace APBDSinglePage.Models {
    public class AnimalContext : DbContext {
        public AnimalContext (DbContextOptions<AnimalContext> options) : base (options) { }
        public DbSet<APBDSinglePage.Models.AnimalModel> Animal { get; set; }
    }
}