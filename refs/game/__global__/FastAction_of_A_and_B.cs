public class FastAction<A, B> // TypeDefIndex: 14830
{
	// Fields
	private LinkedList<Action<A, B>> delegates; // 0x0
	private Dictionary<Action<A, B>, LinkedListNode<Action<A, B>>> lookup; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void Add(Action<A, B> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AF620 Offset: 0x17AE020 VA: 0x1817AF620
	|-FastAction<bool, object>.Add
	|-FastAction<object, object>.Add
	|
	|-RVA: 0x17AF6C0 Offset: 0x17AE0C0 VA: 0x1817AF6C0
	|-FastAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public void Remove(Action<A, B> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AFB00 Offset: 0x17AE500 VA: 0x1817AFB00
	|-FastAction<bool, object>.Remove
	|-FastAction<object, object>.Remove
	|
	|-RVA: 0x17AFA20 Offset: 0x17AE420 VA: 0x1817AFA20
	|-FastAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Call(A a, B b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17B0000 Offset: 0x17AEA00 VA: 0x1817B0000
	|-FastAction<bool, object>.Call
	|
	|-RVA: 0x17AFF70 Offset: 0x17AE970 VA: 0x1817AFF70
	|-FastAction<object, object>.Call
	|
	|-RVA: 0x17AFD60 Offset: 0x17AE760 VA: 0x1817AFD60
	|-FastAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Call
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17B0090 Offset: 0x17AEA90 VA: 0x1817B0090
	|-FastAction<bool, object>..ctor
	|-FastAction<object, object>..ctor
	|
	|-RVA: 0x17B0170 Offset: 0x17AEB70 VA: 0x1817B0170
	|-FastAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}
