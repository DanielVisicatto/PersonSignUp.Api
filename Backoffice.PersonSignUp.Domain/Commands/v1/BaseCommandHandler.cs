using MediatR;
using Microsoft.Extensions.Logging;

namespace Backoffice.PersonSignUp.Domain.Commands.v1
{
    public abstract class BaseCommandHandler<THandler> where THandler : class
    {
        public readonly ILogger Logger;

        public BaseCommandHandler(ILogger logger)
        {
            Logger = logger;
        }

        public async Task<Unit> SafeExecuteAsync<TComand>(Func<Task> function, TComand command)
            where TComand : BaseCommand
        {
            try
            {
                await function();

                return Unit.Value;
            }
            catch (Exception ex)
            {
                Logger.LogError(nameof(BaseCommandHandler<THandler>),
                                    command.CorrelationId, ex);
                throw ex;
            }
        }
    }
}
