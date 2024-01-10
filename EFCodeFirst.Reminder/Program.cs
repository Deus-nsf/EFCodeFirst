using EFCodeFirst.Reminder.Entities;
using EFCodeFirst.Reminder.RepositoryBusinessController;

Console.WriteLine("Hello, World!");



MarySue marySue = new MarySue();


//Client client = new Client()
//{
//	Messages = [
//		new Message() { Body = "Pouet message numero 1" },
//		new Message() { Body = "Pouet message MODIFIE 2" },
//		new Message() { Body = "Pouet message numero 3" }
//	],

//	FirstName = "Super POUET",


//};

//Message message = new Message();
//message.Body = "Pouet message MODIFIE 2";

//await marySue.AddClient(client);
//await marySue.UpdateMessage(3, message);



Client client = await marySue.GetClientAsync(3);

Console.WriteLine(client);

Console.ReadKey();