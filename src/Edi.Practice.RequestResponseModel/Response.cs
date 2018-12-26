using System;
using System.Collections.Generic;
using System.Text;

namespace Edi.Practice.RequestResponseModel
{
    public class Response
    {
        public bool IsSuccess { get; set; }

        public string Message { get; set; }

        public Exception Exception { get; set; }

        public int ResponseCode { get; set; }

        public Response()
        {
            IsSuccess = false;
            Message = string.Empty;
        }
    }

    public class Response<T> : Response
    {
        public T Item { get; set; }
    }

    public class SuccessResponse : Response
    {
        public SuccessResponse()
        {
            IsSuccess = true;
        }
    }

    public class SuccessResponse<T> : Response<T>
    {
        public SuccessResponse()
        {
            IsSuccess = true;
        }

        public SuccessResponse(T item)
        {
            IsSuccess = true;
            Item = item;
        }
    }

    public class FailedResponse : Response
    {
        public FailedResponse(int responseCode)
        {
            ResponseCode = responseCode;
        }
    }

    public class FailedResponse<T> : Response<T>
    {
        public FailedResponse(int responseCode)
        {
            ResponseCode = responseCode;
        }
    }
}
