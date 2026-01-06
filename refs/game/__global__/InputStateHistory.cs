public struct InputStateHistory.Record<TValue> : IEquatable<InputStateHistory.Record<TValue>> // TypeDefIndex: 7718
{
	// Fields
	private readonly InputStateHistory<TValue> m_Owner; // 0x0
	private readonly int m_IndexPlusOne; // 0x0
	private uint m_Version; // 0x0

	// Properties
	internal InputStateHistory.RecordHeader* header { get; }
	internal int recordIndex { get; }
	public bool valid { get; }
	public InputStateHistory<TValue> owner { get; }
	public int index { get; }
	public double time { get; }
	public InputControl<TValue> control { get; }
	public InputStateHistory.Record<TValue> next { get; }
	public InputStateHistory.Record<TValue> previous { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal InputStateHistory.RecordHeader* get_header() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11A2D40 Offset: 0x11A1740 VA: 0x1811A2D40
	|-InputStateHistory.Record<TouchState>.get_header
	|
	|-RVA: 0x11A2D90 Offset: 0x11A1790 VA: 0x1811A2D90
	|-InputStateHistory.Record<__Il2CppFullySharedGenericStructType>.get_header
	*/

	// RVA: -1 Offset: -1
	internal int get_recordIndex() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11A3530 Offset: 0x11A1F30 VA: 0x1811A3530
	|-InputStateHistory.Record<TouchState>.get_recordIndex
	|-InputStateHistory.Record<__Il2CppFullySharedGenericStructType>.get_recordIndex
	*/

	// RVA: -1 Offset: -1
	public bool get_valid() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11A3750 Offset: 0x11A2150 VA: 0x1811A3750
	|-InputStateHistory.Record<TouchState>.get_valid
	|
	|-RVA: 0x11A36B0 Offset: 0x11A20B0 VA: 0x1811A36B0
	|-InputStateHistory.Record<__Il2CppFullySharedGenericStructType>.get_valid
	*/

	// RVA: -1 Offset: -1
	public InputStateHistory<TValue> get_owner() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	|-InputStateHistory.Record<TouchState>.get_owner
	|-InputStateHistory.Record<__Il2CppFullySharedGenericStructType>.get_owner
	*/

	// RVA: -1 Offset: -1
	public int get_index() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11A2E30 Offset: 0x11A1830 VA: 0x1811A2E30
	|-InputStateHistory.Record<TouchState>.get_index
	|
	|-RVA: 0x11A2EB0 Offset: 0x11A18B0 VA: 0x1811A2EB0
	|-InputStateHistory.Record<__Il2CppFullySharedGenericStructType>.get_index
	*/

	// RVA: -1 Offset: -1
	public double get_time() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11A3610 Offset: 0x11A2010 VA: 0x1811A3610
	|-InputStateHistory.Record<TouchState>.get_time
	|
	|-RVA: 0x11A3540 Offset: 0x11A1F40 VA: 0x1811A3540
	|-InputStateHistory.Record<__Il2CppFullySharedGenericStructType>.get_time
	*/

	// RVA: -1 Offset: -1
	public InputControl<TValue> get_control() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11A2890 Offset: 0x11A1290 VA: 0x1811A2890
	|-InputStateHistory.Record<TouchState>.get_control
	|
	|-RVA: 0x11A2AE0 Offset: 0x11A14E0 VA: 0x1811A2AE0
	|-InputStateHistory.Record<__Il2CppFullySharedGenericStructType>.get_control
	*/

	// RVA: -1 Offset: -1
	public InputStateHistory.Record<TValue> get_next() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11A3120 Offset: 0x11A1B20 VA: 0x1811A3120
	|-InputStateHistory.Record<TouchState>.get_next
	|
	|-RVA: 0x11A2F90 Offset: 0x11A1990 VA: 0x1811A2F90
	|-InputStateHistory.Record<__Il2CppFullySharedGenericStructType>.get_next
	*/

	// RVA: -1 Offset: -1
	public InputStateHistory.Record<TValue> get_previous() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11A33F0 Offset: 0x11A1DF0 VA: 0x1811A33F0
	|-InputStateHistory.Record<TouchState>.get_previous
	|
	|-RVA: 0x11A3260 Offset: 0x11A1C60 VA: 0x1811A3260
	|-InputStateHistory.Record<__Il2CppFullySharedGenericStructType>.get_previous
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(InputStateHistory<TValue> owner, int index, InputStateHistory.RecordHeader* header) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11A2840 Offset: 0x11A1240 VA: 0x1811A2840
	|-InputStateHistory.Record<TouchState>..ctor
	|-InputStateHistory.Record<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(InputStateHistory<TValue> owner, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11A2810 Offset: 0x11A1210 VA: 0x1811A2810
	|-InputStateHistory.Record<TouchState>..ctor
	|-InputStateHistory.Record<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	public TValue ReadValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11A22B0 Offset: 0x11A0CB0 VA: 0x1811A22B0
	|-InputStateHistory.Record<TouchState>.ReadValue
	|
	|-RVA: 0x11A2110 Offset: 0x11A0B10 VA: 0x1811A2110
	|-InputStateHistory.Record<__Il2CppFullySharedGenericStructType>.ReadValue
	*/

	// RVA: -1 Offset: -1
	public void* GetUnsafeMemoryPtr() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11A1FE0 Offset: 0x11A09E0 VA: 0x1811A1FE0
	|-InputStateHistory.Record<TouchState>.GetUnsafeMemoryPtr
	|
	|-RVA: 0x11A2050 Offset: 0x11A0A50 VA: 0x1811A2050
	|-InputStateHistory.Record<__Il2CppFullySharedGenericStructType>.GetUnsafeMemoryPtr
	*/

	// RVA: -1 Offset: -1
	internal void* GetUnsafeMemoryPtrUnchecked() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11A1EB0 Offset: 0x11A08B0 VA: 0x1811A1EB0
	|-InputStateHistory.Record<TouchState>.GetUnsafeMemoryPtrUnchecked
	|
	|-RVA: 0x11A1D70 Offset: 0x11A0770 VA: 0x1811A1D70
	|-InputStateHistory.Record<__Il2CppFullySharedGenericStructType>.GetUnsafeMemoryPtrUnchecked
	*/

	// RVA: -1 Offset: -1
	public void* GetUnsafeExtraMemoryPtr() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11A1D00 Offset: 0x11A0700 VA: 0x1811A1D00
	|-InputStateHistory.Record<TouchState>.GetUnsafeExtraMemoryPtr
	|
	|-RVA: 0x11A1C40 Offset: 0x11A0640 VA: 0x1811A1C40
	|-InputStateHistory.Record<__Il2CppFullySharedGenericStructType>.GetUnsafeExtraMemoryPtr
	*/

	// RVA: -1 Offset: -1
	internal void* GetUnsafeExtraMemoryPtrUnchecked() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11A1B50 Offset: 0x11A0550 VA: 0x1811A1B50
	|-InputStateHistory.Record<TouchState>.GetUnsafeExtraMemoryPtrUnchecked
	|
	|-RVA: 0x11A1A60 Offset: 0x11A0460 VA: 0x1811A1A60
	|-InputStateHistory.Record<__Il2CppFullySharedGenericStructType>.GetUnsafeExtraMemoryPtrUnchecked
	*/

	// RVA: -1 Offset: -1
	public void CopyFrom(InputStateHistory.Record<TValue> record) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11A12B0 Offset: 0x119FCB0 VA: 0x1811A12B0
	|-InputStateHistory.Record<TouchState>.CopyFrom
	|
	|-RVA: 0x11A14E0 Offset: 0x119FEE0 VA: 0x1811A14E0
	|-InputStateHistory.Record<__Il2CppFullySharedGenericStructType>.CopyFrom
	*/

	// RVA: -1 Offset: -1
	private void CheckValid() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11A11A0 Offset: 0x119FBA0 VA: 0x1811A11A0
	|-InputStateHistory.Record<TouchState>.CheckValid
	|
	|-RVA: 0x11A1090 Offset: 0x119FA90 VA: 0x1811A1090
	|-InputStateHistory.Record<__Il2CppFullySharedGenericStructType>.CheckValid
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(InputStateHistory.Record<TValue> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x105CBF0 Offset: 0x105B5F0 VA: 0x18105CBF0
	|-InputStateHistory.Record<TouchState>.Equals
	|-InputStateHistory.Record<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11A18F0 Offset: 0x11A02F0 VA: 0x1811A18F0
	|-InputStateHistory.Record<TouchState>.Equals
	|
	|-RVA: 0x11A17B0 Offset: 0x11A01B0 VA: 0x1811A17B0
	|-InputStateHistory.Record<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11A1A10 Offset: 0x11A0410 VA: 0x1811A1A10
	|-InputStateHistory.Record<TouchState>.GetHashCode
	|-InputStateHistory.Record<__Il2CppFullySharedGenericStructType>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11A23D0 Offset: 0x11A0DD0 VA: 0x1811A23D0
	|-InputStateHistory.Record<TouchState>.ToString
	|
	|-RVA: 0x11A25A0 Offset: 0x11A0FA0 VA: 0x1811A25A0
	|-InputStateHistory.Record<__Il2CppFullySharedGenericStructType>.ToString
	*/
}
