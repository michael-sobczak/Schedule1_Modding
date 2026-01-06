public class EditorIK : MonoBehaviour // TypeDefIndex: 14185
{
	// Fields
	[Tooltip("If slot assigned, will update Animator before IK.")]
	public Animator animator; // 0x20
	[Tooltip("Create/Final IK/Editor IK Pose")]
	public EditorIKPose defaultPose; // 0x28
	[HideInInspector]
	public Transform[] bones; // 0x30
	[CompilerGenerated]
	private IK <ik>k__BackingField; // 0x38

	// Properties
	public IK ik { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public IK get_ik() { }

	[CompilerGenerated]
	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	private void set_ik(IK value) { }

	// RVA: 0x1F1ED40 Offset: 0x1F1D740 VA: 0x181F1ED40
	private void OnEnable() { }

	// RVA: 0x1F1EC30 Offset: 0x1F1D630 VA: 0x181F1EC30
	private void OnDisable() { }

	// RVA: 0x1F1EAB0 Offset: 0x1F1D4B0 VA: 0x181F1EAB0
	private void OnDestroy() { }

	// RVA: 0x1F1EED0 Offset: 0x1F1D8D0 VA: 0x181F1EED0
	public void StoreDefaultPose() { }

	// RVA: 0x1F1E870 Offset: 0x1F1D270 VA: 0x181F1E870
	public bool Initiate() { }

	// RVA: 0x1F1F0B0 Offset: 0x1F1DAB0 VA: 0x181F1F0B0
	public void Update() { }

	// RVA: 0x1F1F3F0 Offset: 0x1F1DDF0 VA: 0x181F1F3F0
	public void .ctor() { }
}
