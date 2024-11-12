using System.ComponentModel.DataAnnotations;
namespace DemoMVCFW.Models
{
    public class User
    {
        [Required(ErrorMessage = "Name is required")]
    public string UserName { get; set; }

    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid Email address")]
    public string UserEmail { get; set; }
}
}
