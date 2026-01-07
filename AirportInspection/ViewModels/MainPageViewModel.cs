using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using AirportInspection.Models;

namespace AirportInspection.ViewModels;

public partial class MainPageViewModel : ObservableObject
{
    [ObservableProperty]
    ObservableCollection<Inspection> inspections;

    public MainPageViewModel()
    {
        Inspections = new ObservableCollection<Inspection>();

        // Sample data for testing
        Inspections.Add(new Inspection
        {
            Id = Guid.NewGuid(),
            AssetName = "Fire Extinguisher A1",
            AssetType = "Fire Safety",
            Status = "Good",
            Notes = "Checked and functional",
            Timestamp = DateTime.Now,
            IsSynced = false
        });
    }
}
