using AirportInspection.Models;
using SQLite;

namespace AirportInspection.Services;

public class InspectionDatabase
{
    private readonly SQLiteAsyncConnection _database;

    public InspectionDatabase(string dbPath)
    {
        _database = new SQLiteAsyncConnection(dbPath);
        _database.CreateTableAsync<Inspection>().Wait();
    }

    public Task<List<Inspection>> GetInspectionsAsync() =>
        _database.Table<Inspection>().OrderByDescending(i => i.Timestamp).ToListAsync();

    public Task<int> SaveInspectionAsync(Inspection inspection) =>
        _database.InsertAsync(inspection);

    public Task<int> DeleteInspectionAsync(Inspection inspection) =>
        _database.DeleteAsync(inspection);
}
