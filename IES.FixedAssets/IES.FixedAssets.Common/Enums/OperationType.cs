using System.ComponentModel;
using System.Runtime.Serialization;

namespace IES.FixedAssets.Common.Enums
{
	public enum OperationType
	{
		[Description("Выбытие")]
		Disposal,

		[Description("Поступление")]
		Receipt
	}
}
