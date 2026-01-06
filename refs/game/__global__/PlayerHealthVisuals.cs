public class PlayerHealthVisuals : MonoBehaviour // TypeDefIndex: 3388
{
	// Fields
	[Header("References")]
	public Volume[] PPVolumes; // 0x20
	[Header("Vignette")]
	public float VignetteAlpha_MaxHealth; // 0x28
	public float VignetteAlpha_MinHealth; // 0x2C
	public AnimationCurve OuterRingCurve; // 0x30
	[Header("Saturation")]
	public float Saturation_MaxHealth; // 0x38
	public float Saturation_MinHealth; // 0x3C
	[Header("Chromatic Abberation")]
	public float ChromAb_MaxHealth; // 0x40
	public float ChromAb_MinHealth; // 0x44
	[Header("Lens Dirt")]
	public float LensDirt_MaxHealth; // 0x48
	public float LensDirt_MinHealth; // 0x4C
	private Beautify[] _beautifySettings; // 0x50

	// Methods

	// RVA: 0xA75CA0 Offset: 0xA746A0 VA: 0x180A75CA0
	private void Awake() { }

	// RVA: 0xA76250 Offset: 0xA74C50 VA: 0x180A76250
	private void Spawned() { }

	// RVA: 0xA76120 Offset: 0xA74B20 VA: 0x180A76120
	private void MinPass() { }

	// RVA: 0xA763D0 Offset: 0xA74DD0 VA: 0x180A763D0
	private void UpdateEffects(float newHealth) { }

	// RVA: 0xA766C0 Offset: 0xA750C0 VA: 0x180A766C0
	public void .ctor() { }
}
