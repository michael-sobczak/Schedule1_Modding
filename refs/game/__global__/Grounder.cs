public abstract class Grounder : MonoBehaviour // TypeDefIndex: 14060
{
	// Fields
	[Tooltip("The master weight. Use this to fade in/out the grounding effect.")]
	[Range(0, 1)]
	public float weight; // 0x20
	[Tooltip("The Grounding solver. Not to confuse with IK solvers.")]
	public Grounding solver; // 0x28
	public Grounder.GrounderDelegate OnPreGrounder; // 0x30
	public Grounder.GrounderDelegate OnPostGrounder; // 0x38
	public Grounder.GrounderDelegate OnPostIK; // 0x40
	[CompilerGenerated]
	private bool <initiated>k__BackingField; // 0x48

	// Properties
	public bool initiated { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void ResetPosition();

	[CompilerGenerated]
	// RVA: 0x4D60D0 Offset: 0x4D4AD0 VA: 0x1804D60D0
	public bool get_initiated() { }

	[CompilerGenerated]
	// RVA: 0x4D6480 Offset: 0x4D4E80 VA: 0x1804D6480
	protected void set_initiated(bool value) { }

	// RVA: 0x1EC2710 Offset: 0x1EC1110 VA: 0x181EC2710
	protected Vector3 GetSpineOffsetTarget() { }

	// RVA: 0x1E99D80 Offset: 0x1E98780 VA: 0x181E99D80
	protected void LogWarning(string message) { }

	// RVA: 0x1EC2360 Offset: 0x1EC0D60 VA: 0x181EC2360
	private Vector3 GetLegSpineBendVector(Grounding.Leg leg) { }

	// RVA: 0x1EC2510 Offset: 0x1EC0F10 VA: 0x181EC2510
	private Vector3 GetLegSpineTangent(Grounding.Leg leg) { }

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void OpenUserManual();

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void OpenScriptReference();

	// RVA: 0x1EC29E0 Offset: 0x1EC13E0 VA: 0x181EC29E0
	protected void .ctor() { }
}
