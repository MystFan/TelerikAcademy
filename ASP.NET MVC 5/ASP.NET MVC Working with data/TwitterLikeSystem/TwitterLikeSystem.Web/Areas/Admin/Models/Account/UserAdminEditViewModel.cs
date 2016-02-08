namespace TwitterLikeSystem.Web.Areas.Admin.Models.Account
{
    using TwitterLikeSystem.Models;
    using TwitterLikeSystem.Web.Mappings;

    public class UserAdminEditViewModel : IMapFrom<User>
    {
        public string Id { get; set; }

        public string Email { get; set; }

        public bool EmailConfirmed { get; set; }

        public string PhoneNumber { get; set; }

        public bool PhoneNumberConfirmed { get; set; }

        public string UserName { get; set; }
    }
}