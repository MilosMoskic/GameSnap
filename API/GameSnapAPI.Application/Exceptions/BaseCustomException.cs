using System.Net;

namespace GameSnapAPI.Application.Exceptions;

public class BaseCustomException : Exception
{
    public HttpStatusCode StatusCode { get; }

    public BaseCustomException(string message, HttpStatusCode statusCode) : base(message)
    {
        StatusCode = statusCode;
    }
}
