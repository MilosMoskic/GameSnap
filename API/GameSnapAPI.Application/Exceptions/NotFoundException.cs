using System.Net;

namespace GameSnapAPI.Application.Exceptions;

public class NotFoundException : BaseCustomException
{
    public NotFoundException(string errorMessage) : base(errorMessage, HttpStatusCode.NotFound) { }
}
