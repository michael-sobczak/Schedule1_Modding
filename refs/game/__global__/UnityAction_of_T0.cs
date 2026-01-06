public sealed class UnityAction<T0> : MulticastDelegate // TypeDefIndex: 11966
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x642E10 Offset: 0x641810 VA: 0x180642E10
	|-UnityAction<bool>..ctor
	|
	|-RVA: 0xB0F840 Offset: 0xB0E240 VA: 0x180B0F840
	|-UnityAction<Color>..ctor
	|-UnityAction<InputAction.CallbackContext>..ctor
	|
	|-RVA: 0x8447E0 Offset: 0x8431E0 VA: 0x1808447E0
	|-UnityAction<int>..ctor
	|-UnityAction<Int32Enum>..ctor
	|
	|-RVA: 0x593440 Offset: 0x591E40 VA: 0x180593440
	|-UnityAction<object>..ctor
	|
	|-RVA: 0xFE32D0 Offset: 0xFE1CD0 VA: 0x180FE32D0
	|-UnityAction<RaycastHit>..ctor
	|
	|-RVA: 0x12CAF60 Offset: 0x12C9960 VA: 0x1812CAF60
	|-UnityAction<Scene>..ctor
	|
	|-RVA: 0x12CB1D0 Offset: 0x12C9BD0 VA: 0x1812CB1D0
	|-UnityAction<float>..ctor
	|
	|-RVA: 0x12CB120 Offset: 0x12C9B20 VA: 0x1812CB120
	|-UnityAction<Vector2>..ctor
	|
	|-RVA: 0xFE2EB0 Offset: 0xFE18B0 VA: 0x180FE2EB0
	|-UnityAction<Vector3>..ctor
	|
	|-RVA: 0x12CB010 Offset: 0x12C9A10 VA: 0x1812CB010
	|-UnityAction<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T0 arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x593430 Offset: 0x591E30 VA: 0x180593430
	|-UnityAction<bool>.Invoke
	|-UnityAction<int>.Invoke
	|-UnityAction<Int32Enum>.Invoke
	|-UnityAction<object>.Invoke
	|-UnityAction<Scene>.Invoke
	|-UnityAction<float>.Invoke
	|-UnityAction<Vector2>.Invoke
	|-UnityAction<__Il2CppFullySharedGenericType>.Invoke
	|
	|-RVA: 0xB0F810 Offset: 0xB0E210 VA: 0x180B0F810
	|-UnityAction<Color>.Invoke
	|-UnityAction<InputAction.CallbackContext>.Invoke
	|
	|-RVA: 0xFE2DF0 Offset: 0xFE17F0 VA: 0x180FE2DF0
	|-UnityAction<RaycastHit>.Invoke
	|
	|-RVA: 0xFE2DC0 Offset: 0xFE17C0 VA: 0x180FE2DC0
	|-UnityAction<Vector3>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T0 arg0, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12CAB30 Offset: 0x12C9530 VA: 0x1812CAB30
	|-UnityAction<bool>.BeginInvoke
	|
	|-RVA: 0x12CADC0 Offset: 0x12C97C0 VA: 0x1812CADC0
	|-UnityAction<Color>.BeginInvoke
	|
	|-RVA: 0x12CAAB0 Offset: 0x12C94B0 VA: 0x1812CAAB0
	|-UnityAction<int>.BeginInvoke
	|
	|-RVA: 0x12CACB0 Offset: 0x12C96B0 VA: 0x1812CACB0
	|-UnityAction<Int32Enum>.BeginInvoke
	|
	|-RVA: 0x593400 Offset: 0x591E00 VA: 0x180593400
	|-UnityAction<object>.BeginInvoke
	|
	|-RVA: 0x12CAD30 Offset: 0x12C9730 VA: 0x1812CAD30
	|-UnityAction<RaycastHit>.BeginInvoke
	|
	|-RVA: 0x12CAE50 Offset: 0x12C9850 VA: 0x1812CAE50
	|-UnityAction<Scene>.BeginInvoke
	|
	|-RVA: 0x12CAC30 Offset: 0x12C9630 VA: 0x1812CAC30
	|-UnityAction<float>.BeginInvoke
	|
	|-RVA: 0x12CABB0 Offset: 0x12C95B0 VA: 0x1812CABB0
	|-UnityAction<Vector2>.BeginInvoke
	|
	|-RVA: 0x12CAED0 Offset: 0x12C98D0 VA: 0x1812CAED0
	|-UnityAction<Vector3>.BeginInvoke
	|
	|-RVA: 0x12765D0 Offset: 0x1274FD0 VA: 0x1812765D0
	|-UnityAction<__Il2CppFullySharedGenericType>.BeginInvoke
	|
	|-RVA: 0x12CAA20 Offset: 0x12C9420 VA: 0x1812CAA20
	|-UnityAction<InputAction.CallbackContext>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x454C00 Offset: 0x453600 VA: 0x180454C00
	|-UnityAction<bool>.EndInvoke
	|-UnityAction<Color>.EndInvoke
	|-UnityAction<int>.EndInvoke
	|-UnityAction<Int32Enum>.EndInvoke
	|-UnityAction<object>.EndInvoke
	|-UnityAction<RaycastHit>.EndInvoke
	|-UnityAction<Scene>.EndInvoke
	|-UnityAction<float>.EndInvoke
	|-UnityAction<Vector2>.EndInvoke
	|-UnityAction<Vector3>.EndInvoke
	|-UnityAction<__Il2CppFullySharedGenericType>.EndInvoke
	|-UnityAction<InputAction.CallbackContext>.EndInvoke
	*/
}
