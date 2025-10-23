using TaskManager.DTOs.User;

namespace TaskManager.DTOs
{
    public class taskGetDTO
    {
        public int Id { get; set; }

        public string Description { get; set; } = string.Empty;

        public DateOnly CreatedAt { get; set; }

        public DateOnly ExpiresAt { get; set; }

        public bool Status { get; set; }

        required public UserInfoGetDto UserInfo { get; set; }
    }
}
