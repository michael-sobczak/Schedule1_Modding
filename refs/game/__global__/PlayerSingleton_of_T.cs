public abstract class PlayerSingleton<T> : MonoBehaviour // TypeDefIndex: 1929
{
	// Fields
	private static T instance; // 0x0

	// Properties
	public static bool InstanceExists { get; }
	public static T Instance { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public static bool get_InstanceExists() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F6390 Offset: 0x10F4D90 VA: 0x1810F6390
	|-PlayerSingleton<object>.get_InstanceExists
	*/

	// RVA: -1 Offset: -1
	public static T get_Instance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10973F0 Offset: 0x1095DF0 VA: 0x1810973F0
	|-PlayerSingleton<object>.get_Instance
	*/

	// RVA: -1 Offset: -1
	protected static void set_Instance(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA616F0 Offset: 0xA600F0 VA: 0x180A616F0
	|-PlayerSingleton<object>.set_Instance
	*/

	// RVA: -1 Offset: -1 Slot: 4
	protected virtual void Awake() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F5FF0 Offset: 0x10F49F0 VA: 0x1810F5FF0
	|-PlayerSingleton<object>.Awake
	*/

	// RVA: -1 Offset: -1 Slot: 5
	protected virtual void Start() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-PlayerSingleton<object>.Start
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public virtual void OnStartClient(bool IsOwner) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F60D0 Offset: 0x10F4AD0 VA: 0x1810F60D0
	|-PlayerSingleton<object>.OnStartClient
	*/

	// RVA: -1 Offset: -1 Slot: 7
	protected virtual void OnDestroy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F6010 Offset: 0x10F4A10 VA: 0x1810F6010
	|-PlayerSingleton<object>.OnDestroy
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	|-PlayerSingleton<object>..ctor
	*/
}
