using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridge.Model
{
    public class WebApiResponse<T>
    {
        public string Message { get; set; } = "Error";
        public bool Status { get; set; } = false;
        public T Data { get; set; } 
    }
}
