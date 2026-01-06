public abstract class LazySingleton<T> : MonoBehaviour // TypeDefIndex: 14034
{
	// Fields
	private static T sInstance; // 0x0

	// Properties
	public static bool hasInstance { get; }
	public static T instance { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static bool get_hasInstance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D5260 Offset: 0x18D3C60 VA: 0x1818D5260
	|-LazySingleton<object>.get_hasInstance
	*/

	// RVA: -1 Offset: -1
	public static T get_instance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D52F0 Offset: 0x18D3CF0 VA: 0x1818D52F0
	|-LazySingleton<object>.get_instance
	*/

	// RVA: -1 Offset: -1 Slot: 4
	protected virtual void Awake() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D5130 Offset: 0x18D3B30 VA: 0x1818D5130
	|-LazySingleton<object>.Awake
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	|-LazySingleton<object>..ctor
	*/
}
