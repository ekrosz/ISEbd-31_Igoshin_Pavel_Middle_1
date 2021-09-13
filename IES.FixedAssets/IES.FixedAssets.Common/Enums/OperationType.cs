using System.ComponentModel;
using System.Runtime.Serialization;

namespace IES.FixedAssets.Common.Enums
{
	public enum OperationType
	{
		[Description("Первый тип")]
		[EnumMember(Value = "FirstType")]
		FirstType,

		[Description("Второй тип")]
		[EnumMember(Value = "SecondType")]
		SecondType
	}
}
