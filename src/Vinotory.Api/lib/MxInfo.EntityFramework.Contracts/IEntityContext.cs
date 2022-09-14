using Microsoft.EntityFrameworkCore;

namespace MxInfo.EntityFramework.Contracts;

public interface IEntityContext
{
    DbContext Context { get; }
}