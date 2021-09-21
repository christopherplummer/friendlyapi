using System;

namespace FriendlyApi.Service.Exceptions
{
    //TODO: Write exception filter at some point.
    public abstract class ApiException : Exception
    {
        public int? StatusCode { get; }

        protected ApiException() { }
        protected ApiException(string message, int? statusCode = null) : base(message)
        {
            StatusCode = statusCode ?? StatusCode;
        }
    }
}