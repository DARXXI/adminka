namespace AdminPanel.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int? Age { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        //public Role Role { get; set; }
        public int RoleId { get; set; }
        public string? Note { get; set; }
        public string? DateCreated { get; set; }
        public string? DateUpdated { get; set; }
        //public List<Project>? Projects { get; set; }

    }
}
