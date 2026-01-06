using System;

namespace S1API.Internal.Utils;

[Obsolete("This class is for internal API use only. Mod developers should use S1API.Utils.ArrayExtensions instead. This class will be made internal in a future version.")]
public static class ArrayExtensions
{
	public static T[] AddItemToArray<T>(this T[]? array, T item)
	{
		if (array == null)
		{
			array = Array.Empty<T>();
		}
		Array.Resize(ref array, array.Length + 1);
		array[^1] = item;
		return array;
	}
}
