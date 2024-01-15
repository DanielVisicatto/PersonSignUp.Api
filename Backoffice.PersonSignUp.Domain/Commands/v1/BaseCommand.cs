using MediatR;

namespace Backoffice.PersonSignUp.Domain.Commands.v1
{
    public abstract class BaseCommand :IRequest<Unit>
    {
        public Guid CorrelationId { get; set; }
    }
}
