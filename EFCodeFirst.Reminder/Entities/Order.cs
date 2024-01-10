using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst.Reminder.Entities;


internal class Order
{
	public int Id { get; set; }

	public int Price { get; set; }

	// ----------- Foreign Keys ------------

	// relation 1, 1
	public int ClientId { get; set; }
	public Client? Client { get; set; }
}
