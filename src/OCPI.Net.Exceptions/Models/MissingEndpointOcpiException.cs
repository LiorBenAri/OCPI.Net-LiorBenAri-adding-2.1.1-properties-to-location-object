﻿namespace OCPI.Exceptions;

public class MissingEndpointOcpiException : OcpiExceptionBase
{
    public const string DefaultMessage = "No matching endpoints or expected endpoints missing between parties.";

    public MissingEndpointOcpiException(string message = DefaultMessage, Exception? innerException = null)
        : base(message, OcpiStatusCode.MissingEndpoint, innerException: innerException) { }
}
