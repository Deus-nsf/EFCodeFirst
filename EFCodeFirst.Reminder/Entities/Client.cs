using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst.Reminder.Entities;


internal class Client
{
	// EF handles Required, Auto Increment, and Primary Key automatically for the property named "Id" with the DBMS
	public int Id { get; set; }

	[Required]
	[StringLength(100)]
	public string FirstName { get; set; } = string.Empty;

	[StringLength(100)]
	public string? LastName { get; set; }

	public int? Age { get; set; }

	// ----------- Foreign Keys ------------

	// relation 0, n
	public List<Message> Messages { get; set; } = new();

	// relation 0, n
	public List<Order> Orders { get; set; } = new();

	// relation 1/0, n	(Auto Required because *, n on the other side, EF only auto generates 1, n | 1, n for join tables)
	public List<Role> Roles { get; set; } = new();


	public override string ToString()
	{
		string myString = $"{Id} {FirstName} {LastName}";

		Messages.ForEach(m => myString += "\n" + m.ToString());

		return myString;
	}
}
