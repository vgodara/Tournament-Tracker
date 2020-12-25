using System;
using System.Threading;
using System.Threading.Tasks;
using usecase.response;

namespace usecase.baseUseCase
{
    abstract class BaseUseCase<Model, Request>
    {
        private readonly CancellationToken cancellationToken;
        public BaseUseCase(CancellationToken cancellationToken)
        {
            this.cancellationToken = cancellationToken;
        }
        protected abstract Model BuildUseCase(Request request);

        public async Task<BaseResponse<Model>> GetAsync(Request request)
        {
            try
            {
                BaseResponse<Model> response = await Task.Run<BaseResponse<Model>>(() =>
                {
                    cancellationToken.ThrowIfCancellationRequested();
                    Model model = BuildUseCase(request);
                    if (model == null)
                    {
                        throw new ArgumentNullException(nameof(Model));
                    }
                    else
                        return new BaseResponse<Model>(200, $"operation was successful", model);
                }, cancellationToken);
                cancellationToken.ThrowIfCancellationRequested();
                return response;
            }
            catch (Exception exception)
            {
                return new BaseResponse<Model>(exception.InnerException.HResult, exception.Message, exception);
            }



        }
    }
}
