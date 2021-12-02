using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridge.Repository.Connection
{
    public class ConnectionFactory : IConnectionFactory
    {
        private readonly IConfiguration _config;
        public ConnectionFactory(IConfiguration config)
        {
            _config = config;
        }
        public string GetConnectionString()
        {
            return _config.GetConnectionString("DefaultConnection");
        }
    }
}
