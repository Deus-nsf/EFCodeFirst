using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst.Reminder.Entities;


internal class Role
{
	public int Id { get; set; }

	[StringLength(50)]
	public string? Name { get; set; }

	// ----------- Foreign Keys ------------

	// relation 1/0, n (Auto Required because *, n on the other side, EF only knows 1, n | 1, n for join tables)
	public List<Client> Clients { get; set; } = null!;
}
