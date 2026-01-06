internal abstract class BaseInvokableCall // TypeDefIndex: 11952
{
	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }

	// RVA: 0x2CD5120 Offset: 0x2CD3B20 VA: 0x182CD5120
	protected void .ctor(object target, MethodInfo function) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Invoke(object[] args);

	// RVA: -1 Offset: -1
	protected static void ThrowOnInvalidArg<T>(object arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE58490 Offset: 0xE56E90 VA: 0x180E58490
	|-BaseInvokableCall.ThrowOnInvalidArg<bool>
	|-BaseInvokableCall.ThrowOnInvalidArg<Color>
	|-BaseInvokableCall.ThrowOnInvalidArg<int>
	|-BaseInvokableCall.ThrowOnInvalidArg<Int32Enum>
	|-BaseInvokableCall.ThrowOnInvalidArg<object>
	|-BaseInvokableCall.ThrowOnInvalidArg<RaycastHit>
	|-BaseInvokableCall.ThrowOnInvalidArg<float>
	|-BaseInvokableCall.ThrowOnInvalidArg<Vector2>
	|-BaseInvokableCall.ThrowOnInvalidArg<Vector3>
	|-BaseInvokableCall.ThrowOnInvalidArg<__Il2CppFullySharedGenericType>
	|-BaseInvokableCall.ThrowOnInvalidArg<InputAction.CallbackContext>
	*/

	// RVA: 0x2CD5090 Offset: 0x2CD3A90 VA: 0x182CD5090
	protected static bool AllowInvoke(Delegate delegate) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool Find(object targetObj, MethodInfo method);
}
