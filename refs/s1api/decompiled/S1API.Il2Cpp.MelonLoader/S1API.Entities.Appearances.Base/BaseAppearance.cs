using System.Collections.Generic;
using S1API.Internal.Utils;

namespace S1API.Entities.Appearances.Base;

public class BaseAppearance
{
	internal static List<string> GetConstPaths<T>() where T : BaseAppearance
	{
		return ReflectionUtils.GetConstStringFields(typeof(T));
	}
}
