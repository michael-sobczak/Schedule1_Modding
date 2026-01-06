internal sealed class NoAllocHelpers // TypeDefIndex: 11835
{
	// Methods

	// RVA: -1 Offset: -1
	public static void ResizeList<T>(List<T> list, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF17B90 Offset: 0xF16590 VA: 0x180F17B90
	|-NoAllocHelpers.ResizeList<object>
	|-NoAllocHelpers.ResizeList<Vector4>
	|
	|-RVA: 0xF17A80 Offset: 0xF16480 VA: 0x180F17A80
	|-NoAllocHelpers.ResizeList<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void EnsureListElemCount<T>(List<T> list, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF177D0 Offset: 0xF161D0 VA: 0x180F177D0
	|-NoAllocHelpers.EnsureListElemCount<object>
	|
	|-RVA: 0xF178F0 Offset: 0xF162F0 VA: 0x180F178F0
	|-NoAllocHelpers.EnsureListElemCount<Vector4>
	|
	|-RVA: 0xF17740 Offset: 0xF16140 VA: 0x180F17740
	|-NoAllocHelpers.EnsureListElemCount<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2CC01D0 Offset: 0x2CBEBD0 VA: 0x182CC01D0
	public static int SafeLength(Array values) { }

	// RVA: -1 Offset: -1
	public static int SafeLength<T>(List<T> values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF17C90 Offset: 0xF16690 VA: 0x180F17C90
	|-NoAllocHelpers.SafeLength<Color>
	|-NoAllocHelpers.SafeLength<Color32>
	|-NoAllocHelpers.SafeLength<int>
	|-NoAllocHelpers.SafeLength<Vector2>
	|-NoAllocHelpers.SafeLength<Vector3>
	|-NoAllocHelpers.SafeLength<Vector4>
	|
	|-RVA: 0xF17CC0 Offset: 0xF166C0 VA: 0x180F17CC0
	|-NoAllocHelpers.SafeLength<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T[] ExtractArrayFromListT<T>(List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF17A00 Offset: 0xF16400 VA: 0x180F17A00
	|-NoAllocHelpers.ExtractArrayFromListT<object>
	|-NoAllocHelpers.ExtractArrayFromListT<__Il2CppFullySharedGenericType>
	*/

	[FreeFunction("NoAllocHelpers_Bindings::Internal_ResizeList")]
	// RVA: 0x2CC0190 Offset: 0x2CBEB90 VA: 0x182CC0190
	internal static void Internal_ResizeList(object list, int size) { }

	[FreeFunction("NoAllocHelpers_Bindings::ExtractArrayFromList")]
	// RVA: 0x2CC0150 Offset: 0x2CBEB50 VA: 0x182CC0150
	public static Array ExtractArrayFromList(object list) { }
}
