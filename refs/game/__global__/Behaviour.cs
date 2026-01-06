public class Behaviour : Component // TypeDefIndex: 11808
{
	// Properties
	[NativeProperty]
	[RequiredByNativeCode]
	public bool enabled { get; set; }
	[NativeProperty]
	public bool isActiveAndEnabled { get; }

	// Methods

	// RVA: 0x2CB9BA0 Offset: 0x2CB85A0 VA: 0x182CB9BA0
	public bool get_enabled() { }

	// RVA: 0x2CB9C20 Offset: 0x2CB8620 VA: 0x182CB9C20
	public void set_enabled(bool value) { }

	[NativeMethod("IsAddedToManager")]
	// RVA: 0x2CB9BE0 Offset: 0x2CB85E0 VA: 0x182CB9BE0
	public bool get_isActiveAndEnabled() { }

	// RVA: 0x2CB9B50 Offset: 0x2CB8550 VA: 0x182CB9B50
	public void .ctor() { }
}
