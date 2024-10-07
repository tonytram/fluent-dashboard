using Domain.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Common.Entities
{
    public abstract class OwnerPropertyEntity : BaseAuditableEntity
    {
        [ForeignKey("CreatedBy")] public virtual ApplicationUser? Owner { get; set; }

        [ForeignKey("LastModifiedBy")] public virtual ApplicationUser? LastModifier { get; set; }
    }
}
