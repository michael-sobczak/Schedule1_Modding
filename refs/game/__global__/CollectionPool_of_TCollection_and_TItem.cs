public class CollectionPool<TCollection, TItem> // TypeDefIndex: 12134
{
	// Fields
	internal static readonly ObjectPool<TCollection> s_Pool; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static TCollection Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1448140 Offset: 0x1446B40 VA: 0x181448140
	|-CollectionPool<object, KeyValuePair<object, float>>.Get
	|-CollectionPool<object, ValueTuple<int, int>>.Get
	|-CollectionPool<object, Color32>.Get
	|-CollectionPool<object, int>.Get
	|-CollectionPool<object, object>.Get
	|-CollectionPool<object, UIVertex>.Get
	|-CollectionPool<object, Vector3>.Get
	|-CollectionPool<object, Vector4>.Get
	|-CollectionPool<object, __Il2CppFullySharedGenericType>.Get
	|-CollectionPool<object, HID.HIDElementDescriptor>.Get
	|-CollectionPool<object, MultiColumnCollectionHeader.SortedColumnState>.Get
	*/

	// RVA: -1 Offset: -1
	public static PooledObject<TCollection> Get(out TCollection value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1448040 Offset: 0x1446A40 VA: 0x181448040
	|-CollectionPool<object, KeyValuePair<object, float>>.Get
	|-CollectionPool<object, ValueTuple<int, int>>.Get
	|-CollectionPool<object, Color32>.Get
	|-CollectionPool<object, int>.Get
	|-CollectionPool<object, object>.Get
	|-CollectionPool<object, UIVertex>.Get
	|-CollectionPool<object, Vector3>.Get
	|-CollectionPool<object, Vector4>.Get
	|-CollectionPool<object, __Il2CppFullySharedGenericType>.Get
	|-CollectionPool<object, HID.HIDElementDescriptor>.Get
	|-CollectionPool<object, MultiColumnCollectionHeader.SortedColumnState>.Get
	*/

	// RVA: -1 Offset: -1
	public static void Release(TCollection toRelease) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1448210 Offset: 0x1446C10 VA: 0x181448210
	|-CollectionPool<object, KeyValuePair<object, float>>.Release
	|-CollectionPool<object, ValueTuple<int, int>>.Release
	|-CollectionPool<object, Color32>.Release
	|-CollectionPool<object, int>.Release
	|-CollectionPool<object, object>.Release
	|-CollectionPool<object, UIVertex>.Release
	|-CollectionPool<object, Vector3>.Release
	|-CollectionPool<object, Vector4>.Release
	|-CollectionPool<object, __Il2CppFullySharedGenericType>.Release
	|-CollectionPool<object, HID.HIDElementDescriptor>.Release
	|-CollectionPool<object, MultiColumnCollectionHeader.SortedColumnState>.Release
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14482F0 Offset: 0x1446CF0 VA: 0x1814482F0
	|-CollectionPool<object, KeyValuePair<object, float>>..cctor
	|-CollectionPool<object, ValueTuple<int, int>>..cctor
	|-CollectionPool<object, Color32>..cctor
	|-CollectionPool<object, int>..cctor
	|-CollectionPool<object, object>..cctor
	|-CollectionPool<object, UIVertex>..cctor
	|-CollectionPool<object, Vector3>..cctor
	|-CollectionPool<object, Vector4>..cctor
	|-CollectionPool<object, __Il2CppFullySharedGenericType>..cctor
	|-CollectionPool<object, HID.HIDElementDescriptor>..cctor
	|-CollectionPool<object, MultiColumnCollectionHeader.SortedColumnState>..cctor
	*/
}
