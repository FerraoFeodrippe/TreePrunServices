using TreePrunServices.Core.Commom.Enums;

namespace TreePrunServices.Core.Commom.Definitions.DataFlow
{
    public class DataResponse<T> where T: new()
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

        public void AddError(string topic, string message)
        {
            Error.AddMessage(topic, message);
        }
    }
}
