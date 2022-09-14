using System.Runtime.Serialization;

namespace MxInfo.Library.ExceptionHandling;

public class MxInfoNotFoundException : MxInfoException
{
    public MxInfoNotFoundException() : base() {}
    public MxInfoNotFoundException(string message) : base(message) {}
    public MxInfoNotFoundException(string message, Exception innerException) : base(message, innerException) {}
    public MxInfoNotFoundException(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext) {}
}