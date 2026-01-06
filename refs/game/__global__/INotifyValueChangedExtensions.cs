public static class INotifyValueChangedExtensions // TypeDefIndex: 6319
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static bool RegisterValueChangedCallback<T>(INotifyValueChanged<T> control, EventCallback<ChangeEvent<T>> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xECA220 Offset: 0xEC8C20 VA: 0x180ECA220
	|-INotifyValueChangedExtensions.RegisterValueChangedCallback<bool>
	|-INotifyValueChangedExtensions.RegisterValueChangedCallback<int>
	|-INotifyValueChangedExtensions.RegisterValueChangedCallback<object>
	|-INotifyValueChangedExtensions.RegisterValueChangedCallback<float>
	|-INotifyValueChangedExtensions.RegisterValueChangedCallback<Vector3>
	|-INotifyValueChangedExtensions.RegisterValueChangedCallback<Vector3Int>
	|
	|-RVA: 0xECA2D0 Offset: 0xEC8CD0 VA: 0x180ECA2D0
	|-INotifyValueChangedExtensions.RegisterValueChangedCallback<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool UnregisterValueChangedCallback<T>(INotifyValueChanged<T> control, EventCallback<ChangeEvent<T>> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xECA380 Offset: 0xEC8D80 VA: 0x180ECA380
	|-INotifyValueChangedExtensions.UnregisterValueChangedCallback<bool>
	|-INotifyValueChangedExtensions.UnregisterValueChangedCallback<object>
	|-INotifyValueChangedExtensions.UnregisterValueChangedCallback<float>
	|
	|-RVA: 0xECA2D0 Offset: 0xEC8CD0 VA: 0x180ECA2D0
	|-INotifyValueChangedExtensions.UnregisterValueChangedCallback<__Il2CppFullySharedGenericType>
	*/
}
