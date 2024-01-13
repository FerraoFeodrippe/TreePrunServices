namespace TreePrunServices.Cross.Definitions.Enums
{
    public sealed class ResponseStatusEnum : BaseEnum<ResponseStatusEnum>
    {
        public static readonly ResponseStatusEnum Ok = new(1, "OK");
        public static readonly ResponseStatusEnum Error = new(2, "ERROR");

        private ResponseStatusEnum(int value, string description) : base(value, description) { }

        public bool IsOk => Equals(Ok);
    }
}
