public class ListStack<GameObject> // TypeDefIndex: 18182
{
	// Fields
	[CompilerGenerated]
	private List<GameObject> <Entries>k__BackingField; // 0x0
	[CompilerGenerated]
	private List<float> <EntriesAddedTimes>k__BackingField; // 0x0
	private float _lastAccessedTime; // 0x0

	// Properties
	public int Count { get; }
	public List<GameObject> Entries { get; set; }
	public List<float> EntriesAddedTimes { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18EA530 Offset: 0x18E8F30 VA: 0x1818EA530
	|-ListStack<object>..ctor
	|
	|-RVA: 0x18EA620 Offset: 0x18E9020 VA: 0x1818EA620
	|-ListStack<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC4AA50 Offset: 0xC49450 VA: 0x180C4AA50
	|-ListStack<object>.get_Count
	|
	|-RVA: 0x126BB10 Offset: 0x126A510 VA: 0x18126BB10
	|-ListStack<__Il2CppFullySharedGenericType>.get_Count
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public List<GameObject> get_Entries() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	|-ListStack<object>.get_Entries
	|-ListStack<__Il2CppFullySharedGenericType>.get_Entries
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_Entries(List<GameObject> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	|-ListStack<object>.set_Entries
	|-ListStack<__Il2CppFullySharedGenericType>.set_Entries
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public List<float> get_EntriesAddedTimes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	|-ListStack<object>.get_EntriesAddedTimes
	|-ListStack<__Il2CppFullySharedGenericType>.get_EntriesAddedTimes
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_EntriesAddedTimes(List<float> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	|-ListStack<object>.set_EntriesAddedTimes
	|-ListStack<__Il2CppFullySharedGenericType>.set_EntriesAddedTimes
	*/

	// RVA: -1 Offset: -1
	public bool AccessedRecently(float threshold) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18E94D0 Offset: 0x18E7ED0 VA: 0x1818E94D0
	|-ListStack<object>.AccessedRecently
	|-ListStack<__Il2CppFullySharedGenericType>.AccessedRecently
	*/

	// RVA: -1 Offset: -1
	public List<GameObject> Cull(float threshold) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18E9630 Offset: 0x18E8030 VA: 0x1818E9630
	|-ListStack<object>.Cull
	|
	|-RVA: 0x18E97E0 Offset: 0x18E81E0 VA: 0x1818E97E0
	|-ListStack<__Il2CppFullySharedGenericType>.Cull
	*/

	// RVA: -1 Offset: -1
	public void Push(GameObject item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18EA010 Offset: 0x18E8A10 VA: 0x1818EA010
	|-ListStack<object>.Push
	|
	|-RVA: 0x18E9E60 Offset: 0x18E8860 VA: 0x1818E9E60
	|-ListStack<__Il2CppFullySharedGenericType>.Push
	*/

	// RVA: -1 Offset: -1
	public GameObject Pop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18E9B30 Offset: 0x18E8530 VA: 0x1818E9B30
	|-ListStack<object>.Pop
	|
	|-RVA: 0x18E9C00 Offset: 0x18E8600 VA: 0x1818E9C00
	|-ListStack<__Il2CppFullySharedGenericType>.Pop
	*/

	// RVA: -1 Offset: -1
	public void Remove(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18EA4A0 Offset: 0x18E8EA0 VA: 0x1818EA4A0
	|-ListStack<object>.Remove
	|
	|-RVA: 0x18EA220 Offset: 0x18E8C20 VA: 0x1818EA220
	|-ListStack<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public bool Remove(GameObject item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18EA150 Offset: 0x18E8B50 VA: 0x1818EA150
	|-ListStack<object>.Remove
	|
	|-RVA: 0x18EA2E0 Offset: 0x18E8CE0 VA: 0x1818EA2E0
	|-ListStack<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18E9500 Offset: 0x18E7F00 VA: 0x1818E9500
	|-ListStack<object>.Clear
	|
	|-RVA: 0x18E9580 Offset: 0x18E7F80 VA: 0x1818E9580
	|-ListStack<__Il2CppFullySharedGenericType>.Clear
	*/
}
