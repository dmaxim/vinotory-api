using System.Runtime.Serialization;

namespace MxInfo.Library.ExceptionHandling;

[Serializable]
public class MxInfoMultipleFoundException : ApplicationException
{
    public MxInfoMultipleFoundException() : base() {}
    public MxInfoMultipleFoundException(string message) : base(message) {}
    public MxInfoMultipleFoundException(string message, Exception innerException) : base(message, innerException) {}
    public MxInfoMultipleFoundException(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext) {}
    
}