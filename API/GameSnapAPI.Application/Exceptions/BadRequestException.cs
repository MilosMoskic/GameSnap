using System.Net;

namespace GameSnapAPI.Application.Exceptions;

public class BadRequestException : BaseCustomException
{
    public BadRequestException(string errorMessage) : base(errorMessage, HttpStatusCode.BadRequest) { }
}
