public class Listener : MonoBehaviour // TypeDefIndex: 1140
{
	// Fields
	public static List<Listener> listeners; // 0x0
	[Header("Settings")]
	[Range(0.1, 5)]
	public float Sensitivity; // 0x20
	public Transform HearingOrigin; // 0x28
	[CompilerGenerated]
	private float <SquaredHearingRange>k__BackingField; // 0x30
	public Listener.HearingEvent onNoiseHeard; // 0x38

	// Properties
	public float SquaredHearingRange { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x497260 Offset: 0x495C60 VA: 0x180497260
	public float get_SquaredHearingRange() { }

	[CompilerGenerated]
	// RVA: 0x49D320 Offset: 0x49BD20 VA: 0x18049D320
	protected void set_SquaredHearingRange(float value) { }

	// RVA: 0x5DEB20 Offset: 0x5DD520 VA: 0x1805DEB20
	public void Awake() { }

	// RVA: 0x5DEC50 Offset: 0x5DD650 VA: 0x1805DEC50
	public void OnEnable() { }

	// RVA: 0x5DEBD0 Offset: 0x5DD5D0 VA: 0x1805DEBD0
	public void OnDisable() { }

	// RVA: 0x5DEBB0 Offset: 0x5DD5B0 VA: 0x1805DEBB0
	public void Notify(NoiseEvent nEvent) { }

	// RVA: 0x55D3D0 Offset: 0x55BDD0 VA: 0x18055D3D0
	public void .ctor() { }

	// RVA: 0x5DED80 Offset: 0x5DD780 VA: 0x1805DED80
	private static void .cctor() { }
}
