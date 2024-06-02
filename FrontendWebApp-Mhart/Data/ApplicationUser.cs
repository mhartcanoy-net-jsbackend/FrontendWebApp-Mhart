using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace FrontendWebApp_Mhart.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;   
    public string? Biography { get; set; }
    public string? ProfileImage { get; set; } = "avatar.jpg";
    public int? AddressId { get; set; }
    public AddressEntity? Address { get; set; }
}

public class AddressEntity
{
    [Key]
    public int Id { get; set; }
    public string AddressLine_1 { get; set; } = null!;
    public string? AddressLine_2 { get; set;} = null!;
    public string PostaCode { get; set; } = null!;
    public string City { get; set; } = null!;
}