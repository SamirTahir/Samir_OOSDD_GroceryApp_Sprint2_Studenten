using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;

public class ClientRepository : IClientService
{
    private readonly List<Client> _clients = new()
    {
        new Client(1, "User One", "user1@mail.com", "user1"),
        new Client(2, "User Two", "user2@mail.com", "user2"),
        new Client(3, "User Three", "user3@mail.com", "user3")
    };

    public Client? Get(string email)
    {
        return _clients.FirstOrDefault(c => c.EmailAddress == email);
    }

    public Client? Get(int id)
    {
        return _clients.FirstOrDefault(c => c.Id == id);
    }

    public List<Client> GetAll()
    {
        return _clients;
    }
}