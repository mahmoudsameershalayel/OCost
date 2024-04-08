using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCost.API.Infrastructure.ApiResponse
{
    public class APIResponseViewModel
    {
        public APIResponseViewModel(object data, bool isSuccess, string message)
        {
            Data = data;
            IsSuccess = isSuccess;
            Message = message;
        }

        public object Data { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
}
