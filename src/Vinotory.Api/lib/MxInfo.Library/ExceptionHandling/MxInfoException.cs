using System.Runtime.Serialization;

namespace MxInfo.Library.ExceptionHandling;

[Serializable]
public class MxInfoException : ApplicationException
{
    public MxInfoException() : base() {}
    public MxInfoException(string message) : base(message) {}
    public MxInfoException(string message, Exception innerException) : base(message, innerException) {}
    public MxInfoException(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext) {}
    
    
}