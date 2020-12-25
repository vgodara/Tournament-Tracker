using System;
using System.Collections.Generic;
using System.Text;
using LanguageExt;
using static LanguageExt.Prelude;
using model;

namespace usecase.response
{
    class BaseResponse<T>  {

        public readonly int respCode;
        public readonly string respMessage;
        public readonly Either<Exception, T> response;

        public BaseResponse(int respCode,
                         string respMessage,
                         T model)
        {
            this.respCode = respCode;
            this.respMessage = respMessage;
            this.response = Right<Exception, T>(model);

        }

        public BaseResponse(int respCode,
                        string respMessage,
                        Exception exception)
        {
            this.respCode = respCode;
            this.respMessage = respMessage;
            this.response = Left<Exception, T>(exception);
        }
    }
}
