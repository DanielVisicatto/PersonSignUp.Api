using Backoffice.PersonSignUp.CrossCutting.Configuration.AppModels.ServiceClientSettings;
using Backoffice.PersonSignUp.CrossCutting.Exceptions;
using Backoffice.PersonSignUp.Domain.Contracts.v1;

namespace Backoffice.PersonSignUp.Domain.Services.v1
{
    public class BaseService
    {
        private readonly IErrorService _errorService;

        public BaseService(IErrorService errorService)
        {
            _errorService = errorService;
        }

        protected async Task SafeExecuteAsync(Func<Task> function,
                                              ServiceClientSettings settings,
                                              bool throwException = true)
        {
            try
            {
                await function();
            }
            catch (AddressTransactionRequestException ex)
            {
                throw ex;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
