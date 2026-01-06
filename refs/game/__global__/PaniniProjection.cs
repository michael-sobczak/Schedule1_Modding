public sealed class PaniniProjection : VolumeComponent, IPostProcessComponent // TypeDefIndex: 8926
{
	// Fields
	[Tooltip("Panini projection distance.")]
	public ClampedFloatParameter distance; // 0x38
	[Tooltip("Panini projection crop to fit.")]
	public ClampedFloatParameter cropToFit; // 0x40

	// Methods

	// RVA: 0x2AFDEC0 Offset: 0x2AFC8C0 VA: 0x182AFDEC0 Slot: 8
	public bool IsActive() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 9
	public bool IsTileCompatible() { }

	// RVA: 0x2B088A0 Offset: 0x2B072A0 VA: 0x182B088A0
	public void .ctor() { }
}
