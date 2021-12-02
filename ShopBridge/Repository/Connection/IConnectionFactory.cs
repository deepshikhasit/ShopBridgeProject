using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridge.Repository.Connection
{
    public interface IConnectionFactory
    {
        string GetConnectionString();
    }
}
