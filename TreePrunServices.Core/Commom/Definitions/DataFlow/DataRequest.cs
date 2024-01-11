namespace TreePrunServices.Core.Commom.Definitions.DataFlow
{
    public class DataRequest<T> where T : new()
    {
        public T Data { get; private set; }

        private DataRequest(T data)
        {
            Data = data;  
        }

        public static DataRequest<T> Create(T data)
        {
            return new DataRequest<T>(data);
        }
    }
}
