using System.Net;

namespace Backoffice.PersonSignUp.CrossCutting.Exceptions
{
    public sealed class AddressTransactionRequestException : HttpRequestException
    {
        public AddressTransactionRequestException(string message,
                                                  HttpStatusCode responseCode)
            : base(message) { }
    }
}
