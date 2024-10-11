using System.ComponentModel.DataAnnotations.Schema;
using FluentDashboard.Domain.Identity;

namespace FluentDashboard.Domain.Common
{
    public abstract class OwnerPropertyEntity : BaseAuditableEntity
    {
        [ForeignKey("CreatedBy")] public virtual ApplicationUser? Owner { get; set; }

        [ForeignKey("LastModifiedBy")] public virtual ApplicationUser? LastModifier { get; set; }
    }
}
