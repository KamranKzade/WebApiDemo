using WebApiDemo.Entities;
using Microsoft.EntityFrameworkCore;

namespace WebApiDemo.Data;

public class StudentContext : DbContext
{
	public DbSet<Student> Students { get; set; }

	public StudentContext(DbContextOptions<StudentContext> options)
		: base(options)
	{ }
}