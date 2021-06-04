using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Core.Results
{
    public class DataResult<T>
    {
        
        public bool Success { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
    }
}
