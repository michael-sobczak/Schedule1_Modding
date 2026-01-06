internal class TMP_ObjectPool<T> // TypeDefIndex: 14948
{
	// Fields
	private readonly Stack<T> m_Stack; // 0x0
	private readonly UnityAction<T> m_ActionOnGet; // 0x0
	private readonly UnityAction<T> m_ActionOnRelease; // 0x0
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
	|-RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	|-TMP_ObjectPool<object>.get_countAll
	|-TMP_ObjectPool<__Il2CppFullySharedGenericType>.get_countAll
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_countAll(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x494480 Offset: 0x492E80 VA: 0x180494480
	|-TMP_ObjectPool<object>.set_countAll
	|-TMP_ObjectPool<__Il2CppFullySharedGenericType>.set_countAll
	*/

	// RVA: -1 Offset: -1
	public int get_countActive() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x120A540 Offset: 0x1208F40 VA: 0x18120A540
	|-TMP_ObjectPool<object>.get_countActive
	|
	|-RVA: 0x10EB1F0 Offset: 0x10E9BF0 VA: 0x1810EB1F0
	|-TMP_ObjectPool<__Il2CppFullySharedGenericType>.get_countActive
	*/

	// RVA: -1 Offset: -1
	public int get_countInactive() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC4AA50 Offset: 0xC49450 VA: 0x180C4AA50
	|-TMP_ObjectPool<object>.get_countInactive
	|
	|-RVA: 0x10EB270 Offset: 0x10E9C70 VA: 0x1810EB270
	|-TMP_ObjectPool<__Il2CppFullySharedGenericType>.get_countInactive
	*/

	// RVA: -1 Offset: -1
	public void .ctor(UnityAction<T> actionOnGet, UnityAction<T> actionOnRelease) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x120A480 Offset: 0x1208E80 VA: 0x18120A480
	|-TMP_ObjectPool<object>..ctor
	|
	|-RVA: 0x120A3C0 Offset: 0x1208DC0 VA: 0x18120A3C0
	|-TMP_ObjectPool<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public T Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1209FC0 Offset: 0x12089C0 VA: 0x181209FC0
	|-TMP_ObjectPool<object>.Get
	|
	|-RVA: 0x10EA030 Offset: 0x10E8A30 VA: 0x1810EA030
	|-TMP_ObjectPool<__Il2CppFullySharedGenericType>.Get
	*/

	// RVA: -1 Offset: -1
	public void Release(T element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x120A040 Offset: 0x1208A40 VA: 0x18120A040
	|-TMP_ObjectPool<object>.Release
	|
	|-RVA: 0x120A130 Offset: 0x1208B30 VA: 0x18120A130
	|-TMP_ObjectPool<__Il2CppFullySharedGenericType>.Release
	*/
}
