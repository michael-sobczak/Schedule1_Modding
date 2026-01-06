public class Pool<T> : IPool // TypeDefIndex: 10417
{
	// Fields
	private readonly List<T> mObjects; // 0x0
	[CompilerGenerated]
	private string <Identifier>k__BackingField; // 0x0
	[CompilerGenerated]
	private PoolSettings <Settings>k__BackingField; // 0x0
	private double mLastTime; // 0x0
	private double mDeltaTime; // 0x0

	// Properties
	public string Identifier { get; set; }
	public PoolSettings Settings { get; set; }
	public Type Type { get; }
	public int Count { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 4
	public string get_Identifier() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	|-Pool<__Il2CppFullySharedGenericType>.get_Identifier
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 5
	public void set_Identifier(string value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	|-Pool<__Il2CppFullySharedGenericType>.set_Identifier
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 6
	public PoolSettings get_Settings() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	|-Pool<__Il2CppFullySharedGenericType>.get_Settings
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected void set_Settings(PoolSettings value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	|-Pool<__Il2CppFullySharedGenericType>.set_Settings
	*/

	// RVA: -1 Offset: -1
	public Type get_Type() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FAE40 Offset: 0x10F9840 VA: 0x1810FAE40
	|-Pool<__Il2CppFullySharedGenericType>.get_Type
	*/

	// RVA: -1 Offset: -1
	public void .ctor(PoolSettings settings) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FAB70 Offset: 0x10F9570 VA: 0x1810FAB70
	|-Pool<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void Update() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FA770 Offset: 0x10F9170 VA: 0x1810FA770
	|-Pool<__Il2CppFullySharedGenericType>.Update
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FA440 Offset: 0x10F8E40 VA: 0x1810FA440
	|-Pool<__Il2CppFullySharedGenericType>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F9A20 Offset: 0x10F8420 VA: 0x1810F9A20
	|-Pool<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FAE00 Offset: 0x10F9800 VA: 0x1810FAE00
	|-Pool<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public virtual T Pop(Transform parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F9BC0 Offset: 0x10F85C0 VA: 0x1810F9BC0
	|-Pool<__Il2CppFullySharedGenericType>.Pop
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual void Push(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FA0C0 Offset: 0x10F8AC0 VA: 0x1810FA0C0
	|-Pool<__Il2CppFullySharedGenericType>.Push
	*/

	// RVA: -1 Offset: -1 Slot: 13
	protected virtual void sendBeforePush(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FB0C0 Offset: 0x10F9AC0 VA: 0x1810FB0C0
	|-Pool<__Il2CppFullySharedGenericType>.sendBeforePush
	*/

	// RVA: -1 Offset: -1 Slot: 14
	protected virtual void sendAfterPop(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FAFD0 Offset: 0x10F99D0 VA: 0x1810FAFD0
	|-Pool<__Il2CppFullySharedGenericType>.sendAfterPop
	*/

	// RVA: -1 Offset: -1 Slot: 15
	protected virtual void setParent(T item, Transform parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-Pool<__Il2CppFullySharedGenericType>.setParent
	*/

	// RVA: -1 Offset: -1 Slot: 16
	protected virtual T create() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FAD60 Offset: 0x10F9760 VA: 0x1810FAD60
	|-Pool<__Il2CppFullySharedGenericType>.create
	*/

	// RVA: -1 Offset: -1 Slot: 17
	protected virtual void destroy(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-Pool<__Il2CppFullySharedGenericType>.destroy
	*/

	// RVA: -1 Offset: -1
	private void log(string msg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FAEA0 Offset: 0x10F98A0 VA: 0x1810FAEA0
	|-Pool<__Il2CppFullySharedGenericType>.log
	*/
}
