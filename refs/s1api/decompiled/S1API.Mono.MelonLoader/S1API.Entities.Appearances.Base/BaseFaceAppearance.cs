using System.Collections.Generic;
using S1API.Internal.Utils;

namespace S1API.Entities.Appearances.Base;

public class BaseFaceAppearance
{
	internal static List<string> GetConstPaths<T>() where T : BaseFaceAppearance
	{
		return ReflectionUtils.GetConstStringFields(typeof(T));
	}
}
