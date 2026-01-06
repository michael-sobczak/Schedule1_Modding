using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace S1API.Internal.Utils;

internal static class CrossType
{
	internal static Type Of<T>()
	{
		return Il2CppType.Of<T>();
	}

	internal static bool Is<T>(object obj, out T result) where T : Il2CppObjectBase
	{
		Object val = (Object)((obj is Object) ? obj : null);
		if (val != null)
		{
			Type val2 = Il2CppType.Of<T>();
			if (val2.IsAssignableFrom(val.GetIl2CppType()))
			{
				result = ((Il2CppObjectBase)val).TryCast<T>();
				return true;
			}
		}
		result = default(T);
		return false;
	}

	internal static T As<T>(object obj) where T : Il2CppObjectBase
	{
		Object val = (Object)((obj is Object) ? obj : null);
		return (val != null) ? ((Il2CppObjectBase)val).Cast<T>() : default(T);
	}
}
