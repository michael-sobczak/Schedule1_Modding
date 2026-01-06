internal sealed class Listeners<TElem> // TypeDefIndex: 12982
{
	// Fields
	private readonly List<TElem> _listeners; // 0x0
	private readonly Listeners.Func<TElem, TElem, bool> _filter; // 0x0
	private readonly int _objectID; // 0x0
	private int _listenerReaderCount; // 0x0

	// Properties
	internal bool HasListeners { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(int ObjectID, Listeners.Func<TElem, TElem, bool> notifyFilter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1055260 Offset: 0x1053C60 VA: 0x181055260
	|-Listeners<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool get_HasListeners() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1055320 Offset: 0x1053D20 VA: 0x181055320
	|-Listeners<object>.get_HasListeners
	*/

	// RVA: -1 Offset: -1
	internal void Add(TElem listener) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1055080 Offset: 0x1053A80 VA: 0x181055080
	|-Listeners<object>.Add
	*/

	// RVA: -1 Offset: -1
	internal int IndexOfReference(TElem listener) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1055100 Offset: 0x1053B00 VA: 0x181055100
	|-Listeners<object>.IndexOfReference
	*/

	// RVA: -1 Offset: -1
	internal void Remove(TElem listener) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10551A0 Offset: 0x1053BA0 VA: 0x1810551A0
	|-Listeners<object>.Remove
	*/

	// RVA: -1 Offset: -1
	internal void Notify<T1, T2, T3>(T1 arg1, T2 arg2, T3 arg3, Listeners.Action<TElem, TElem, T1, T2, T3> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDC7A70 Offset: 0xDC6470 VA: 0x180DC7A70
	|-Listeners<object>.Notify<Int32Enum, object, bool>
	|
	|-RVA: 0xDC7C60 Offset: 0xDC6660 VA: 0x180DC7C60
	|-Listeners<object>.Notify<object, bool, bool>
	|
	|-RVA: 0xDC7720 Offset: 0xDC6120 VA: 0x180DC7720
	|-Listeners<object>.Notify<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private void RemoveNullListeners(int nullIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1055120 Offset: 0x1053B20 VA: 0x181055120
	|-Listeners<object>.RemoveNullListeners
	*/
}
