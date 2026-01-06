using System.Collections.Generic;
using S1API.Internal.Utils;

namespace S1API.Entities.Appearances.Base;

public class BaseAccessoryAppearance
{
	internal static List<string> GetConstPaths<T>() where T : BaseAccessoryAppearance
	{
		return ReflectionUtils.GetConstStringFields(typeof(T));
	}
}
