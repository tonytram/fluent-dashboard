namespace FluentDashboard.Domain.Common;

public abstract class BaseAuditableEntity : BaseEntity
{
    public virtual DateTimeOffset? Created { get; set; }

    public virtual string? CreatedBy { get; set; }

    public virtual DateTimeOffset? LastModified { get; set; }

    public virtual string? LastModifiedBy { get; set; }
}
