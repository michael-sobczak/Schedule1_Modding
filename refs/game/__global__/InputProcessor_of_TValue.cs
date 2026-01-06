public abstract class InputProcessor<TValue> : InputProcessor // TypeDefIndex: 7366
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 7
	public abstract TValue Process(TValue value, InputControl control);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-InputProcessor<__Il2CppFullySharedGenericStructType>.Process
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override object ProcessAsObject(object value, InputControl control) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18837B0 Offset: 0x18821B0 VA: 0x1818837B0
	|-InputProcessor<Bone>.ProcessAsObject
	|
	|-RVA: 0x18825C0 Offset: 0x1880FC0 VA: 0x1818825C0
	|-InputProcessor<bool>.ProcessAsObject
	|
	|-RVA: 0x18830A0 Offset: 0x1881AA0 VA: 0x1818830A0
	|-InputProcessor<double>.ProcessAsObject
	|
	|-RVA: 0x1883C60 Offset: 0x1882660 VA: 0x181883C60
	|-InputProcessor<Eyes>.ProcessAsObject
	|
	|-RVA: 0x18829E0 Offset: 0x18813E0 VA: 0x1818829E0
	|-InputProcessor<int>.ProcessAsObject
	|-InputProcessor<Int32Enum>.ProcessAsObject
	|-InputProcessor<uint>.ProcessAsObject
	|
	|-RVA: 0x1882E10 Offset: 0x1881810 VA: 0x181882E10
	|-InputProcessor<PoseState>.ProcessAsObject
	|
	|-RVA: 0x1883580 Offset: 0x1881F80 VA: 0x181883580
	|-InputProcessor<Quaternion>.ProcessAsObject
	|
	|-RVA: 0x18827D0 Offset: 0x18811D0 VA: 0x1818827D0
	|-InputProcessor<float>.ProcessAsObject
	|
	|-RVA: 0x18839F0 Offset: 0x18823F0 VA: 0x1818839F0
	|-InputProcessor<TouchState>.ProcessAsObject
	|
	|-RVA: 0x1882BF0 Offset: 0x18815F0 VA: 0x181882BF0
	|-InputProcessor<Vector2>.ProcessAsObject
	|
	|-RVA: 0x1883F00 Offset: 0x1882900 VA: 0x181883F00
	|-InputProcessor<Vector3>.ProcessAsObject
	|
	|-RVA: 0x18832B0 Offset: 0x1881CB0 VA: 0x1818832B0
	|-InputProcessor<__Il2CppFullySharedGenericStructType>.ProcessAsObject
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override void Process(void* buffer, int bufferSize, InputControl control) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1884990 Offset: 0x1883390 VA: 0x181884990
	|-InputProcessor<Bone>.Process
	|
	|-RVA: 0x1885340 Offset: 0x1883D40 VA: 0x181885340
	|-InputProcessor<bool>.Process
	|
	|-RVA: 0x1884690 Offset: 0x1883090 VA: 0x181884690
	|-InputProcessor<double>.Process
	|
	|-RVA: 0x1884CE0 Offset: 0x18836E0 VA: 0x181884CE0
	|-InputProcessor<Eyes>.Process
	|
	|-RVA: 0x1884140 Offset: 0x1882B40 VA: 0x181884140
	|-InputProcessor<int>.Process
	|-InputProcessor<Int32Enum>.Process
	|-InputProcessor<uint>.Process
	|
	|-RVA: 0x18842C0 Offset: 0x1882CC0 VA: 0x1818842C0
	|-InputProcessor<PoseState>.Process
	|
	|-RVA: 0x1884EF0 Offset: 0x18838F0 VA: 0x181884EF0
	|-InputProcessor<Quaternion>.Process
	|
	|-RVA: 0x1884810 Offset: 0x1883210 VA: 0x181884810
	|-InputProcessor<float>.Process
	|
	|-RVA: 0x18844B0 Offset: 0x1882EB0 VA: 0x1818844B0
	|-InputProcessor<TouchState>.Process
	|
	|-RVA: 0x1884B60 Offset: 0x1883560 VA: 0x181884B60
	|-InputProcessor<Vector2>.Process
	|
	|-RVA: 0x18854C0 Offset: 0x1883EC0 VA: 0x1818854C0
	|-InputProcessor<Vector3>.Process
	|
	|-RVA: 0x18850A0 Offset: 0x1883AA0 VA: 0x1818850A0
	|-InputProcessor<__Il2CppFullySharedGenericStructType>.Process
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	|-InputProcessor<Bone>..ctor
	|-InputProcessor<bool>..ctor
	|-InputProcessor<double>..ctor
	|-InputProcessor<Eyes>..ctor
	|-InputProcessor<int>..ctor
	|-InputProcessor<Int32Enum>..ctor
	|-InputProcessor<PoseState>..ctor
	|-InputProcessor<Quaternion>..ctor
	|-InputProcessor<float>..ctor
	|-InputProcessor<TouchState>..ctor
	|-InputProcessor<uint>..ctor
	|-InputProcessor<Vector2>..ctor
	|-InputProcessor<Vector3>..ctor
	|-InputProcessor<__Il2CppFullySharedGenericStructType>..ctor
	*/
}
