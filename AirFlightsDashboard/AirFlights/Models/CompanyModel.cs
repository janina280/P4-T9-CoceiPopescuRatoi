using System.ComponentModel.DataAnnotations;

namespace AirFlightsDashboard.Models;

public class CompanyModel
{
    [Required]
    public string Name { get; set; }
    //public string Route { get; set; }
}