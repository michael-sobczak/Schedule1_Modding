using System.Collections.Generic;
using S1API.Internal.Utils;

namespace S1API.Entities.Appearances.Base;

public class BaseBodyAppearance
{
	internal static List<string> GetConstPaths<T>() where T : BaseBodyAppearance
	{
		return ReflectionUtils.GetConstStringFields(typeof(T));
	}
}
