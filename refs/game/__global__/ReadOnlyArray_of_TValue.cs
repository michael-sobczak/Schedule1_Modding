public struct ReadOnlyArray<TValue> : IReadOnlyList<TValue>, IEnumerable<TValue>, IEnumerable, IReadOnlyCollection<TValue> // TypeDefIndex: 7843
{
	// Fields
	internal TValue[] m_Array; // 0x0
	internal int m_StartIndex; // 0x0
	internal int m_Length; // 0x0

	// Properties
	public int Count { get; }
	public TValue Item { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(TValue[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1123E10 Offset: 0x1122810 VA: 0x181123E10
	|-ReadOnlyArray<InputBinding>..ctor
	|-ReadOnlyArray<InputControlScheme>..ctor
	|-ReadOnlyArray<InputUser>..ctor
	|-ReadOnlyArray<InternedString>..ctor
	|-ReadOnlyArray<NameAndParameters>..ctor
	|-ReadOnlyArray<NamedValue>..ctor
	|-ReadOnlyArray<object>..ctor
	|-ReadOnlyArray<float>..ctor
	|-ReadOnlyArray<Touch>..ctor
	|-ReadOnlyArray<__Il2CppFullySharedGenericType>..ctor
	|-ReadOnlyArray<HIDSupport.HIDPageUsage>..ctor
	|-ReadOnlyArray<InputControlLayout.ControlItem>..ctor
	|-ReadOnlyArray<InputControlScheme.DeviceRequirement>..ctor
	|-ReadOnlyArray<InputEventTrace.DeviceInfo>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(TValue[] array, int index, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x105E790 Offset: 0x105D190 VA: 0x18105E790
	|-ReadOnlyArray<InputBinding>..ctor
	|-ReadOnlyArray<InputControlScheme>..ctor
	|-ReadOnlyArray<InputUser>..ctor
	|-ReadOnlyArray<InternedString>..ctor
	|-ReadOnlyArray<NameAndParameters>..ctor
	|-ReadOnlyArray<NamedValue>..ctor
	|-ReadOnlyArray<object>..ctor
	|-ReadOnlyArray<float>..ctor
	|-ReadOnlyArray<Touch>..ctor
	|-ReadOnlyArray<__Il2CppFullySharedGenericType>..ctor
	|-ReadOnlyArray<HIDSupport.HIDPageUsage>..ctor
	|-ReadOnlyArray<InputControlLayout.ControlItem>..ctor
	|-ReadOnlyArray<InputControlScheme.DeviceRequirement>..ctor
	|-ReadOnlyArray<InputEventTrace.DeviceInfo>..ctor
	*/

	// RVA: -1 Offset: -1
	public TValue[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1123D80 Offset: 0x1122780 VA: 0x181123D80
	|-ReadOnlyArray<InputBinding>.ToArray
	|-ReadOnlyArray<InputControlScheme>.ToArray
	|-ReadOnlyArray<InputUser>.ToArray
	|-ReadOnlyArray<InternedString>.ToArray
	|-ReadOnlyArray<NameAndParameters>.ToArray
	|-ReadOnlyArray<NamedValue>.ToArray
	|-ReadOnlyArray<object>.ToArray
	|-ReadOnlyArray<float>.ToArray
	|-ReadOnlyArray<Touch>.ToArray
	|-ReadOnlyArray<__Il2CppFullySharedGenericType>.ToArray
	|-ReadOnlyArray<HIDSupport.HIDPageUsage>.ToArray
	|-ReadOnlyArray<InputControlLayout.ControlItem>.ToArray
	|-ReadOnlyArray<InputControlScheme.DeviceRequirement>.ToArray
	|-ReadOnlyArray<InputEventTrace.DeviceInfo>.ToArray
	*/

	// RVA: -1 Offset: -1
	public int IndexOf(Predicate<TValue> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1123840 Offset: 0x1122240 VA: 0x181123840
	|-ReadOnlyArray<InputBinding>.IndexOf
	|
	|-RVA: 0x1122FF0 Offset: 0x11219F0 VA: 0x181122FF0
	|-ReadOnlyArray<InputControlScheme>.IndexOf
	|-ReadOnlyArray<NameAndParameters>.IndexOf
	|-ReadOnlyArray<NamedValue>.IndexOf
	|-ReadOnlyArray<Touch>.IndexOf
	|
	|-RVA: 0x1123570 Offset: 0x1121F70 VA: 0x181123570
	|-ReadOnlyArray<InputUser>.IndexOf
	|
	|-RVA: 0x1123470 Offset: 0x1121E70 VA: 0x181123470
	|-ReadOnlyArray<InternedString>.IndexOf
	|-ReadOnlyArray<InputControlScheme.DeviceRequirement>.IndexOf
	|
	|-RVA: 0x1123660 Offset: 0x1122060 VA: 0x181123660
	|-ReadOnlyArray<object>.IndexOf
	|
	|-RVA: 0x11239D0 Offset: 0x11223D0 VA: 0x1811239D0
	|-ReadOnlyArray<float>.IndexOf
	|
	|-RVA: 0x1123290 Offset: 0x1121C90 VA: 0x181123290
	|-ReadOnlyArray<__Il2CppFullySharedGenericType>.IndexOf
	|
	|-RVA: 0x1123750 Offset: 0x1122150 VA: 0x181123750
	|-ReadOnlyArray<HIDSupport.HIDPageUsage>.IndexOf
	|
	|-RVA: 0x1123110 Offset: 0x1121B10 VA: 0x181123110
	|-ReadOnlyArray<InputControlLayout.ControlItem>.IndexOf
	|
	|-RVA: 0x1123AC0 Offset: 0x11224C0 VA: 0x181123AC0
	|-ReadOnlyArray<InputEventTrace.DeviceInfo>.IndexOf
	*/

	// RVA: -1 Offset: -1
	public ReadOnlyArray.Enumerator<TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1122F70 Offset: 0x1121970 VA: 0x181122F70
	|-ReadOnlyArray<InputBinding>.GetEnumerator
	|-ReadOnlyArray<InputControlScheme>.GetEnumerator
	|-ReadOnlyArray<InputUser>.GetEnumerator
	|-ReadOnlyArray<InternedString>.GetEnumerator
	|-ReadOnlyArray<NameAndParameters>.GetEnumerator
	|-ReadOnlyArray<NamedValue>.GetEnumerator
	|-ReadOnlyArray<object>.GetEnumerator
	|-ReadOnlyArray<float>.GetEnumerator
	|-ReadOnlyArray<Touch>.GetEnumerator
	|-ReadOnlyArray<__Il2CppFullySharedGenericType>.GetEnumerator
	|-ReadOnlyArray<HIDSupport.HIDPageUsage>.GetEnumerator
	|-ReadOnlyArray<InputControlLayout.ControlItem>.GetEnumerator
	|-ReadOnlyArray<InputControlScheme.DeviceRequirement>.GetEnumerator
	|-ReadOnlyArray<InputEventTrace.DeviceInfo>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1123C90 Offset: 0x1122690 VA: 0x181123C90
	|-ReadOnlyArray<InputBinding>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-ReadOnlyArray<InputControlScheme>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-ReadOnlyArray<InputUser>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-ReadOnlyArray<InternedString>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-ReadOnlyArray<NameAndParameters>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-ReadOnlyArray<NamedValue>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-ReadOnlyArray<object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-ReadOnlyArray<float>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-ReadOnlyArray<Touch>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-ReadOnlyArray<HIDSupport.HIDPageUsage>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-ReadOnlyArray<InputControlLayout.ControlItem>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-ReadOnlyArray<InputControlScheme.DeviceRequirement>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-ReadOnlyArray<InputEventTrace.DeviceInfo>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x1123BE0 Offset: 0x11225E0 VA: 0x181123BE0
	|-ReadOnlyArray<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1123C90 Offset: 0x1122690 VA: 0x181123C90
	|-ReadOnlyArray<InputBinding>.System.Collections.IEnumerable.GetEnumerator
	|-ReadOnlyArray<InputControlScheme>.System.Collections.IEnumerable.GetEnumerator
	|-ReadOnlyArray<InputUser>.System.Collections.IEnumerable.GetEnumerator
	|-ReadOnlyArray<InternedString>.System.Collections.IEnumerable.GetEnumerator
	|-ReadOnlyArray<NameAndParameters>.System.Collections.IEnumerable.GetEnumerator
	|-ReadOnlyArray<NamedValue>.System.Collections.IEnumerable.GetEnumerator
	|-ReadOnlyArray<object>.System.Collections.IEnumerable.GetEnumerator
	|-ReadOnlyArray<float>.System.Collections.IEnumerable.GetEnumerator
	|-ReadOnlyArray<Touch>.System.Collections.IEnumerable.GetEnumerator
	|-ReadOnlyArray<HIDSupport.HIDPageUsage>.System.Collections.IEnumerable.GetEnumerator
	|-ReadOnlyArray<InputControlLayout.ControlItem>.System.Collections.IEnumerable.GetEnumerator
	|-ReadOnlyArray<InputControlScheme.DeviceRequirement>.System.Collections.IEnumerable.GetEnumerator
	|-ReadOnlyArray<InputEventTrace.DeviceInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1123BE0 Offset: 0x11225E0 VA: 0x181123BE0
	|-ReadOnlyArray<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public static ReadOnlyArray<TValue> op_Implicit(TValue[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1124590 Offset: 0x1122F90 VA: 0x181124590
	|-ReadOnlyArray<InputBinding>.op_Implicit
	|-ReadOnlyArray<InputControlScheme>.op_Implicit
	|-ReadOnlyArray<InputUser>.op_Implicit
	|-ReadOnlyArray<InternedString>.op_Implicit
	|-ReadOnlyArray<NameAndParameters>.op_Implicit
	|-ReadOnlyArray<NamedValue>.op_Implicit
	|-ReadOnlyArray<object>.op_Implicit
	|-ReadOnlyArray<float>.op_Implicit
	|-ReadOnlyArray<Touch>.op_Implicit
	|-ReadOnlyArray<__Il2CppFullySharedGenericType>.op_Implicit
	|-ReadOnlyArray<HIDSupport.HIDPageUsage>.op_Implicit
	|-ReadOnlyArray<InputControlLayout.ControlItem>.op_Implicit
	|-ReadOnlyArray<InputControlScheme.DeviceRequirement>.op_Implicit
	|-ReadOnlyArray<InputEventTrace.DeviceInfo>.op_Implicit
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4975D0 Offset: 0x495FD0 VA: 0x1804975D0
	|-ReadOnlyArray<InputBinding>.get_Count
	|-ReadOnlyArray<InputControlScheme>.get_Count
	|-ReadOnlyArray<InputUser>.get_Count
	|-ReadOnlyArray<InternedString>.get_Count
	|-ReadOnlyArray<NameAndParameters>.get_Count
	|-ReadOnlyArray<NamedValue>.get_Count
	|-ReadOnlyArray<object>.get_Count
	|-ReadOnlyArray<float>.get_Count
	|-ReadOnlyArray<Touch>.get_Count
	|-ReadOnlyArray<__Il2CppFullySharedGenericType>.get_Count
	|-ReadOnlyArray<HIDSupport.HIDPageUsage>.get_Count
	|-ReadOnlyArray<InputControlLayout.ControlItem>.get_Count
	|-ReadOnlyArray<InputControlScheme.DeviceRequirement>.get_Count
	|-ReadOnlyArray<InputEventTrace.DeviceInfo>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TValue get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1124200 Offset: 0x1122C00 VA: 0x181124200
	|-ReadOnlyArray<InputBinding>.get_Item
	|
	|-RVA: 0x1123FB0 Offset: 0x11229B0 VA: 0x181123FB0
	|-ReadOnlyArray<InputControlScheme>.get_Item
	|-ReadOnlyArray<NameAndParameters>.get_Item
	|-ReadOnlyArray<NamedValue>.get_Item
	|-ReadOnlyArray<Touch>.get_Item
	|
	|-RVA: 0x1123F00 Offset: 0x1122900 VA: 0x181123F00
	|-ReadOnlyArray<InputUser>.get_Item
	|
	|-RVA: 0x1124130 Offset: 0x1122B30 VA: 0x181124130
	|-ReadOnlyArray<InternedString>.get_Item
	|-ReadOnlyArray<InputControlScheme.DeviceRequirement>.get_Item
	|
	|-RVA: 0x1124080 Offset: 0x1122A80 VA: 0x181124080
	|-ReadOnlyArray<object>.get_Item
	|-ReadOnlyArray<HIDSupport.HIDPageUsage>.get_Item
	|
	|-RVA: 0x1123E50 Offset: 0x1122850 VA: 0x181123E50
	|-ReadOnlyArray<float>.get_Item
	|
	|-RVA: 0x1124380 Offset: 0x1122D80 VA: 0x181124380
	|-ReadOnlyArray<__Il2CppFullySharedGenericType>.get_Item
	|
	|-RVA: 0x11244E0 Offset: 0x1122EE0 VA: 0x1811244E0
	|-ReadOnlyArray<InputControlLayout.ControlItem>.get_Item
	|
	|-RVA: 0x11242B0 Offset: 0x1122CB0 VA: 0x1811242B0
	|-ReadOnlyArray<InputEventTrace.DeviceInfo>.get_Item
	*/
}
