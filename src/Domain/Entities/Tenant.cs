namespace FluentDashboard.Domain.Entities
{
    public class Tenant : BaseAuditableEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
