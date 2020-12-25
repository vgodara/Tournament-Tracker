using LanguageExt;
using model;
using System;
using System.Collections.Generic;
using System.Text;

namespace usecase.response
{
    class ListResponse<T> : BaseResponse<Lst<T>> where T : BaseModel
    {
        public ListResponse(int respCode, string respMessage, Lst<T> model) : base(respCode, respMessage, model)
        {
        }

        public ListResponse(int respCode, string respMessage, Exception exception) : base(respCode, respMessage, exception)
        {
        }
    }
}
