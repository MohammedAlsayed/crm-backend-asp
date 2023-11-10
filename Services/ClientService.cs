using CRM.Models;

namespace CRM.Services;

public static class ClientService
{
    static List<Client> Clients { get; }
    static int nextId = -1;
    static ClientService()
    {   
        // Clients = ReadCSV("./DB/Client_Accounts.csv");
    }

    // static List<Client> ReadCSV(string filePath)
    // {
    //     List<Client> clients = new List<Client>();
    //     try
    //     {
    //         using (StreamReader reader = new StreamReader(filePath))
    //         {   
    //             // skip the first line
    //             reader.ReadLine();
    //             while (!reader.EndOfStream)
    //             {
    //                 string line = reader.ReadLine();
    //                 string[] values = line.Split(',');

    //                 int id = int.Parse(values[1].Substring(values[1].Length - 3));
    //                 nextId = id > nextId ? id : nextId;
    //                 string arabicName = values[2];
    //                 string englishName = values[3];
    //                 string website = values[4];
    //                 string phone = values[5];
    //                 string city = values[7];

    //                 Client client = new Client(id, arabicName, englishName, website, phone, city, null);
    //                 clients.Add(client);
    //             }
    //             nextId++;
    //         }
    //     }
    //     catch (Exception ex)
    //     {
    //         Console.WriteLine($"Error reading CSV file: {ex.Message}");
    //     }

    //     return clients;
    // }

    public static int GetNextId() => nextId;

    public static List<Client> GetAll() => Clients;
    
    public static Client? Get(int id) => Clients.FirstOrDefault(p => p.Id == id);

    public static void Add(Client client)
    {
        client.Id = nextId++;
        Clients.Add(client);
        
    }

    public static List<string> SearchEnNames(string name) => Clients.Where(c => c.EnglishName.ToLower().Contains(name.ToLower())).Select(c => c.EnglishName).ToList();
}
