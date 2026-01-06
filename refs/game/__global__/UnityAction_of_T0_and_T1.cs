public sealed class UnityAction<T0, T1> : MulticastDelegate // TypeDefIndex: 11968
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12CB960 Offset: 0x12CA360 VA: 0x1812CB960
	|-UnityAction<Color, int>..ctor
	|
	|-RVA: 0x12CBA10 Offset: 0x12CA410 VA: 0x1812CBA10
	|-UnityAction<Int32Enum, float>..ctor
	|
	|-RVA: 0x12CBAC0 Offset: 0x12CA4C0 VA: 0x1812CBAC0
	|-UnityAction<object, int>..ctor
	|
	|-RVA: 0x65BB30 Offset: 0x65A530 VA: 0x18065BB30
	|-UnityAction<object, object>..ctor
	|
	|-RVA: 0x12CB8B0 Offset: 0x12CA2B0 VA: 0x1812CB8B0
	|-UnityAction<Scene, Int32Enum>..ctor
	|
	|-RVA: 0x12CB6E0 Offset: 0x12CA0E0 VA: 0x1812CB6E0
	|-UnityAction<Scene, Scene>..ctor
	|
	|-RVA: 0x12CBBF0 Offset: 0x12CA5F0 VA: 0x1812CBBF0
	|-UnityAction<float, float>..ctor
	|
	|-RVA: 0x12CB790 Offset: 0x12CA190 VA: 0x1812CB790
	|-UnityAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T0 arg0, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11DD080 Offset: 0x11DBA80 VA: 0x1811DD080
	|-UnityAction<Color, int>.Invoke
	|
	|-RVA: 0x5554B0 Offset: 0x553EB0 VA: 0x1805554B0
	|-UnityAction<Int32Enum, float>.Invoke
	|-UnityAction<object, int>.Invoke
	|-UnityAction<object, object>.Invoke
	|-UnityAction<Scene, Int32Enum>.Invoke
	|-UnityAction<Scene, Scene>.Invoke
	|-UnityAction<float, float>.Invoke
	|-UnityAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T0 arg0, T1 arg1, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12CB4E0 Offset: 0x12C9EE0 VA: 0x1812CB4E0
	|-UnityAction<Color, int>.BeginInvoke
	|
	|-RVA: 0x12CB320 Offset: 0x12C9D20 VA: 0x1812CB320
	|-UnityAction<Int32Enum, float>.BeginInvoke
	|
	|-RVA: 0x12CB450 Offset: 0x12C9E50 VA: 0x1812CB450
	|-UnityAction<object, int>.BeginInvoke
	|
	|-RVA: 0x65BAF0 Offset: 0x65A4F0 VA: 0x18065BAF0
	|-UnityAction<object, object>.BeginInvoke
	|
	|-RVA: 0x12CB280 Offset: 0x12C9C80 VA: 0x1812CB280
	|-UnityAction<Scene, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x12CB3C0 Offset: 0x12C9DC0 VA: 0x1812CB3C0
	|-UnityAction<Scene, Scene>.BeginInvoke
	|
	|-RVA: 0x12CB580 Offset: 0x12C9F80 VA: 0x1812CB580
	|-UnityAction<float, float>.BeginInvoke
	|
	|-RVA: 0x12CB610 Offset: 0x12CA010 VA: 0x1812CB610
	|-UnityAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x454C00 Offset: 0x453600 VA: 0x180454C00
	|-UnityAction<Color, int>.EndInvoke
	|-UnityAction<Int32Enum, float>.EndInvoke
	|-UnityAction<object, int>.EndInvoke
	|-UnityAction<object, object>.EndInvoke
	|-UnityAction<Scene, Int32Enum>.EndInvoke
	|-UnityAction<Scene, Scene>.EndInvoke
	|-UnityAction<float, float>.EndInvoke
	|-UnityAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.EndInvoke
	*/
}
