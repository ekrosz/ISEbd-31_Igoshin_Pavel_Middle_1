using System.ComponentModel;
using System.Runtime.Serialization;

namespace IES.FixedAssets.Common.Enums
{
	public enum AccountType
	{
		[Description("Активный")]
		[EnumMember(Value = "Active")]
		Active,

		[Description("Пассивный")]
		[EnumMember(Value = "Passive")]
		Passive,

		[Description("Активно-пассивный")]
		[EnumMember(Value = "ActivePassive")]
		ActivePassive
	}
}
