public class SewerCameraPresense : Singleton<SewerCameraPresense> // TypeDefIndex: 3360
{
	// Fields
	[CompilerGenerated]
	private float <CameraPresenceInSewerArea>k__BackingField; // 0x28
	[CompilerGenerated]
	private float <SmoothedCameraPresenceInSewerArea>k__BackingField; // 0x2C
	public Transform FullPresenseVolumesContainer; // 0x30
	public Transform FadeVolumesContainer; // 0x38
	public SkyProfileOverride SewerSkyProfileOverride; // 0x40
	public Volume SewerPPVolume; // 0x48
	private BoxCollider[] fullPresenceVolumes; // 0x50
	private SewerCameraFadeVolume[] fadeVolumes; // 0x58

	// Properties
	public float CameraPresenceInSewerArea { get; set; }
	public float SmoothedCameraPresenceInSewerArea { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5260F0 Offset: 0x524AF0 VA: 0x1805260F0
	public float get_CameraPresenceInSewerArea() { }

	[CompilerGenerated]
	// RVA: 0x54B820 Offset: 0x54A220 VA: 0x18054B820
	private void set_CameraPresenceInSewerArea(float value) { }

	[CompilerGenerated]
	// RVA: 0x4971C0 Offset: 0x495BC0 VA: 0x1804971C0
	public float get_SmoothedCameraPresenceInSewerArea() { }

	[CompilerGenerated]
	// RVA: 0x5A9D40 Offset: 0x5A8740 VA: 0x1805A9D40
	private void set_SmoothedCameraPresenceInSewerArea(float value) { }

	// RVA: 0xA55B80 Offset: 0xA54580 VA: 0x180A55B80 Slot: 5
	protected override void Awake() { }

	// RVA: 0xA55CE0 Offset: 0xA546E0 VA: 0x180A55CE0
	private void LateUpdate() { }

	// RVA: 0xA55D80 Offset: 0xA54780 VA: 0x180A55D80
	private void UpdatePresense() { }

	// RVA: 0xA55C30 Offset: 0xA54630 VA: 0x180A55C30
	public bool IsPointInSewerArea(Vector3 point) { }

	// RVA: 0xA55F90 Offset: 0xA54990 VA: 0x180A55F90
	public void .ctor() { }
}
