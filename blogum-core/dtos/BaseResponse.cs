using System;
using System.Collections.Generic;

namespace blogum_core.dtos
{
    public class BaseResponse
    {
        public BaseResponse(
            bool isSuccess = false,
            dynamic result = null,
            string error = ""
            )
        {
            this.IsSuccess = isSuccess;

            if(result != null)
            {
                this.Result = result;
            }

            this.Error = error;
        }

        public bool IsSuccess { get; set; }

        public string? Error { get; set; }

        public dynamic Result { get; set; }
    }
}
