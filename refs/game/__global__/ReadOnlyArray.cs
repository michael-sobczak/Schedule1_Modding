public struct ReadOnlyArray.Enumerator<TValue> : IEnumerator<TValue>, IEnumerator, IDisposable // TypeDefIndex: 7842
{
	// Fields
	private readonly TValue[] m_Array; // 0x0
	private readonly int m_IndexStart; // 0x0
	private readonly int m_IndexEnd; // 0x0
	private int m_Index; // 0x0

	// Properties
	public TValue Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(TValue[] array, int index, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x166BA60 Offset: 0x166A460 VA: 0x18166BA60
	|-ReadOnlyArray.Enumerator<InputBinding>..ctor
	|-ReadOnlyArray.Enumerator<InputControlScheme>..ctor
	|-ReadOnlyArray.Enumerator<InputUser>..ctor
	|-ReadOnlyArray.Enumerator<InternedString>..ctor
	|-ReadOnlyArray.Enumerator<NameAndParameters>..ctor
	|-ReadOnlyArray.Enumerator<NamedValue>..ctor
	|-ReadOnlyArray.Enumerator<object>..ctor
	|-ReadOnlyArray.Enumerator<float>..ctor
	|-ReadOnlyArray.Enumerator<Touch>..ctor
	|-ReadOnlyArray.Enumerator<__Il2CppFullySharedGenericType>..ctor
	|-ReadOnlyArray.Enumerator<HIDSupport.HIDPageUsage>..ctor
	|-ReadOnlyArray.Enumerator<InputControlLayout.ControlItem>..ctor
	|-ReadOnlyArray.Enumerator<InputControlScheme.DeviceRequirement>..ctor
	|-ReadOnlyArray.Enumerator<InputEventTrace.DeviceInfo>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-ReadOnlyArray.Enumerator<InputBinding>.Dispose
	|-ReadOnlyArray.Enumerator<InputControlScheme>.Dispose
	|-ReadOnlyArray.Enumerator<InputUser>.Dispose
	|-ReadOnlyArray.Enumerator<InternedString>.Dispose
	|-ReadOnlyArray.Enumerator<NameAndParameters>.Dispose
	|-ReadOnlyArray.Enumerator<NamedValue>.Dispose
	|-ReadOnlyArray.Enumerator<object>.Dispose
	|-ReadOnlyArray.Enumerator<float>.Dispose
	|-ReadOnlyArray.Enumerator<Touch>.Dispose
	|-ReadOnlyArray.Enumerator<__Il2CppFullySharedGenericType>.Dispose
	|-ReadOnlyArray.Enumerator<HIDSupport.HIDPageUsage>.Dispose
	|-ReadOnlyArray.Enumerator<InputControlLayout.ControlItem>.Dispose
	|-ReadOnlyArray.Enumerator<InputControlScheme.DeviceRequirement>.Dispose
	|-ReadOnlyArray.Enumerator<InputEventTrace.DeviceInfo>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1667A00 Offset: 0x1666400 VA: 0x181667A00
	|-ReadOnlyArray.Enumerator<InputBinding>.MoveNext
	|-ReadOnlyArray.Enumerator<InputControlScheme>.MoveNext
	|-ReadOnlyArray.Enumerator<InputUser>.MoveNext
	|-ReadOnlyArray.Enumerator<InternedString>.MoveNext
	|-ReadOnlyArray.Enumerator<NameAndParameters>.MoveNext
	|-ReadOnlyArray.Enumerator<NamedValue>.MoveNext
	|-ReadOnlyArray.Enumerator<object>.MoveNext
	|-ReadOnlyArray.Enumerator<float>.MoveNext
	|-ReadOnlyArray.Enumerator<Touch>.MoveNext
	|-ReadOnlyArray.Enumerator<__Il2CppFullySharedGenericType>.MoveNext
	|-ReadOnlyArray.Enumerator<HIDSupport.HIDPageUsage>.MoveNext
	|-ReadOnlyArray.Enumerator<InputControlLayout.ControlItem>.MoveNext
	|-ReadOnlyArray.Enumerator<InputControlScheme.DeviceRequirement>.MoveNext
	|-ReadOnlyArray.Enumerator<InputEventTrace.DeviceInfo>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16694E0 Offset: 0x1667EE0 VA: 0x1816694E0
	|-ReadOnlyArray.Enumerator<InputBinding>.Reset
	|-ReadOnlyArray.Enumerator<InputControlScheme>.Reset
	|-ReadOnlyArray.Enumerator<InputUser>.Reset
	|-ReadOnlyArray.Enumerator<InternedString>.Reset
	|-ReadOnlyArray.Enumerator<NameAndParameters>.Reset
	|-ReadOnlyArray.Enumerator<NamedValue>.Reset
	|-ReadOnlyArray.Enumerator<object>.Reset
	|-ReadOnlyArray.Enumerator<float>.Reset
	|-ReadOnlyArray.Enumerator<Touch>.Reset
	|-ReadOnlyArray.Enumerator<__Il2CppFullySharedGenericType>.Reset
	|-ReadOnlyArray.Enumerator<HIDSupport.HIDPageUsage>.Reset
	|-ReadOnlyArray.Enumerator<InputControlLayout.ControlItem>.Reset
	|-ReadOnlyArray.Enumerator<InputControlScheme.DeviceRequirement>.Reset
	|-ReadOnlyArray.Enumerator<InputEventTrace.DeviceInfo>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TValue get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x166C8C0 Offset: 0x166B2C0 VA: 0x18166C8C0
	|-ReadOnlyArray.Enumerator<InputBinding>.get_Current
	|
	|-RVA: 0x166C460 Offset: 0x166AE60 VA: 0x18166C460
	|-ReadOnlyArray.Enumerator<InputControlScheme>.get_Current
	|-ReadOnlyArray.Enumerator<NameAndParameters>.get_Current
	|-ReadOnlyArray.Enumerator<NamedValue>.get_Current
	|-ReadOnlyArray.Enumerator<Touch>.get_Current
	|
	|-RVA: 0x166CD90 Offset: 0x166B790 VA: 0x18166CD90
	|-ReadOnlyArray.Enumerator<InputUser>.get_Current
	|
	|-RVA: 0x166C570 Offset: 0x166AF70 VA: 0x18166C570
	|-ReadOnlyArray.Enumerator<InternedString>.get_Current
	|-ReadOnlyArray.Enumerator<InputControlScheme.DeviceRequirement>.get_Current
	|
	|-RVA: 0x166CD10 Offset: 0x166B710 VA: 0x18166CD10
	|-ReadOnlyArray.Enumerator<object>.get_Current
	|-ReadOnlyArray.Enumerator<HIDSupport.HIDPageUsage>.get_Current
	|
	|-RVA: 0x1670B90 Offset: 0x166F590 VA: 0x181670B90
	|-ReadOnlyArray.Enumerator<float>.get_Current
	|
	|-RVA: 0x167BD90 Offset: 0x167A790 VA: 0x18167BD90
	|-ReadOnlyArray.Enumerator<__Il2CppFullySharedGenericType>.get_Current
	|
	|-RVA: 0x167B870 Offset: 0x167A270 VA: 0x18167B870
	|-ReadOnlyArray.Enumerator<InputControlLayout.ControlItem>.get_Current
	|
	|-RVA: 0x167B3C0 Offset: 0x1679DC0 VA: 0x18167B3C0
	|-ReadOnlyArray.Enumerator<InputEventTrace.DeviceInfo>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x166B430 Offset: 0x1669E30 VA: 0x18166B430
	|-ReadOnlyArray.Enumerator<InputBinding>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x166A3C0 Offset: 0x1668DC0 VA: 0x18166A3C0
	|-ReadOnlyArray.Enumerator<InputControlScheme>.System.Collections.IEnumerator.get_Current
	|-ReadOnlyArray.Enumerator<NameAndParameters>.System.Collections.IEnumerator.get_Current
	|-ReadOnlyArray.Enumerator<NamedValue>.System.Collections.IEnumerator.get_Current
	|-ReadOnlyArray.Enumerator<Touch>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x166B5C0 Offset: 0x1669FC0 VA: 0x18166B5C0
	|-ReadOnlyArray.Enumerator<InputUser>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x166B0C0 Offset: 0x1669AC0 VA: 0x18166B0C0
	|-ReadOnlyArray.Enumerator<InternedString>.System.Collections.IEnumerator.get_Current
	|-ReadOnlyArray.Enumerator<InputControlScheme.DeviceRequirement>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x166B330 Offset: 0x1669D30 VA: 0x18166B330
	|-ReadOnlyArray.Enumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x166F4E0 Offset: 0x166DEE0 VA: 0x18166F4E0
	|-ReadOnlyArray.Enumerator<float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1677E90 Offset: 0x1676890 VA: 0x181677E90
	|-ReadOnlyArray.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1678EC0 Offset: 0x16778C0 VA: 0x181678EC0
	|-ReadOnlyArray.Enumerator<HIDSupport.HIDPageUsage>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1677960 Offset: 0x1676360 VA: 0x181677960
	|-ReadOnlyArray.Enumerator<InputControlLayout.ControlItem>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1677860 Offset: 0x1676260 VA: 0x181677860
	|-ReadOnlyArray.Enumerator<InputEventTrace.DeviceInfo>.System.Collections.IEnumerator.get_Current
	*/
}
