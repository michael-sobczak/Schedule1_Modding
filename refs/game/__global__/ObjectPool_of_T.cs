public class ObjectPool<T> // TypeDefIndex: 13589
{
	// Fields
	private readonly Stack<T> m_Stack; // 0x0
	private readonly UnityAction<T> m_ActionOnGet; // 0x0
	private readonly UnityAction<T> m_ActionOnRelease; // 0x0
	private readonly bool m_CollectionCheck; // 0x0
	[CompilerGenerated]
	private int <countAll>k__BackingField; // 0x0

	// Properties
	public int countAll { get; set; }
	public int countActive { get; }
	public int countInactive { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public int get_countAll() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x65E590 Offset: 0x65CF90 VA: 0x18065E590
	|-ObjectPool<object>.get_countAll
	|-ObjectPool<__Il2CppFullySharedGenericType>.get_countAll
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_countAll(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x65E020 Offset: 0x65CA20 VA: 0x18065E020
	|-ObjectPool<object>.set_countAll
	|-ObjectPool<__Il2CppFullySharedGenericType>.set_countAll
	*/

	// RVA: -1 Offset: -1
	public int get_countActive() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EB250 Offset: 0x10E9C50 VA: 0x1810EB250
	|-ObjectPool<object>.get_countActive
	|
	|-RVA: 0x10EB1F0 Offset: 0x10E9BF0 VA: 0x1810EB1F0
	|-ObjectPool<__Il2CppFullySharedGenericType>.get_countActive
	*/

	// RVA: -1 Offset: -1
	public int get_countInactive() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC4AA50 Offset: 0xC49450 VA: 0x180C4AA50
	|-ObjectPool<object>.get_countInactive
	|
	|-RVA: 0x10EB270 Offset: 0x10E9C70 VA: 0x1810EB270
	|-ObjectPool<__Il2CppFullySharedGenericType>.get_countInactive
	*/

	// RVA: -1 Offset: -1
	public void .ctor(UnityAction<T> actionOnGet, UnityAction<T> actionOnRelease, bool collectionCheck = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EAD40 Offset: 0x10E9740 VA: 0x1810EAD40
	|-ObjectPool<object>..ctor
	|
	|-RVA: 0x10EB120 Offset: 0x10E9B20 VA: 0x1810EB120
	|-ObjectPool<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public T Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E9FB0 Offset: 0x10E89B0 VA: 0x1810E9FB0
	|-ObjectPool<object>.Get
	|
	|-RVA: 0x10EA030 Offset: 0x10E8A30 VA: 0x1810EA030
	|-ObjectPool<__Il2CppFullySharedGenericType>.Get
	*/

	// RVA: -1 Offset: -1
	public ObjectPool.PooledObject<T> Get(out T v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E9D00 Offset: 0x10E8700 VA: 0x1810E9D00
	|-ObjectPool<object>.Get
	|
	|-RVA: 0x10E9950 Offset: 0x10E8350 VA: 0x1810E9950
	|-ObjectPool<__Il2CppFullySharedGenericType>.Get
	*/

	// RVA: -1 Offset: -1
	public void Release(T element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EA860 Offset: 0x10E9260 VA: 0x1810EA860
	|-ObjectPool<object>.Release
	|
	|-RVA: 0x10EA230 Offset: 0x10E8C30 VA: 0x1810EA230
	|-ObjectPool<__Il2CppFullySharedGenericType>.Release
	*/
}
