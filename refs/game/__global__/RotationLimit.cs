public abstract class RotationLimit : MonoBehaviour // TypeDefIndex: 14169
{
	// Fields
	public Vector3 axis; // 0x20
	[HideInInspector]
	public Quaternion defaultLocalRotation; // 0x2C
	[CompilerGenerated]
	private bool <defaultLocalRotationOverride>k__BackingField; // 0x3C
	private bool initiated; // 0x3D
	private bool applicationQuit; // 0x3E
	private bool defaultLocalRotationSet; // 0x3F

	// Properties
	public Vector3 secondaryAxis { get; }
	public Vector3 crossAxis { get; }
	public bool defaultLocalRotationOverride { get; set; }

	// Methods

	// RVA: 0x1F2F560 Offset: 0x1F2DF60 VA: 0x181F2F560
	public void SetDefaultLocalRotation() { }

	// RVA: 0x1F2F5A0 Offset: 0x1F2DFA0 VA: 0x181F2F5A0
	public void SetDefaultLocalRotation(Quaternion localRotation) { }

	// RVA: 0x1F2EA10 Offset: 0x1F2D410 VA: 0x181F2EA10
	public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed) { }

	// RVA: 0x1F2E810 Offset: 0x1F2D210 VA: 0x181F2E810
	public bool Apply() { }

	// RVA: 0x1F2E9E0 Offset: 0x1F2D3E0 VA: 0x181F2E9E0
	public void Disable() { }

	// RVA: 0x1F2F690 Offset: 0x1F2E090 VA: 0x181F2F690
	public Vector3 get_secondaryAxis() { }

	// RVA: 0x1F2F610 Offset: 0x1F2E010 VA: 0x181F2F610
	public Vector3 get_crossAxis() { }

	[CompilerGenerated]
	// RVA: 0x495E90 Offset: 0x494890 VA: 0x180495E90
	public bool get_defaultLocalRotationOverride() { }

	[CompilerGenerated]
	// RVA: 0x66B060 Offset: 0x669A60 VA: 0x18066B060
	private void set_defaultLocalRotationOverride(bool value) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract Quaternion LimitRotation(Quaternion rotation);

	// RVA: 0x1F2E8B0 Offset: 0x1F2D2B0 VA: 0x181F2E8B0
	private void Awake() { }

	// RVA: 0x1F2EED0 Offset: 0x1F2D8D0 VA: 0x181F2EED0
	private void LateUpdate() { }

	// RVA: 0x1E99D80 Offset: 0x1E98780 VA: 0x181E99D80
	public void LogWarning(string message) { }

	// RVA: 0x1F2EF70 Offset: 0x1F2D970 VA: 0x181F2EF70
	protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis) { }

	// RVA: 0x1F2F160 Offset: 0x1F2DB60 VA: 0x181F2F160
	protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit) { }

	// RVA: 0x1F2EE50 Offset: 0x1F2D850 VA: 0x181F2EE50
	protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal) { }

	// RVA: 0x1F2F5B0 Offset: 0x1F2DFB0 VA: 0x181F2F5B0
	protected void .ctor() { }
}
