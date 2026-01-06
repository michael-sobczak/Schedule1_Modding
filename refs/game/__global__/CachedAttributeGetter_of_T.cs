internal static class CachedAttributeGetter<T> // TypeDefIndex: 11209
{
	// Fields
	[Nullable(new[] { 1, 1, 2 })]
	private static readonly ThreadSafeStore<object, T> TypeAttributeCache; // 0x0

	// Methods

	[NullableContext(1)]
	// RVA: -1 Offset: -1
	public static T GetAttribute(object type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1434ED0 Offset: 0x14338D0 VA: 0x181434ED0
	|-CachedAttributeGetter<object>.GetAttribute
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1434FB0 Offset: 0x14339B0 VA: 0x181434FB0
	|-CachedAttributeGetter<object>..cctor
	*/
}
