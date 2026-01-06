public abstract class ParameterOverride // TypeDefIndex: 17016
{
	// Fields
	public bool overrideState; // 0x10

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract void Interp(ParameterOverride from, ParameterOverride to, float t);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int GetHash();

	// RVA: -1 Offset: -1
	public T GetValue<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF1CAF0 Offset: 0xF1B4F0 VA: 0x180F1CAF0
	|-ParameterOverride.GetValue<bool>
	|
	|-RVA: 0xF1CBC0 Offset: 0xF1B5C0 VA: 0x180F1CBC0
	|-ParameterOverride.GetValue<Color>
	|-ParameterOverride.GetValue<Vector4>
	|
	|-RVA: 0xF1CDA0 Offset: 0xF1B7A0 VA: 0x180F1CDA0
	|-ParameterOverride.GetValue<int>
	|-ParameterOverride.GetValue<Int32Enum>
	|
	|-RVA: 0xF1CE70 Offset: 0xF1B870 VA: 0x180F1CE70
	|-ParameterOverride.GetValue<object>
	|
	|-RVA: 0xF1CF40 Offset: 0xF1B940 VA: 0x180F1CF40
	|-ParameterOverride.GetValue<float>
	|
	|-RVA: 0xF1D010 Offset: 0xF1BA10 VA: 0x180F1D010
	|-ParameterOverride.GetValue<Vector2>
	|
	|-RVA: 0xF1D0F0 Offset: 0xF1BAF0 VA: 0x180F1D0F0
	|-ParameterOverride.GetValue<Vector3>
	|
	|-RVA: 0xF1CCA0 Offset: 0xF1B6A0 VA: 0x180F1CCA0
	|-ParameterOverride.GetValue<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 6
	protected internal virtual void OnEnable() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 7
	protected internal virtual void OnDisable() { }

	// RVA: -1 Offset: -1 Slot: 8
	internal abstract void SetValue(ParameterOverride parameter);

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}
