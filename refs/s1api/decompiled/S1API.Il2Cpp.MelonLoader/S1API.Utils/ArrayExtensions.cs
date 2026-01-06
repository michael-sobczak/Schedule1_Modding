using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using S1API.Internal.Utils;

namespace S1API.Utils;

public static class ArrayExtensions
{
	public static T[] AddItemToArray<T>(this T[]? array, T item)
	{
		return global::S1API.Internal.Utils.ArrayExtensions.AddItemToArray(array, item);
	}

	public static Il2CppReferenceArray<T> AddItemToArray<T>(this Il2CppReferenceArray<T>? array, params T[]? itemsToAdd) where T : Object
	{
		return global::S1API.Internal.Utils.ArrayExtensions.AddItemToArray(array, itemsToAdd);
	}
}
