
using TreePrunServices.Cross.Definitions.Enums;

namespace TreePrunServices.Cross.Definitions.DataFlow
{
    public class DataResponse<T>
    {
        public T? Data { get; private set; }
        public Error Error { get; private set; } = Error.Empty();

        public ResponseStatusEnum StatusEnum => !Error.AnyError ? ResponseStatusEnum.Ok : ResponseStatusEnum.Error;

        private DataResponse()
        {
            Data = default;
        }

        private DataResponse(T data)
        {
            Data = data;
        }

        public static DataResponse<T> Create(T data)
        {
            return new DataResponse<T>(data);
        }

        public static DataResponse<T> Create()
        {
            return new DataResponse<T>();
        }

        public DataResponse<T> AddError(string topic, string message)
        {
            Error.AddMessage($"{topic}##{Guid.NewGuid()}", message);
            return this;
        }

        public DataResponse<T> AddError(string topic, Exception exception)
        {
            Error.AddMessage($"{topic}##{Guid.NewGuid()}", exception.Message);

            if (exception.InnerException != null)
            {
                Error.AddMessage($"{topic}##{exception.InnerException.Source}##{Guid.NewGuid()}", exception.InnerException.Message);
            }

            if (!string.IsNullOrWhiteSpace(exception.StackTrace))
            {
                Error.AddMessage($"{topic}##StackTrace##{Guid.NewGuid()}", exception.StackTrace);
            }

            return this;
        }
    }
}
