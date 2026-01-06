using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

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

	public static Il2CppReferenceArray<T> AddItemToArray<T>(this Il2CppReferenceArray<T>? array, params T[]? itemsToAdd) where T : Object
	{
		int num = ((Il2CppArrayBase<T>)(object)array)?.Length ?? 0;
		int num2 = ((itemsToAdd != null) ? itemsToAdd.Length : 0);
		int num3 = num + num2;
		Il2CppReferenceArray<T> val = new Il2CppReferenceArray<T>((long)num3);
		for (int i = 0; i < num; i++)
		{
			((Il2CppArrayBase<T>)(object)val)[i] = ((Il2CppArrayBase<T>)(object)array)[i];
		}
		for (int j = 0; j < num2; j++)
		{
			((Il2CppArrayBase<T>)(object)val)[num + j] = itemsToAdd[j];
		}
		return val;
	}
}
