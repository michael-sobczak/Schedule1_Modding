public class Variable<T> : BaseVariable // TypeDefIndex: 615
{
	// Fields
	public T Value; // 0x0
	public UnityEvent<T> OnValueChanged; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(string name, EVariableReplicationMode replicationMode, bool persistent, EVariableMode mode, Player owner, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1393480 Offset: 0x1391E80 VA: 0x181393480
	|-Variable<bool>..ctor
	|
	|-RVA: 0x1393710 Offset: 0x1392110 VA: 0x181393710
	|-Variable<float>..ctor
	|
	|-RVA: 0x1393570 Offset: 0x1391F70 VA: 0x181393570
	|-Variable<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override object GetValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1392070 Offset: 0x1390A70 VA: 0x181392070
	|-Variable<bool>.GetValue
	|
	|-RVA: 0x1392040 Offset: 0x1390A40 VA: 0x181392040
	|-Variable<float>.GetValue
	|
	|-RVA: 0x1391F90 Offset: 0x1390990 VA: 0x181391F90
	|-Variable<__Il2CppFullySharedGenericType>.GetValue
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override void SetValue(object value, bool replicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13930C0 Offset: 0x1391AC0 VA: 0x1813930C0
	|-Variable<bool>.SetValue
	|
	|-RVA: 0x1392D70 Offset: 0x1391770 VA: 0x181392D70
	|-Variable<float>.SetValue
	|
	|-RVA: 0x13927E0 Offset: 0x13911E0 VA: 0x1813927E0
	|-Variable<__Il2CppFullySharedGenericType>.SetValue
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public virtual bool TryDeserialize(string valueString, out T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1393430 Offset: 0x1391E30 VA: 0x181393430
	|-Variable<bool>.TryDeserialize
	|
	|-RVA: 0x1393440 Offset: 0x1391E40 VA: 0x181393440
	|-Variable<float>.TryDeserialize
	|
	|-RVA: 0x1393450 Offset: 0x1391E50 VA: 0x181393450
	|-Variable<__Il2CppFullySharedGenericType>.TryDeserialize
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override void ReplicateValue(NetworkConnection conn) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13920A0 Offset: 0x1390AA0 VA: 0x1813920A0
	|-Variable<bool>.ReplicateValue
	|
	|-RVA: 0x1392620 Offset: 0x1391020 VA: 0x181392620
	|-Variable<float>.ReplicateValue
	|
	|-RVA: 0x13922A0 Offset: 0x1390CA0 VA: 0x1813922A0
	|-Variable<__Il2CppFullySharedGenericType>.ReplicateValue
	*/
}
