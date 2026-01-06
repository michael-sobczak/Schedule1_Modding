public abstract class NetworkSingleton<T> : NetworkBehaviour // TypeDefIndex: 1918
{
	// Fields
	private static T instance; // 0x0
	protected bool Destroyed; // 0x0
	private bool NetworkInitialize___EarlyScheduleOne.DevUtilities.NetworkSingleton`1Assembly-CSharp.dll_Excuted; // 0x0
	private bool NetworkInitialize__LateScheduleOne.DevUtilities.NetworkSingleton`1Assembly-CSharp.dll_Excuted; // 0x0

	// Properties
	public static bool InstanceExists { get; }
	public static T Instance { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public static bool get_InstanceExists() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1097360 Offset: 0x1095D60 VA: 0x181097360
	|-NetworkSingleton<object>.get_InstanceExists
	*/

	// RVA: -1 Offset: -1
	public static T get_Instance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10973F0 Offset: 0x1095DF0 VA: 0x1810973F0
	|-NetworkSingleton<object>.get_Instance
	*/

	// RVA: -1 Offset: -1
	protected static void set_Instance(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA616F0 Offset: 0xA600F0 VA: 0x180A616F0
	|-NetworkSingleton<object>.set_Instance
	*/

	// RVA: -1 Offset: -1 Slot: 19
	protected virtual void Start() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-NetworkSingleton<object>.Start
	*/

	// RVA: -1 Offset: -1 Slot: 20
	public override void Awake() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1097220 Offset: 0x1095C20 VA: 0x181097220
	|-NetworkSingleton<object>.Awake
	*/

	// RVA: -1 Offset: -1 Slot: 21
	protected virtual void OnDestroy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10972A0 Offset: 0x1095CA0 VA: 0x1810972A0
	|-NetworkSingleton<object>.OnDestroy
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5FED30 Offset: 0x5FD730 VA: 0x1805FED30
	|-NetworkSingleton<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 22
	public override void NetworkInitialize___Early() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE4D20 Offset: 0xCE3720 VA: 0x180CE4D20
	|-NetworkSingleton<object>.NetworkInitialize___Early
	*/

	// RVA: -1 Offset: -1 Slot: 23
	public override void NetworkInitialize__Late() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1097280 Offset: 0x1095C80 VA: 0x181097280
	|-NetworkSingleton<object>.NetworkInitialize__Late
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override void NetworkInitializeIfDisabled() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x59EFB0 Offset: 0x59D9B0 VA: 0x18059EFB0
	|-NetworkSingleton<object>.NetworkInitializeIfDisabled
	*/

	// RVA: -1 Offset: -1 Slot: 24
	protected virtual void Awake_UserLogic_ScheduleOne.DevUtilities.NetworkSingleton`1_Assembly-CSharp.dll() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1096FF0 Offset: 0x10959F0 VA: 0x181096FF0
	|-NetworkSingleton<object>.Awake_UserLogic_ScheduleOne.DevUtilities.NetworkSingleton`1_Assembly-CSharp.dll
	*/
}
