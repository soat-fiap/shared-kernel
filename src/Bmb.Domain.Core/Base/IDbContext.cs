using System.Data;

namespace Bmb.Domain.Core.Base;

public interface IDbContext
{
    IDbConnection CreateConnection();
}
