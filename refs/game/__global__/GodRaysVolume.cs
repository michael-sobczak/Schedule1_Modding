public class GodRaysVolume : VolumeComponent, IPostProcessComponent // TypeDefIndex: 18732
{
	// Fields
	public FloatParameter MainLightIntensity; // 0x38
	public FloatParameter AdditionalLightsIntensity; // 0x40
	public ClampedFloatParameter MainLightScattering; // 0x48
	public ClampedFloatParameter AdditionalLightsScattering; // 0x50
	public ColorParameter Tint; // 0x58

	// Methods

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 8
	public bool IsActive() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 9
	public bool IsTileCompatible() { }

	// RVA: 0xCC3CB0 Offset: 0xCC26B0 VA: 0x180CC3CB0
	public void .ctor() { }
}
