namespace AdminPanel.Domain.Entities
{
    public class Project: BaseEntity
    {
        public string Name { get; set; }
        public User User { get; set; }
    }
}
