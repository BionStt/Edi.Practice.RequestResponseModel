using System;

namespace Edi.Practice.RequestResponseModel
{
    public class Response
    {
        public bool IsSuccess { get; set; }

        public string Message { get; set; }

        public Exception Exception { get; set; }

        public int ResponseCode { get; set; }

        public dynamic Addition { get; set; }

        public Response(bool isSuccess = false, string message = "")
        {
            IsSuccess = isSuccess;
            Message = message;
        }
    }

    public class Response<T> : Response
    {
        public T Item { get; set; }

        public Response(T item = default(T))
        {
            Item = item;
        }
    }
}
