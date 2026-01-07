using SQLite;

namespace AirportInspection.Models;

public class Inspection
{
    [PrimaryKey]
    public Guid Id { get; set; }

    public string AssetName { get; set; }
    public string AssetType { get; set; }
    public string Status { get; set; }
    public string Notes { get; set; }
    public DateTime Timestamp { get; set; }
    public bool IsSynced { get; set; }
}
