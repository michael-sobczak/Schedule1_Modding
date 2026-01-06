private struct InlinedArray.Enumerator<TValue> : IEnumerator<TValue>, IEnumerator, IDisposable // TypeDefIndex: 7810
{
	// Fields
	public InlinedArray<TValue> array; // 0x0
	public int index; // 0x0

	// Properties
	public TValue Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1662E90 Offset: 0x1661890 VA: 0x181662E90
	|-InlinedArray.Enumerator<KeyValuePair<int, int>>.MoveNext
	|-InlinedArray.Enumerator<GCHandle>.MoveNext
	|-InlinedArray.Enumerator<object>.MoveNext
	|-InlinedArray.Enumerator<ulong>.MoveNext
	|
	|-RVA: 0x16685A0 Offset: 0x1666FA0 VA: 0x1816685A0
	|-InlinedArray.Enumerator<int>.MoveNext
	|
	|-RVA: 0x1668FB0 Offset: 0x16679B0 VA: 0x181668FB0
	|-InlinedArray.Enumerator<InternedString>.MoveNext
	|-InlinedArray.Enumerator<Substring>.MoveNext
	|-InlinedArray.Enumerator<InputUser.OngoingAccountSelection>.MoveNext
	|
	|-RVA: 0x166DF40 Offset: 0x166C940 VA: 0x18166DF40
	|-InlinedArray.Enumerator<PointerModel>.MoveNext
	|
	|-RVA: 0x1675C90 Offset: 0x1674690 VA: 0x181675C90
	|-InlinedArray.Enumerator<__Il2CppFullySharedGenericType>.MoveNext
	|
	|-RVA: 0x16756A0 Offset: 0x16740A0 VA: 0x1816756A0
	|-InlinedArray.Enumerator<InputManager.StateChangeMonitorTimeout>.MoveNext
	|-InlinedArray.Enumerator<OnScreenControl.OnScreenDeviceInfo>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1663D50 Offset: 0x1662750 VA: 0x181663D50
	|-InlinedArray.Enumerator<KeyValuePair<int, int>>.Reset
	|-InlinedArray.Enumerator<GCHandle>.Reset
	|-InlinedArray.Enumerator<object>.Reset
	|-InlinedArray.Enumerator<ulong>.Reset
	|
	|-RVA: 0x1663BF0 Offset: 0x16625F0 VA: 0x181663BF0
	|-InlinedArray.Enumerator<int>.Reset
	|
	|-RVA: 0x1663D60 Offset: 0x1662760 VA: 0x181663D60
	|-InlinedArray.Enumerator<InternedString>.Reset
	|-InlinedArray.Enumerator<Substring>.Reset
	|-InlinedArray.Enumerator<InputUser.OngoingAccountSelection>.Reset
	|
	|-RVA: 0x166E880 Offset: 0x166D280 VA: 0x18166E880
	|-InlinedArray.Enumerator<PointerModel>.Reset
	|
	|-RVA: 0x1676370 Offset: 0x1674D70 VA: 0x181676370
	|-InlinedArray.Enumerator<__Il2CppFullySharedGenericType>.Reset
	|
	|-RVA: 0x16760A0 Offset: 0x1674AA0 VA: 0x1816760A0
	|-InlinedArray.Enumerator<InputManager.StateChangeMonitorTimeout>.Reset
	|-InlinedArray.Enumerator<OnScreenControl.OnScreenDeviceInfo>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TValue get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1667560 Offset: 0x1665F60 VA: 0x181667560
	|-InlinedArray.Enumerator<KeyValuePair<int, int>>.get_Current
	|
	|-RVA: 0x166CA80 Offset: 0x166B480 VA: 0x18166CA80
	|-InlinedArray.Enumerator<GCHandle>.get_Current
	|-InlinedArray.Enumerator<object>.get_Current
	|-InlinedArray.Enumerator<ulong>.get_Current
	|
	|-RVA: 0x166C390 Offset: 0x166AD90 VA: 0x18166C390
	|-InlinedArray.Enumerator<int>.get_Current
	|
	|-RVA: 0x166C790 Offset: 0x166B190 VA: 0x18166C790
	|-InlinedArray.Enumerator<InternedString>.get_Current
	|-InlinedArray.Enumerator<Substring>.get_Current
	|-InlinedArray.Enumerator<InputUser.OngoingAccountSelection>.get_Current
	|
	|-RVA: 0x1670D50 Offset: 0x166F750 VA: 0x181670D50
	|-InlinedArray.Enumerator<PointerModel>.get_Current
	|
	|-RVA: 0x167B0D0 Offset: 0x1679AD0 VA: 0x18167B0D0
	|-InlinedArray.Enumerator<__Il2CppFullySharedGenericType>.get_Current
	|
	|-RVA: 0x167BAD0 Offset: 0x167A4D0 VA: 0x18167BAD0
	|-InlinedArray.Enumerator<InputManager.StateChangeMonitorTimeout>.get_Current
	|-InlinedArray.Enumerator<OnScreenControl.OnScreenDeviceInfo>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16659C0 Offset: 0x16643C0 VA: 0x1816659C0
	|-InlinedArray.Enumerator<KeyValuePair<int, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x166A580 Offset: 0x1668F80 VA: 0x18166A580
	|-InlinedArray.Enumerator<GCHandle>.System.Collections.IEnumerator.get_Current
	|-InlinedArray.Enumerator<ulong>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x166A890 Offset: 0x1669290 VA: 0x18166A890
	|-InlinedArray.Enumerator<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x166B1B0 Offset: 0x1669BB0 VA: 0x18166B1B0
	|-InlinedArray.Enumerator<InternedString>.System.Collections.IEnumerator.get_Current
	|-InlinedArray.Enumerator<Substring>.System.Collections.IEnumerator.get_Current
	|-InlinedArray.Enumerator<InputUser.OngoingAccountSelection>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x166A9D0 Offset: 0x16693D0 VA: 0x18166A9D0
	|-InlinedArray.Enumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x166F640 Offset: 0x166E040 VA: 0x18166F640
	|-InlinedArray.Enumerator<PointerModel>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1678A30 Offset: 0x1677430 VA: 0x181678A30
	|-InlinedArray.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1678220 Offset: 0x1676C20 VA: 0x181678220
	|-InlinedArray.Enumerator<InputManager.StateChangeMonitorTimeout>.System.Collections.IEnumerator.get_Current
	|-InlinedArray.Enumerator<OnScreenControl.OnScreenDeviceInfo>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-InlinedArray.Enumerator<KeyValuePair<int, int>>.Dispose
	|-InlinedArray.Enumerator<GCHandle>.Dispose
	|-InlinedArray.Enumerator<int>.Dispose
	|-InlinedArray.Enumerator<InternedString>.Dispose
	|-InlinedArray.Enumerator<object>.Dispose
	|-InlinedArray.Enumerator<PointerModel>.Dispose
	|-InlinedArray.Enumerator<Substring>.Dispose
	|-InlinedArray.Enumerator<ulong>.Dispose
	|-InlinedArray.Enumerator<__Il2CppFullySharedGenericType>.Dispose
	|-InlinedArray.Enumerator<InputManager.StateChangeMonitorTimeout>.Dispose
	|-InlinedArray.Enumerator<InputUser.OngoingAccountSelection>.Dispose
	|-InlinedArray.Enumerator<OnScreenControl.OnScreenDeviceInfo>.Dispose
	*/
}
