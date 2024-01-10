using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

using EFCodeFirst.Reminder.Entities;

using Microsoft.EntityFrameworkCore;

namespace EFCodeFirst.Reminder.Infrastructure;


internal class ApplicationDbContext : DbContext
{
	// Entities description
	public DbSet<Client> Clients { get; set; }
	public DbSet<Message> Messages { get; set; }
	public DbSet<Order> Orders { get; set; }
	public DbSet<Role> Roles { get; set; }

	// DB description
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLOCALDB;Initial Catalog=EFCodeFirst.Reminder;Integrated Security=True");
		
		optionsBuilder.LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);

		base.OnConfiguring(optionsBuilder);
	}

	// DB configuration
	// default/initial data
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		Client client = new Client() { Id = 1, FirstName = "Jean-Mi", LastName = "Dupont", Age = 53};
		Message message = new Message() { Id = 1, Title = "My message", Body = "This is a message", ClientId = 1};

		modelBuilder.Entity<Client>().HasData(client);
		modelBuilder.Entity<Message>().HasData(message);

		base.OnModelCreating(modelBuilder);
	}
}
