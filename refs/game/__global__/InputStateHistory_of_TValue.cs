public class InputStateHistory<TValue> : InputStateHistory, IReadOnlyList<InputStateHistory.Record<TValue>>, IEnumerable<InputStateHistory.Record<TValue>>, IEnumerable, IReadOnlyCollection<InputStateHistory.Record<TValue>> // TypeDefIndex: 7719
{
	// Properties
	public InputStateHistory.Record<TValue> Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Nullable<int> maxStateSizeInBytes) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1886280 Offset: 0x1884C80 VA: 0x181886280
	|-InputStateHistory<TouchState>..ctor
	|
	|-RVA: 0x1885E20 Offset: 0x1884820 VA: 0x181885E20
	|-InputStateHistory<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(InputControl<TValue> control) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18866B0 Offset: 0x18850B0 VA: 0x1818866B0
	|-InputStateHistory<TouchState>..ctor
	|-InputStateHistory<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1885F20 Offset: 0x1884920 VA: 0x181885F20
	|-InputStateHistory<TouchState>..ctor
	|
	|-RVA: 0x1886350 Offset: 0x1884D50 VA: 0x181886350
	|-InputStateHistory<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 1
	protected override void Finalize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18857E0 Offset: 0x18841E0 VA: 0x1818857E0
	|-InputStateHistory<TouchState>.Finalize
	|-InputStateHistory<__Il2CppFullySharedGenericStructType>.Finalize
	*/

	// RVA: -1 Offset: -1
	public InputStateHistory.Record<TValue> AddRecord(InputStateHistory.Record<TValue> record) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1885730 Offset: 0x1884130 VA: 0x181885730
	|-InputStateHistory<TouchState>.AddRecord
	|
	|-RVA: 0x1885680 Offset: 0x1884080 VA: 0x181885680
	|-InputStateHistory<__Il2CppFullySharedGenericStructType>.AddRecord
	*/

	// RVA: -1 Offset: -1
	public InputStateHistory.Record<TValue> RecordStateChange(InputControl<TValue> control, TValue value, double time = -1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1885B40 Offset: 0x1884540 VA: 0x181885B40
	|-InputStateHistory<TouchState>.RecordStateChange
	|
	|-RVA: 0x18858C0 Offset: 0x18842C0 VA: 0x1818858C0
	|-InputStateHistory<__Il2CppFullySharedGenericStructType>.RecordStateChange
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public IEnumerator<InputStateHistory.Record<TValue>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1885860 Offset: 0x1884260 VA: 0x181885860
	|-InputStateHistory<TouchState>.GetEnumerator
	|-InputStateHistory<__Il2CppFullySharedGenericStructType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1885DB0 Offset: 0x18847B0 VA: 0x181885DB0
	|-InputStateHistory<TouchState>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xFCD470 Offset: 0xFCBE70 VA: 0x180FCD470
	|-InputStateHistory<__Il2CppFullySharedGenericStructType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public InputStateHistory.Record<TValue> get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18866C0 Offset: 0x18850C0 VA: 0x1818866C0
	|-InputStateHistory<TouchState>.get_Item
	|-InputStateHistory<__Il2CppFullySharedGenericStructType>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(int index, InputStateHistory.Record<TValue> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1886990 Offset: 0x1885390 VA: 0x181886990
	|-InputStateHistory<TouchState>.set_Item
	|
	|-RVA: 0x1886800 Offset: 0x1885200 VA: 0x181886800
	|-InputStateHistory<__Il2CppFullySharedGenericStructType>.set_Item
	*/
}
