using model;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace usecase.common
{
    abstract class BaseUseCase<Model, Request>
    {
        private readonly CancellationToken cancellationToken;
        public BaseUseCase(CancellationToken cancellationToken)
        {
            this.cancellationToken = cancellationToken;
        }
        protected abstract Model BuildUseCase(Request request);

        public async Task<Response<Model>> GetAsync(Request request)
        {
            try
            {
                Response<Model> response = await Task.Run<Response<Model>>(() =>
                {
                    cancellationToken.ThrowIfCancellationRequested();
                    Model model = BuildUseCase(request);
                    if (model == null)
                    {
                        throw new ArgumentNullException(nameof(Model));
                    }
                    else
                        return new Response<Model>(200, $"operation was successful", model);
                }, cancellationToken);
                cancellationToken.ThrowIfCancellationRequested();
                return response;
            }
            catch (Exception exception)
            {
                return new Response<Model>(exception.InnerException.HResult, exception.Message, exception);
            }



        }
    }
}
