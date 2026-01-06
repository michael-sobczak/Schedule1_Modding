public class DTSingleton<T> : MonoBehaviour, IDTSingleton // TypeDefIndex: 10454
{
	// Fields
	private static T _instance; // 0x0
	private static readonly object _lock; // 0x0

	// Properties
	public static bool HasInstance { get; }
	[CanBeNull]
	public static T Instance { get; }

	// Methods

	// RVA: -1 Offset: -1
	protected static void InitializeStaticFields() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E12A0 Offset: 0x14DFCA0 VA: 0x1814E12A0
	|-DTSingleton<object>.InitializeStaticFields
	*/

	// RVA: -1 Offset: -1
	public static bool get_HasInstance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E1450 Offset: 0x14DFE50 VA: 0x1814E1450
	|-DTSingleton<object>.get_HasInstance
	*/

	// RVA: -1 Offset: -1
	public static T get_Instance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E1520 Offset: 0x14DFF20 VA: 0x1814E1520
	|-DTSingleton<object>.get_Instance
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public virtual void Awake() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E0FA0 Offset: 0x14DF9A0 VA: 0x1814E0FA0
	|-DTSingleton<object>.Awake
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public virtual void MergeDoubleLoaded(IDTSingleton newInstance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-DTSingleton<object>.MergeDoubleLoaded
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	|-DTSingleton<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E1380 Offset: 0x14DFD80 VA: 0x1814E1380
	|-DTSingleton<object>..cctor
	*/
}
