using S1API.Internal.Utils;

namespace S1API.Utils;

public static class ArrayExtensions
{
	public static T[] AddItemToArray<T>(this T[]? array, T item)
	{
		return global::S1API.Internal.Utils.ArrayExtensions.AddItemToArray(array, item);
	}
}
