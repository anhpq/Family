using Arigatou.DTO.Models.Base;
using Repository.Pattern.Infrastructure;

namespace Arigatou.DTO.Models
{
    public class User: Entity
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
