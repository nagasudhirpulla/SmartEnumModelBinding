using Ardalis.SmartEnum;

namespace SmartEnumBinding.Enums
{
    public sealed class GenderEnum : SmartEnum<GenderEnum>
    {
        public static readonly GenderEnum Male = new(nameof(Male), 1);
        public static readonly GenderEnum Female = new(nameof(Female), 2);

        private GenderEnum(string name, int value) : base(name, value)
        {
        }
    }
}
