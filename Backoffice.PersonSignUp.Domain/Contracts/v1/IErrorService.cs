namespace Backoffice.PersonSignUp.Domain.Contracts.v1
{
    public interface IErrorService
    {
        Task SendErrorAsync(AddressTransactionRequest request, string error);
    }
}
