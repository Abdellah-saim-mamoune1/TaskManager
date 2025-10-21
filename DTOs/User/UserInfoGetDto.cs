using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManager.DTOs.User
{
    public class UserInfoGetDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Account { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
    }
}
