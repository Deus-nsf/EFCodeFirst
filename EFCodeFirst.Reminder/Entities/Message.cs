using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst.Reminder.Entities;


internal class Message
{
	public int Id { get; set; }

	[StringLength(50)]
	public string? Title { get; set; }

	[StringLength(5000)]
	public string? Body { get; set; }

	// ----------- Foreign Keys ------------

	// relation 1, 1
	public int ClientId { get; set; }
	public Client? Client { get; set; }


	public override string ToString()
	{
		return Body ?? string.Empty;
	}
}
