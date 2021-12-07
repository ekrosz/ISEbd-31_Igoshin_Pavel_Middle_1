using System.ComponentModel;

namespace IES.FixedAssets.Common.Enums
{
	public enum OperationType
	{
		[Description("Поступление")]
		Receipt,

		[Description("Ввод в эксплуатацию")]
		Commissioning
	}
}
