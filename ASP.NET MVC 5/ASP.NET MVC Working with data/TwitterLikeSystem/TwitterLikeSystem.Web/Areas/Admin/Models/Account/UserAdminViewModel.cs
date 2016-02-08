namespace TwitterLikeSystem.Web.Areas.Admin.Models.Account
{
    using System.ComponentModel.DataAnnotations;
    using TwitterLikeSystem.Models;
    using TwitterLikeSystem.Web.Mappings;

    public class UserAdminViewModel : IMapFrom<User>
    {
        public string Id { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public bool EmailConfirmed { get; set; }

        [Required]
        [MinLength(5)]
        public string Password { get; set; }

        public string PhoneNumber { get; set; }

        public bool PhoneNumberConfirmed { get; set; }

        [Required]
        [MinLength(5)]
        public string UserName { get; set; }
    }
}