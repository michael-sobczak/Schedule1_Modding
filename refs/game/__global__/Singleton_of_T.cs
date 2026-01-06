public abstract class Singleton<T> : MonoBehaviour // TypeDefIndex: 14041
{
	// Fields
	private static T sInstance; // 0x0

	// Properties
	public static T instance { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static T get_instance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10973F0 Offset: 0x1095DF0 VA: 0x1810973F0
	|-Singleton<object>.get_instance
	*/

	// RVA: -1 Offset: -1
	public static void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C3300 Offset: 0x11C1D00 VA: 0x1811C3300
	|-Singleton<object>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 4
	protected virtual void Awake() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C2EA0 Offset: 0x11C18A0 VA: 0x1811C2EA0
	|-Singleton<object>.Awake
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	|-Singleton<object>..ctor
	*/
}
