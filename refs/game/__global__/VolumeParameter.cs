public abstract class VolumeParameter : ICloneable // TypeDefIndex: 13894
{
	// Fields
	public const string k_DebuggerDisplay = "{m_Value} ({m_OverrideState})";
	[SerializeField]
	protected bool m_OverrideState; // 0x10

	// Properties
	public virtual bool overrideState { get; set; }

	// Methods

	// RVA: 0x498A40 Offset: 0x497440 VA: 0x180498A40 Slot: 5
	public virtual bool get_overrideState() { }

	// RVA: 0x498A80 Offset: 0x497480 VA: 0x180498A80 Slot: 6
	public virtual void set_overrideState(bool value) { }

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract void Interp(VolumeParameter from, VolumeParameter to, float t);

	// RVA: -1 Offset: -1
	public T GetValue<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF76A90 Offset: 0xF75490 VA: 0x180F76A90
	|-VolumeParameter.GetValue<bool>
	|-VolumeParameter.GetValue<int>
	|-VolumeParameter.GetValue<Int32Enum>
	|-VolumeParameter.GetValue<LayerMask>
	|-VolumeParameter.GetValue<object>
	|-VolumeParameter.GetValue<float>
	|-VolumeParameter.GetValue<Vector2>
	|
	|-RVA: 0xF76B70 Offset: 0xF75570 VA: 0x180F76B70
	|-VolumeParameter.GetValue<Color>
	|-VolumeParameter.GetValue<Vector4>
	|
	|-RVA: 0xF76DD0 Offset: 0xF757D0 VA: 0x180F76DD0
	|-VolumeParameter.GetValue<Vector3>
	|
	|-RVA: 0xF76C70 Offset: 0xF75670 VA: 0x180F76C70
	|-VolumeParameter.GetValue<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void SetValue(VolumeParameter parameter);

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 9
	protected internal virtual void OnEnable() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 10
	protected internal virtual void OnDisable() { }

	// RVA: 0x2A5D3A0 Offset: 0x2A5BDA0 VA: 0x182A5D3A0
	public static bool IsObjectParameter(Type type) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 11
	public virtual void Release() { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract object Clone();

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}
