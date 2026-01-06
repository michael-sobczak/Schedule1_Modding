public abstract class InputBindingComposite<TValue> : InputBindingComposite // TypeDefIndex: 7319
{
	// Properties
	public override Type valueType { get; }
	public override int valueSizeInBytes { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public override Type get_valueType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x186DF90 Offset: 0x186C990 VA: 0x18186DF90
	|-InputBindingComposite<int>.get_valueType
	|
	|-RVA: 0x186E050 Offset: 0x186CA50 VA: 0x18186E050
	|-InputBindingComposite<Quaternion>.get_valueType
	|
	|-RVA: 0x186DED0 Offset: 0x186C8D0 VA: 0x18186DED0
	|-InputBindingComposite<float>.get_valueType
	|
	|-RVA: 0x186DF30 Offset: 0x186C930 VA: 0x18186DF30
	|-InputBindingComposite<Vector2>.get_valueType
	|
	|-RVA: 0x186DFF0 Offset: 0x186C9F0 VA: 0x18186DFF0
	|-InputBindingComposite<Vector3>.get_valueType
	|
	|-RVA: 0x186DE70 Offset: 0x186C870 VA: 0x18186DE70
	|-InputBindingComposite<__Il2CppFullySharedGenericStructType>.get_valueType
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override int get_valueSizeInBytes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6CD160 Offset: 0x6CBB60 VA: 0x1806CD160
	|-InputBindingComposite<int>.get_valueSizeInBytes
	|-InputBindingComposite<float>.get_valueSizeInBytes
	|
	|-RVA: 0xF6D420 Offset: 0xF6BE20 VA: 0x180F6D420
	|-InputBindingComposite<Quaternion>.get_valueSizeInBytes
	|
	|-RVA: 0x6AA790 Offset: 0x6A9190 VA: 0x1806AA790
	|-InputBindingComposite<Vector2>.get_valueSizeInBytes
	|
	|-RVA: 0x8793B0 Offset: 0x877DB0 VA: 0x1808793B0
	|-InputBindingComposite<Vector3>.get_valueSizeInBytes
	|
	|-RVA: 0x186DE50 Offset: 0x186C850 VA: 0x18186DE50
	|-InputBindingComposite<__Il2CppFullySharedGenericStructType>.get_valueSizeInBytes
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public abstract TValue ReadValue(ref InputBindingCompositeContext context);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-InputBindingComposite<__Il2CppFullySharedGenericStructType>.ReadValue
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override void ReadValue(ref InputBindingCompositeContext context, void* buffer, int bufferSize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x186DB70 Offset: 0x186C570 VA: 0x18186DB70
	|-InputBindingComposite<int>.ReadValue
	|
	|-RVA: 0x186D840 Offset: 0x186C240 VA: 0x18186D840
	|-InputBindingComposite<Quaternion>.ReadValue
	|
	|-RVA: 0x186DCE0 Offset: 0x186C6E0 VA: 0x18186DCE0
	|-InputBindingComposite<float>.ReadValue
	|
	|-RVA: 0x186D470 Offset: 0x186BE70 VA: 0x18186D470
	|-InputBindingComposite<Vector2>.ReadValue
	|
	|-RVA: 0x186D9D0 Offset: 0x186C3D0 VA: 0x18186D9D0
	|-InputBindingComposite<Vector3>.ReadValue
	|
	|-RVA: 0x186D5E0 Offset: 0x186BFE0 VA: 0x18186D5E0
	|-InputBindingComposite<__Il2CppFullySharedGenericStructType>.ReadValue
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override object ReadValueAsObject(ref InputBindingCompositeContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x186D0E0 Offset: 0x186BAE0 VA: 0x18186D0E0
	|-InputBindingComposite<int>.ReadValueAsObject
	|
	|-RVA: 0x186D390 Offset: 0x186BD90 VA: 0x18186D390
	|-InputBindingComposite<Quaternion>.ReadValueAsObject
	|
	|-RVA: 0x186D320 Offset: 0x186BD20 VA: 0x18186D320
	|-InputBindingComposite<float>.ReadValueAsObject
	|
	|-RVA: 0x186D400 Offset: 0x186BE00 VA: 0x18186D400
	|-InputBindingComposite<Vector2>.ReadValueAsObject
	|
	|-RVA: 0x186D150 Offset: 0x186BB50 VA: 0x18186D150
	|-InputBindingComposite<Vector3>.ReadValueAsObject
	|
	|-RVA: 0x186D1D0 Offset: 0x186BBD0 VA: 0x18186D1D0
	|-InputBindingComposite<__Il2CppFullySharedGenericStructType>.ReadValueAsObject
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	|-InputBindingComposite<int>..ctor
	|-InputBindingComposite<Quaternion>..ctor
	|-InputBindingComposite<float>..ctor
	|-InputBindingComposite<Vector2>..ctor
	|-InputBindingComposite<Vector3>..ctor
	|-InputBindingComposite<__Il2CppFullySharedGenericStructType>..ctor
	*/
}
