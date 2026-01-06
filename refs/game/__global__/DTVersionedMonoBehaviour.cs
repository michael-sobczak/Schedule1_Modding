public abstract class DTVersionedMonoBehaviour : MonoBehaviour // TypeDefIndex: 10456
{
	// Fields
	[SerializeField]
	[HideInInspector]
	private string m_Version; // 0x20
	[CompilerGenerated]
	private bool <IsActiveAndEnabled>k__BackingField; // 0x28

	// Properties
	public string Version { get; set; }
	protected bool IsActiveAndEnabled { get; set; }

	// Methods

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_Version() { }

	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	protected void set_Version(string value) { }

	[CompilerGenerated]
	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	protected bool get_IsActiveAndEnabled() { }

	[CompilerGenerated]
	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	private void set_IsActiveAndEnabled(bool value) { }

	// RVA: 0x4930E0 Offset: 0x491AE0 VA: 0x1804930E0 Slot: 4
	protected virtual void OnEnable() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 5
	protected virtual void ResetOnEnable() { }

	// RVA: 0x4930D0 Offset: 0x491AD0 VA: 0x1804930D0 Slot: 6
	protected virtual void OnDisable() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 7
	protected virtual void OnValidate() { }

	// RVA: 0x493100 Offset: 0x491B00 VA: 0x180493100 Slot: 8
	protected virtual void Reset() { }

	[Obsolete("Use ObjectExt.Destroy(...) instead")]
	[UsedImplicitly]
	// RVA: 0x493010 Offset: 0x491A10 VA: 0x180493010
	public void Destroy() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	protected void .ctor() { }
}
