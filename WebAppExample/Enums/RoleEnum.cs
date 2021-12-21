using Ardalis.SmartEnum;

namespace SmartEnumBinding.Enums
{
    public sealed class RoleEnum : SmartEnum<RoleEnum>
    {
        public static readonly RoleEnum Guest = new(nameof(Guest), 1);
        public static readonly RoleEnum Employee = new(nameof(Employee), 2);
        public static readonly RoleEnum Admin = new(nameof(Admin), 3);

        private RoleEnum(string name, int value) : base(name, value)
        {
        }
    }
}
