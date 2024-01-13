namespace TreePrunServices.Cross.Definitions.DataFlow
{
    public class DataRequest
    {
        public DataRequestValue Value { get; private set; }

        private DataRequest(DataRequestValue value)
        {
            Value = value;  
        }

        public static DataRequest Create(DataRequestValue value)
        {
            return new DataRequest(value);
        }
    }
}
