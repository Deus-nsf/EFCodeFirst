using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EFCodeFirst.Reminder.Entities;
using EFCodeFirst.Reminder.Infrastructure;

using Microsoft.EntityFrameworkCore;

namespace EFCodeFirst.Reminder.RepositoryBusinessController;


internal class MarySue
{
	private readonly ApplicationDbContext _dbContext = new();


	public async Task AddClientAsync(Client client)
	{
		await _dbContext.Clients.AddAsync(client);
		await _dbContext.SaveChangesAsync();
	}


	public async Task UpdateClientAsync(int id, Client client)
	{
		await _dbContext.Clients.Where(c => c.Id == id).ExecuteUpdateAsync
		(
			updates => updates.SetProperty(c => c.FirstName, client.FirstName)
		);

		//await _dbContext.AddRangeAsync(client);
	}


	public async Task UpdateMessageAsync(int id, Message message)
	{
		await _dbContext.Messages.Where(m => m.Id == id).ExecuteUpdateAsync
		(
			updates => updates.SetProperty(m => m.Body, message.Body)
		);
	}


	public async Task<Client> GetClientAsync(int id)
	{
		Client client = await _dbContext.Clients.Include(c => c.Messages).FirstOrDefaultAsync(c => c.Id == id) ?? new Client();

		return client;
	}
}
