using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace IES.FixedAssets.Common.Helpers.Tools
{
	public static class EnumTools
	{
        public static string GetDescription(this Enum value)
        {
            var description = $"{value}";
            FieldInfo fieldInfo = value.GetType().GetField(description);
            var attributes =
                (DescriptionAttribute[])fieldInfo.GetCustomAttributes(
                    typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Any())
                description = attributes[0].Description;

            return description;
        }
    }
}
