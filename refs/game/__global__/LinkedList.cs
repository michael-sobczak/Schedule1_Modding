public struct LinkedList.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator, ISerializable, IDeserializationCallback // TypeDefIndex: 9876
{
	// Fields
	private LinkedList<T> _list; // 0x0
	private LinkedListNode<T> _node; // 0x0
	private int _version; // 0x0
	private T _current; // 0x0
	private int _index; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(LinkedList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16664F0 Offset: 0x1664EF0 VA: 0x1816664F0
	|-LinkedList.Enumerator<ValueTuple<object, object>>..ctor
	|-LinkedList.Enumerator<UIRenderDevice.DeviceToFree>..ctor
	|
	|-RVA: 0x1666C60 Offset: 0x1665660 VA: 0x181666C60
	|-LinkedList.Enumerator<ValueTuple<object, object, object>>..ctor
	|
	|-RVA: 0x1666610 Offset: 0x1665010 VA: 0x181666610
	|-LinkedList.Enumerator<BezierSegment>..ctor
	|
	|-RVA: 0x166B8B0 Offset: 0x166A2B0 VA: 0x18166B8B0
	|-LinkedList.Enumerator<object>..ctor
	|
	|-RVA: 0x16792A0 Offset: 0x1677CA0 VA: 0x1816792A0
	|-LinkedList.Enumerator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private void .ctor(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1283EA0 Offset: 0x12828A0 VA: 0x181283EA0
	|-LinkedList.Enumerator<ValueTuple<object, object>>..ctor
	|-LinkedList.Enumerator<ValueTuple<object, object, object>>..ctor
	|-LinkedList.Enumerator<BezierSegment>..ctor
	|-LinkedList.Enumerator<object>..ctor
	|-LinkedList.Enumerator<__Il2CppFullySharedGenericType>..ctor
	|-LinkedList.Enumerator<UIRenderDevice.DeviceToFree>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x526100 Offset: 0x524B00 VA: 0x180526100
	|-LinkedList.Enumerator<ValueTuple<object, object>>.get_Current
	|-LinkedList.Enumerator<UIRenderDevice.DeviceToFree>.get_Current
	|
	|-RVA: 0x49D250 Offset: 0x49BC50 VA: 0x18049D250
	|-LinkedList.Enumerator<ValueTuple<object, object, object>>.get_Current
	|
	|-RVA: 0x4753E0 Offset: 0x473DE0 VA: 0x1804753E0
	|-LinkedList.Enumerator<BezierSegment>.get_Current
	|
	|-RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	|-LinkedList.Enumerator<object>.get_Current
	|
	|-RVA: 0x167AD60 Offset: 0x1679760 VA: 0x18167AD60
	|-LinkedList.Enumerator<__Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1665D80 Offset: 0x1664780 VA: 0x181665D80
	|-LinkedList.Enumerator<ValueTuple<object, object>>.System.Collections.IEnumerator.get_Current
	|-LinkedList.Enumerator<UIRenderDevice.DeviceToFree>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1664610 Offset: 0x1663010 VA: 0x181664610
	|-LinkedList.Enumerator<ValueTuple<object, object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x16649E0 Offset: 0x16633E0 VA: 0x1816649E0
	|-LinkedList.Enumerator<BezierSegment>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x166ABA0 Offset: 0x16695A0 VA: 0x18166ABA0
	|-LinkedList.Enumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1677430 Offset: 0x1675E30 VA: 0x181677430
	|-LinkedList.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1662490 Offset: 0x1660E90 VA: 0x181662490
	|-LinkedList.Enumerator<ValueTuple<object, object>>.MoveNext
	|
	|-RVA: 0x1663120 Offset: 0x1661B20 VA: 0x181663120
	|-LinkedList.Enumerator<ValueTuple<object, object, object>>.MoveNext
	|
	|-RVA: 0x16639E0 Offset: 0x16623E0 VA: 0x1816639E0
	|-LinkedList.Enumerator<BezierSegment>.MoveNext
	|
	|-RVA: 0x1668260 Offset: 0x1666C60 VA: 0x181668260
	|-LinkedList.Enumerator<object>.MoveNext
	|
	|-RVA: 0x1673950 Offset: 0x1672350 VA: 0x181673950
	|-LinkedList.Enumerator<__Il2CppFullySharedGenericType>.MoveNext
	|
	|-RVA: 0x167DBC0 Offset: 0x167C5C0 VA: 0x18167DBC0
	|-LinkedList.Enumerator<UIRenderDevice.DeviceToFree>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1664340 Offset: 0x1662D40 VA: 0x181664340
	|-LinkedList.Enumerator<ValueTuple<object, object>>.System.Collections.IEnumerator.Reset
	|-LinkedList.Enumerator<UIRenderDevice.DeviceToFree>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x16640C0 Offset: 0x1662AC0 VA: 0x1816640C0
	|-LinkedList.Enumerator<ValueTuple<object, object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1663F50 Offset: 0x1662950 VA: 0x181663F50
	|-LinkedList.Enumerator<BezierSegment>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1669B50 Offset: 0x1668550 VA: 0x181669B50
	|-LinkedList.Enumerator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1676DF0 Offset: 0x16757F0 VA: 0x181676DF0
	|-LinkedList.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-LinkedList.Enumerator<ValueTuple<object, object>>.Dispose
	|-LinkedList.Enumerator<ValueTuple<object, object, object>>.Dispose
	|-LinkedList.Enumerator<BezierSegment>.Dispose
	|-LinkedList.Enumerator<object>.Dispose
	|-LinkedList.Enumerator<__Il2CppFullySharedGenericType>.Dispose
	|-LinkedList.Enumerator<UIRenderDevice.DeviceToFree>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1283EA0 Offset: 0x12828A0 VA: 0x181283EA0
	|-LinkedList.Enumerator<ValueTuple<object, object>>.System.Runtime.Serialization.ISerializable.GetObjectData
	|-LinkedList.Enumerator<ValueTuple<object, object, object>>.System.Runtime.Serialization.ISerializable.GetObjectData
	|-LinkedList.Enumerator<BezierSegment>.System.Runtime.Serialization.ISerializable.GetObjectData
	|-LinkedList.Enumerator<object>.System.Runtime.Serialization.ISerializable.GetObjectData
	|-LinkedList.Enumerator<__Il2CppFullySharedGenericType>.System.Runtime.Serialization.ISerializable.GetObjectData
	|-LinkedList.Enumerator<UIRenderDevice.DeviceToFree>.System.Runtime.Serialization.ISerializable.GetObjectData
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1285B00 Offset: 0x1284500 VA: 0x181285B00
	|-LinkedList.Enumerator<ValueTuple<object, object>>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	|-LinkedList.Enumerator<ValueTuple<object, object, object>>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	|-LinkedList.Enumerator<BezierSegment>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	|-LinkedList.Enumerator<object>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	|-LinkedList.Enumerator<__Il2CppFullySharedGenericType>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	|-LinkedList.Enumerator<UIRenderDevice.DeviceToFree>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	*/
}
