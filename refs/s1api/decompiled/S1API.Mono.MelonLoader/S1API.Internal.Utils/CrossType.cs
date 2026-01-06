using System;

namespace S1API.Internal.Utils;

internal static class CrossType
{
	internal static Type Of<T>()
	{
		return typeof(T);
	}

	internal static bool Is<T>(object obj, out T result) where T : class
	{
		if (obj is T val)
		{
			result = val;
			return true;
		}
		result = null;
		return false;
	}

	internal static T As<T>(object obj) where T : class
	{
		return (T)obj;
	}
}
