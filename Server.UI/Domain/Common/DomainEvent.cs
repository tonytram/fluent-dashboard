using MediatR;

namespace Domain.Common
{
    public abstract class DomainEvent : INotification
    {
        public bool IsPublished { get; set; }
        public DateTimeOffset DateOccurred { get; protected set; } = DateTimeOffset.UtcNow;
    }
}
