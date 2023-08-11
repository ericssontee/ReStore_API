using API.Entities;
using Microsoft.AspNetCore.Identity;

namespace ReStore_API.Entities
{
    public class User : IdentityUser<int>
    {
        public UserAddress Address { get; set; }
    }
}