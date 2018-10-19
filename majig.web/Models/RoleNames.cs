using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations.Schema;

namespace majig.web.Models
{
    public class RoleNames
    {
        public const string ROLE_ADMINISTRATOR = "Admin";
        public const string ROLE_VENDOR = "Vendor";
        public const string ROLE_USER = "User";
    }
}