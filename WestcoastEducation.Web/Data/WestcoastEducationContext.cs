using Microsoft.EntityFrameworkCore;
using WestcoastEducation.Web.Models;

namespace WestcoastEducation.Web.Data;

public class WestcoastEducationContext : DbContext
{
    public DbSet<Classroom> Classrooms => Set<Classroom>();
    public WestcoastEducationContext(DbContextOptions options) : base(options) { }
}
