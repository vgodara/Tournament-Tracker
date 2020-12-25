using model;
using System;
using System.Collections.Generic;
using System.Text;

namespace usecase.response
{
    class Response<T> : BaseResponse<T> where T : BaseModel
    {
        public Response(int respCode, string respMessage, T model) : base(respCode, respMessage, model)
        {
        }

        public Response(int respCode, string respMessage, Exception exception) : base(respCode, respMessage, exception)
        {
        }
    }
}
